using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Panappta {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {

            if (args.GetLength(0) > 0)
                ManageUpdater(args[0]);
            else
                Startup(false);

        }

        static void Startup(bool ShowWelcome) {
            if (File.Exists("panappta_update.exe"))
                File.Delete("panappta_update.exe");


            frmMain fMain = new frmMain();
            if (ShowWelcome)
                fMain.ShowWelcome();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        static void ManageUpdater(string Action) {
            switch (Action.ToLower()) {
                case "start":
                    StartUpdate();
                    break;
                case "rename":
                    RenameFile();
                    break;
                case "updated":
                    Startup(true);
                    break;


            }
        }

        /// <summary>
        /// Executes the updated file with the parameter "rename"
        /// </summary>
        static void StartUpdate() {
            if (UpdateExists)
                Process.Start("panappta_update.exe", "rename");
            else
                MessageBox.Show("Unable to perform update. The update file does not exist!", "Error updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Renames the "panappta.exe to panappta_old.exe".
        /// </summary>
        static void RenameFile() {
            // Find the panappta process and keel it.
            Process[] pList = Process.GetProcessesByName("panappta");
            foreach (Process p in pList) {
                p.Kill();
            }


            // System.Threading.Thread.Sleep(5000); // We need to wait for our panappta process to end. 
            File.Delete("panappta.exe"); // Delete our original panappta
            File.Copy("panappta_update.exe", "Panappta.exe"); // Replace old copy with new
            Process.Start("Panappta.exe", "updated"); // Start the application. 
        }
        static bool UpdateExists { get { return File.Exists("panappta_update.exe"); } }
    }
}
