using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Panappta.Core;

using System.Windows.Forms;

namespace Panappta {
    public partial class frmUpdate : Form {
        UpdateHandler uHandler = new UpdateHandler();
        public frmUpdate() {
            InitializeComponent();
            cmdUpdate.Visible = false;
        }

        private void frmUpdate_Load(object sender, EventArgs e) {
            lblCurrent.Text = "Panappta version " + ProductVersion;

            //uHandler.Generate();


            CheckNow();

         //   if (uHandler.UpdateAvailable)
         //       lblStatus.Text = string.Format("A new Panappta version {0} has been released on {2}.\n{1}", uHandler.Version, uHandler.Description, uHandler.ReleaseDate);
         //   else
         //       lblStatus.Text = "No updates are available.";
        }

        private void cmdOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmdCheck_Click(object sender, EventArgs e) {
            CheckNow();
        }

        void CheckNow() {
            cmdCheck.Enabled = false;
            if (uHandler.CheckForUpdates())
                lblStatus.Text = "An error has occurred while checking for updates. Please try again later.";
            else {
                if (uHandler.UpdateAvailable) {
                    lblStatus.Text = "An update is available!";
                    
                    //rtfUpdate.Text = uHandler.Description;
                    rtfUpdate.Text = string.Format("A new update is available for Panappta!\nVersion: {0}\nReleased on: {1}\n{2}", uHandler.Version,
                        uHandler.ReleaseDate, uHandler.Description);

                    /*rtfUpdate.Text = string.Format("A new version of Panappta {0} \"{1}\" is available.\n" +
                        "The new version of Panappta released on {2}.\n{4}",
                        uHandler.Version,
                        uHandler.ReleaseType,
                        uHandler.ReleaseDate,
                        ProductVersion,
                        uHandler.Description);*/
                    cmdUpdate.Visible = true;

                    
                } else
                    rtfUpdate.Text = "Sorry, there are no updates for Panappta currently.";
            }
            cmdCheck.Enabled = true;

        }


        private void cmdUpdate_Click(object sender, EventArgs e) {
            uHandler.DownloadUpdate();
            System.Diagnostics.Process.Start("panappta_update.exe", "start");
            Environment.Exit(0);
        }
    }
}
