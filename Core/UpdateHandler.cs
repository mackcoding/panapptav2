using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net;

namespace Panappta.Core {
    public class UpdateHandler {
        UpdateSettings uSettings = new UpdateSettings();
        /// <summary>
        /// Lazy function: Use it to generate the new updates file
        /// </summary>
        public void Generate() {
            uSettings.Description = @"Change log 12/5" + Environment.NewLine + "The bug fixes/features are still in testing!" + Environment.NewLine + "-Fixed IP label that was cut off" + Environment.NewLine + "-Added suppress feature, note, this only hides alert for 5 minutes" + Environment.NewLine + "-Fixed MEME not showing up or old alerts not disappearing" + Environment.NewLine + "-Corrected 'Options', this will properly update the internal tasks " + Environment.NewLine + "-Enabled debug console" + Environment.NewLine + "-Fixed link, it now opens a browser. Panopta apparently returns an invalid url, this will be investigated in next version " + Environment.NewLine + "-Cleaned up internal code";
            uSettings.Version = "1.0.0.2";
            uSettings.ReleaseType = UpdateSettings.TypeList.Beta;
            uSettings.ReleaseDate = DateTime.Now;
            

            //uSettings.Description = "New features:" + Environment.NewLine + "- Introduces the automatic update" + Environment.NewLine + "Fixes:" + Environment.NewLine + "-Fixed parsing engine for Panopta" + Environment.NewLine + "-Rebuild entire code base" + Environment.NewLine + "-Others";
            MessageBox.Show(JsonConvert.SerializeObject(uSettings));
        }

        public bool CheckForUpdates() {
            string UpdateData = null;
            bool bError = true;

            try { // Return true if there is an error
                UpdateData = new System.Net.WebClient().DownloadString(@"http://panappta.mackcoding.com/update.txt"); // Download our update file
                uSettings = JsonConvert.DeserializeObject<UpdateSettings>(UpdateData); // Deserialize the update data from the server
                bError = false;
            } catch (Exception) {
                bError = true;
            }

            return bError;
        }

        /// <summary>
        /// Downloads the update file and saves it as "panappta_update.exe"
        /// </summary>
        /// <returns></returns>
        public bool DownloadUpdate() {
            bool bError = false;

            try {
                new System.Net.WebClient().DownloadFile(uSettings.UpdateFileName, @"panappta_update.exe");
            } catch (Exception) {
                bError = true;
            }

            return bError;
        }

        /// <summary>
        /// Returns true/false if there is an update
        /// </summary>
        public bool UpdateAvailable {
            get {
                if (uSettings.Version.Equals(Application.ProductVersion))
                    return false;
                else
                    return true;
            }
        }

        public string Description { get { return uSettings.Description; } }
        public string Version { get { return uSettings.Version; } }
        public DateTime ReleaseDate { get { return uSettings.ReleaseDate; } }
        public string ReleaseType { get { return uSettings.ReleaseType.ToString(); } }
        public string DownloadUrl { get { return uSettings.UpdateFileName; } }
    }

    class UpdateSettings {
        public enum TypeList {
            Final,
            Beta,
            Alpha
        }

        public UpdateSettings() {
            Description = "Alpha release of Panappta.";
            ReleaseDate = DateTime.Now;
            ReleaseType = UpdateSettings.TypeList.Alpha;
            Version = Application.ProductVersion;
            UpdateFileName = "http://panappta.mackcoding.com/downloads/panappta_1005.gz";
        }

        public string Version { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TypeList ReleaseType { get; set; }
        public string UpdateFileName { get; set; }

    }
}
