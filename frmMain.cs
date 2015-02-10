using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Panappta.Debug;
using Panappta.Core;

namespace Panappta {
    public partial class frmMain : Form {
        #region Global
        ITimerHandler ITimer;
        List<NotifItems> nList = new List<NotifItems>();
        #endregion

        #region Init
        /// <summary>
        /// 
        /// </summary>
        public frmMain() {
            InitializeComponent();
            ITimer = new ITimerHandler(true, this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult mExit = MessageBox.Show(
                "You about to exit Panappta. Are you sure you want to continue? You will not see alerts.",
                "Exit notification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            Log.Add("frmMain", "FormClosing", "Request to close the form. Dialog result '{0}'.", mExit.ToString());

            if (mExit == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;

            nSystem.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            pNoAlarms.Location = new Point(346, 24);
            string Process = "x86", Os = "x86";

            if (Environment.Is64BitProcess)
                Process = "x64";
            else
                Process = "x86";

            if (Environment.Is64BitOperatingSystem)
                Os = "x64";
            else
                Os = "x86";


            Log.Add("frmMain", "Load", "Panappta has been initialized at {0}",
                DateTime.Now.ToString());
            Log.Add("frmMain", "Load", "Current user is {0}\\{1}", Environment.UserDomainName, Environment.UserName);
            Log.Add("frmMain", "Load", "Running on {0}", Environment.OSVersion);
            Log.Add("frmMain", "Load", "Panappta is a {0} process, running on a {1} OS",
                Process, Os);

            //DisplayBubble();
            UpdateTasks();

        }

        #endregion

        #region StatsUpdater
        /// <summary>
        /// This is called each time Panopta has been reparsed.
        /// </summary>
        public void UpdatePanopta() {
            NotifItems tmp = new NotifItems();

            ListViewItem lViewItem;
            ListViewItem.ListViewSubItem lViewSubItem;

            lvServers.Invoke(new MethodInvoker(delegate {
                lvServers.Items.Clear();
            }));

            //ToDo: Add function to check if it already exists, and remove new List for nList. 

            if (ITimer.PanoptaList != null) {
                for (int i = 0; i < ITimer.PanoptaList.outage_list.Count; i++) {
                    if (!ServerExists(ITimer.PanoptaList.outage_list[i].server_name)) {
                        Log.Add("frmMain", "UpdatePanopta", "Adding new server to list '{0}'...", ITimer.PanoptaList.outage_list[i].server_name);
                        tmp = new NotifItems();
                        tmp.Name = ITimer.PanoptaList.outage_list[i].server_name;
                        tmp.index = i;
                        tmp.Description = string.Format("{0} ({1}) is {2} for an {3}", ITimer.PanoptaList.outage_list[i].server_name, ITimer.PanoptaList.outage_list[i].server_fqdn, ITimer.PanoptaList.outage_list[i].status, ITimer.PanoptaList.outage_list[i].type);
                        tmp.LastDisplay = DateTime.Now;
                        tmp.SuppressMessage = false;
                        nList.Add(tmp);
                    }

                    lViewItem = new ListViewItem(ITimer.PanoptaList.outage_list[i].server_name.Trim());
                    lViewSubItem = new ListViewItem.ListViewSubItem(lViewItem, "Panopta".Trim());
                    lViewItem.SubItems.Add(lViewSubItem);
                    lvServers.Invoke(new MethodInvoker(delegate {
                        lvServers.Items.Add(lViewItem);
                    }));

                    Log.Add("frmMain", "UpdatePanopta", "Updated server list.");
                }
            }
        }

        bool ServerExists(string Server) {
            int index = FindItemIndex(Server);

            Log.Add("frmMain", "ServerExists", "Found server index {0}", index);

            if (index >= 0)
                return true;
            else
                return false;

        }
        private void lvServers_SelectedIndexChanged(object sender, EventArgs e) {
            int index = FindItemIndex(lvServers.FocusedItem.Text);

            Log.Add("frmMain", "lvServers_SelectedIndexChanged", "Modifying properties of '{0}'", lvServers.FocusedItem.Text);
            LoadLabels(ITimer.FindPanoptaIndex(lvServers.FocusedItem.Text));

            if (index < nList.Count && index >= 0) {
                if (nList[index].SuppressMessage) {
                    Log.Add("frmMain", "lvServers_SelectedIndexChanged", "Alert suppressed for 5 minutes for index {0}", index);
                    cmdSuppress.Text = "Show Alert";
                } else {
                    Log.Add("frmMain", "lvServers_SelectedIndexChanged", "Alert is no longer suppressed for index {0}", index);
                    cmdSuppress.Text = "Hide Alert";
                }
            }

        }

        void Suppress(int index, bool IsSuppressed) {
            Log.Add("frmMain", "Suppress", "Updating index {0}, suppressing: {1}", index, IsSuppressed);
            UpdateList(index, IsSuppressed);
        }

        void LoadLabels(int index) {
            lblName.Text = ITimer.PanoptaList.outage_list[index].server_name;
            lblHostname.Text = ITimer.PanoptaList.outage_list[index].server_fqdn + "   ";
            lblStartTime.Text = CleanupDate(ITimer.PanoptaList.outage_list[index].start_time);
            lblLastUpdate.Text = UppercaseFirst(ITimer.PanoptaList.outage_list[index].status);
            lblAlertType.Text = UppercaseFirst(ITimer.PanoptaList.outage_list[index].type);
            if (lvServers.FocusedItem != null)
                lblReportedBy.Text = lvServers.FocusedItem.SubItems[1].Text;
            else
                lblReportedBy.Text = "Panopta";
            lblURL.Text = ITimer.PanoptaList.outage_list[index].server;
            lblTotalTime.Text = DateDiff(ITimer.PanoptaList.outage_list[index].start_time);

            Log.Add("frmMain", "LoadLabels", "Updated label for index {0}", index);
        }

        string CleanupDate(string Text) {
            DateTime t = Convert.ToDateTime(Text);

            return string.Format("{0:F}", t);
        }

        string DateDiff(string StartDate) {
            DateTime start = DateTime.Now;
            TimeSpan result = start.Subtract(Convert.ToDateTime(StartDate));

            return string.Format("{0} days(s) {1} hour(s) {2} minute(s)", Math.Round(result.TotalDays), result.Hours, result.Minutes, result.Seconds);
        }

        int DateDiff(DateTime Start, DateTime End) {
            TimeSpan r = End.Subtract(Start);

            return r.Minutes;
        }

        string UppercaseFirst(string s) {
            if (string.IsNullOrEmpty(s)) {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        void RunPanopta() {
            ITimer.RunPanopta(lvServers);

            if (lvServers.Items.Count.Equals(0)) {
                pDetails.Visible = false;
                pNoAlarms.Visible = true;
            } else {
                pDetails.Visible = true;
                pNoAlarms.Visible = false;
                LoadLabels(0);
            }

        }

        public void UpdateStatus(string Text) {
            lblStatus.Text = Text;
        }
        #endregion

        #region Menus/Form
        private void frmMain_Resize(object sender, EventArgs e) {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void nSystem_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateStatus("Retrieving information...");
            RunPanopta();
            UpdateStatus("Alerts updated.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            frmOptions fOptions = new frmOptions();
            fOptions.MainForm = this;
            fOptions.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayNotificationToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAlert fAlert = new frmAlert();
            fAlert.Show();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debugLogToolStripMenuItem_Click(object sender, EventArgs e) {
            frmDebug fDebug = new frmDebug();
            fDebug.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAbout fAbout = new frmAbout();
            fAbout.Show();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e) {
            frmUpdate fUpdate = new frmUpdate();
            fUpdate.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowWelcome() {
            frmWelcome fWelcome = new frmWelcome();
            fWelcome.ShowDialog();
        }

        #endregion

        #region Notification
        public void DisplayBubble() {
            string AlertMsg = null;
            int Interval = 1;
            nSystem.Text = string.Format("There are {0} active alert(s)", nList.Count);

            // Setup the amount of times we need to update, never allows 0 to be set.
            if (Properties.Settings.Default.AlertInterval == 0)
                Interval = 1;
            else
                Interval = Properties.Settings.Default.AlertInterval;

            if (nList.Count == 0)
                return;

            for (int i = 0; i < nList.Count; i++) {
                if (!nList[i].SuppressMessage) { // Are we suppressed?
                    if (DateDiff(DateTime.Now.AddMinutes(-5), nList[i].LastDisplay) > Interval)
                        AlertMsg = AlertMsg + nList[i].Description + "\n";

                } else // If we are suppressed, check if 5 minutes passed - and display again.
                    if (DateDiff(DateTime.Now, nList[i].SuppressTime) > 5)
                        if (DateDiff(DateTime.Now, nList[i].LastDisplay) > Interval)
                            AlertMsg = AlertMsg + nList[i].Description + "\n";


            }

            if (AlertMsg != null)
                nSystem.ShowBalloonTip(5000, "Outage(s) confirmed", AlertMsg, ToolTipIcon.None);
        }
        #endregion

        #region Other

        private void TInterfaceCheck_Tick(object sender, EventArgs e) {
            if (lvServers.Items.Count == 0) {
                pDetails.Visible = false;
                pNoAlarms.Visible = true;
                cmdSuppress.Enabled = false;
            } else
                cmdSuppress.Enabled = true;
        }


        public void UpdateTasks() {
            ITimer.ClearTasks();

            nSystem.Visible = true;
            if (Properties.Settings.Default.CheckUpdates)
                ITimer.AddTask("AutoUpdater", Core.ITimerHandler.TaskRunTypes.UpdateCheck, 0, 2, 0, null, null, Core.ITimerHandler.ControlType.Label, Core.ITimerHandler.ControlType.Label);

            if (Properties.Settings.Default.PanoptaInterval > 0)
                ITimer.AddTask("Panopta", Core.ITimerHandler.TaskRunTypes.Panopta, Properties.Settings.Default.PanoptaInterval, 0, 0, lvServers, null, Core.ITimerHandler.ControlType.ListView, Core.ITimerHandler.ControlType.Label);
            else
                ITimer.AddTask("Panopta", Core.ITimerHandler.TaskRunTypes.Panopta, 1, 0, 0, lvServers, null, Core.ITimerHandler.ControlType.ListView, Core.ITimerHandler.ControlType.Label);

            if (Properties.Settings.Default.AlertInterval > 0)
                ITimer.AddTask("Notification", ITimerHandler.TaskRunTypes.DisplayBubble, Properties.Settings.Default.AlertInterval, 0, 0, null, null, ITimerHandler.ControlType.Label, ITimerHandler.ControlType.Label);
            else
                ITimer.AddTask("Notification", ITimerHandler.TaskRunTypes.DisplayBubble, 2, 0, 0, null, null, ITimerHandler.ControlType.Label, ITimerHandler.ControlType.Label);

            Log.Add("frmMain", "UpdateTasks", "Setup task {0} to run every {1} hour(s)", "UpdateCheck", "2");
            Log.Add("frmMain", "UpdateTasks", "Setup task {0} to run every {1} minute(s)", "Panopta", Properties.Settings.Default.PanoptaInterval);
            Log.Add("frmMain", "UpdateTasks", "Setup task {0} to run every {1} minute(s)", "Notifications", Properties.Settings.Default.AlertInterval);


            RunPanopta();


            Log.Add("frmMain", "UpdateTasks", "Tasks have been added/updated");
        }

        private void lblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(lblURL.Text.ToString());
        }
        #endregion

        #region List Management
        /// <summary>
        /// Updates the notification items. 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="Suppress"></param>
        public void UpdateList(int index, bool Suppress) {
            NotifItems tmp = new NotifItems();
            tmp = nList[index];
            tmp.LastDisplay = DateTime.Now;
            tmp.SuppressMessage = Suppress;
            tmp.SuppressTime = DateTime.Now;

            nList.RemoveAt(index);
            nList.Add(tmp);
        }

        int FindItemIndex(string Name) {
            int index = -1;

            if (Name == null)
                return (-1);
        
            if (nList.Count > 0)
                index = nList.FindIndex(delegate(NotifItems t) { return t.Name.ToLower().Equals(Name.ToLower()); });
            else
                index = -1;

            return index;
        }

        private void cmdSuppress_Click(object sender, EventArgs e) {
            string UpdateItem = null; 
            bool bShow = false;
            int index = -1;

            if (lvServers.FocusedItem == null)
                return;

            UpdateItem = lvServers.FocusedItem.Text;
            index = FindItemIndex(UpdateItem);
            if (cmdSuppress.Text.Equals("Hide Alert")) {
                bShow = true;
                cmdSuppress.Text = "Show Alert";
            } else {
                bShow = false;
                cmdSuppress.Text = "Hide Alert";
            }

            if (index >= 0)
                Suppress(index, bShow);

        }
        #endregion

        private void displayAlertToolStripMenuItem_Click(object sender, EventArgs e) {
            DisplayBubble();
        }



    }


    class NotifItems {
        public string Name;
        public int index;
        public string Description;
        public bool SuppressMessage;
        public DateTime LastDisplay;
        public DateTime SuppressTime;
    }
}
