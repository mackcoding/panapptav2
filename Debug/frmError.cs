using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Panappta.Debug {
    public partial class frmError : Form {
        public frmError() {
            InitializeComponent();
        }

        public void SetErrorBox(string strMsg) {
            rtfError.Text = strMsg;

        }

        public void SetTopError(string strMsg) {
            string tmp = null, tmp2 = null;

            if (strMsg.Length > 90 && strMsg.Length < 200) {
                tmp = strMsg.Substring(0, strMsg.LastIndexOf(" ", 90)).Trim();
                tmp2 = strMsg.Substring(tmp.Length, strMsg.Length - tmp.Length).Trim();
                strMsg = tmp + Environment.NewLine + tmp2;
            }

            if (strMsg.Length < 200)
                lblMsg.Text = strMsg; 
        }

        public string TrimText(string strText, int MaxLength) {
            string strResult = null;

            if (strText.Length > MaxLength) {
                if (strText.LastIndexOf(".", MaxLength - 1) == 0) {
                    strResult = strText.Substring(0, strText.LastIndexOf(".", MaxLength + 1)) + Environment.NewLine;
                } else {
                    try {
                        strResult = strText.Substring(0, strText.LastIndexOf(".", MaxLength + 1)) +
                            Environment.NewLine;
                    } catch (Exception) {
                        // TODO: FIX 
                        strResult = strText.Substring(0, MaxLength);
                        //  strResult = strText.Substring(0, strText.LastIndexOf(" ", MaxLength + 1)) +
                        //        "&#133;";
                    }
                }
            } else {
                strResult = strText;
            }

            return (strResult);
        }


        private void cmdOK_Click(object sender, EventArgs e) {
            Process.GetCurrentProcess().Kill(); // Terminate this process..
        }

        private void cmdCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(String.Format("Error Occured at {0}\n{1}", DateTime.Now, rtfError.Text));
            cmdCopy.Enabled = false;
        }

        private void cmdContinue_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdReport_Click(object sender, EventArgs e) {
            MessageBox.Show("Oh come on really? This isn't implemented dickhead!");
        }

        private void rtfError_TextChanged(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void lblMsg_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void cmdShow_Click(object sender, EventArgs e) {
            if (cmdShow.Text.Equals("Show Error")) {
                this.Height = 418;
                cmdShow.Text = "Hide Error";
            } else {
                this.Height = 190;
                cmdShow.Text = "Show Error";
            }
        }

        private void frmError_Load(object sender, EventArgs e) {

        }

    }
}
