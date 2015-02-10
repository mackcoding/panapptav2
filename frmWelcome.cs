using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panappta {
    public partial class frmWelcome : Form {
        public frmWelcome() {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e) {
            try {
                rtfUpdate.Text = new System.Net.WebClient().DownloadString("http://panappta.mackcoding.com/welcome.txt");
            } catch (Exception err) {
                rtfUpdate.Text = "An error occurred trying to download the change log.\n" + err.Message;
            }
        }

        private void cmdOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
