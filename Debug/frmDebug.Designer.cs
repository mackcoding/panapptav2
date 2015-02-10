namespace Panappta.Debug {
    partial class frmDebug {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtfLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfLog
            // 
            this.rtfLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtfLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfLog.ForeColor = System.Drawing.Color.White;
            this.rtfLog.Location = new System.Drawing.Point(0, 0);
            this.rtfLog.Name = "rtfLog";
            this.rtfLog.ReadOnly = true;
            this.rtfLog.Size = new System.Drawing.Size(833, 421);
            this.rtfLog.TabIndex = 0;
            this.rtfLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 27);
            this.panel1.TabIndex = 1;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(4, 3);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(826, 20);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsole_KeyDown);
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 448);
            this.Controls.Add(this.rtfLog);
            this.Controls.Add(this.panel1);
            this.Name = "frmDebug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debug Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDebug_FormClosing);
            this.Load += new System.EventHandler(this.frmDebug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConsole;
    }
}