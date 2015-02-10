using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panappta {
    public partial class frmOptions : Form {
        public frmOptions() {
            InitializeComponent();
        }

        public frmMain MainForm { set; get; }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e) {
            nIntervalNotif.Value = Properties.Settings.Default.AlertInterval;
            chkUpdates.Checked = Properties.Settings.Default.CheckUpdates;
            chkPanoptaEnabled.Checked = Properties.Settings.Default.PanoptaEnabled;
            nUpdatePanopta.Value = Properties.Settings.Default.PanoptaInterval;
            chkUptimeEnable.Checked = Properties.Settings.Default.UptimeRobotEnabled;
            nUpdateUptime.Value = Properties.Settings.Default.UptimeRobotInterval;
            chkWindows.Checked = Properties.Settings.Default.WindowStartup;

        }

        private void cmdOK_Click(object sender, EventArgs e) {
            Properties.Settings.Default.AlertInterval = (int)nIntervalNotif.Value;
            Properties.Settings.Default.CheckUpdates = chkUpdates.Checked;
            Properties.Settings.Default.PanoptaEnabled = chkPanoptaEnabled.Checked;
            Properties.Settings.Default.PanoptaInterval = (int)nUpdatePanopta.Value;
            Properties.Settings.Default.UptimeRobotEnabled = chkUptimeEnable.Checked;
            Properties.Settings.Default.UptimeRobotInterval = (int)nUpdateUptime.Value;
            Properties.Settings.Default.WindowStartup = chkWindows.Checked;

            MainForm.UpdateTasks();
            this.Close();
        }
    }
}
