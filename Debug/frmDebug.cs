using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Panappta.Debug;

namespace Panappta.Debug {
    public partial class frmDebug : Form {
        BackgroundWorker bWorker = new BackgroundWorker();
        Timer t = new Timer();
        public frmDebug() {
            InitializeComponent();

        }

        private void frmDebug_Load(object sender, EventArgs e) {
     
            t.Interval = 1000;
            t.Enabled = true;
            t.Start();
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e) {
            string ConsoleLog = Log.ReturnLog;
            //if (rtfLog.Text != Log.ReturnLog && rtfLog.Text != null)
            if (!string.IsNullOrEmpty(ConsoleLog))
                if (string.IsNullOrEmpty(rtfLog.Text))
                    rtfLog.Text = string.Format("{0}", ConsoleLog, rtfLog.Text);
                else
                    rtfLog.Text = string.Format("{1}\n{0}", ConsoleLog, rtfLog.Text);

            rtfLog.SelectionStart = rtfLog.Text.Length;
            rtfLog.ScrollToCaret();
        }

        void bWorker_DoWork(object sender, DoWorkEventArgs e) {
            IAsyncResult result = rtfLog.BeginInvoke(new Action(() => {
                if (rtfLog.Text != Log.ReturnLog && rtfLog.Text.Length > 0)
                    rtfLog.Text += Log.ReturnLog;
            }));
            rtfLog.EndInvoke(result);
        }

        delegate void UpdateConsoleDelegate();

        public void UpdateConsole() {
            if (rtfLog.InvokeRequired)
                if (rtfLog.Text != Log.ReturnLog)
                    rtfLog.Text = Log.ReturnLog;
                else
                    rtfLog.Text = Log.ReturnLog;

        }

        private void frmDebug_FormClosing(object sender, FormClosingEventArgs e) {
            t.Stop();
            t.Dispose();
        }

        private void txtConsole_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessCommand();
            }
        }

        void ProcessCommand() {
            string cmd = txtConsole.Text.ToLower().Trim();
            txtConsole.Text = String.Empty;


            switch (cmd) {
                case "clear":
                    rtfLog.Clear();
                    Log.Add("frmDebug", "ProcessCommand", "Log cleared.");
                    break;
                case "error":
                    try {
                        int i = 5;
                        int c = 0;
                        int b = i / c;
                    } catch (Exception e) {
                        ErrorReport eReport = new ErrorReport("frmDebug", "ProcessCommand", "Exception occurred.", e);
                    }

                    Log.Add("frmDebug", "ProcessCommand", "Exception generated.");
                    break;

                case "help":
                    Log.Add("Commands:\nclear - Clears the console\nerror - Generates an exception"
                    , Log.Priority.Important);
                    break;
            }
        }
    }
}
