namespace Panappta {
    partial class frmAbout {
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.rtfAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(305, 309);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "Close";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // rtfAbout
            // 
            this.rtfAbout.BackColor = System.Drawing.Color.White;
            this.rtfAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtfAbout.Location = new System.Drawing.Point(0, 0);
            this.rtfAbout.Name = "rtfAbout";
            this.rtfAbout.Size = new System.Drawing.Size(385, 303);
            this.rtfAbout.TabIndex = 1;
            this.rtfAbout.Text = "";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 336);
            this.ControlBox = false;
            this.Controls.Add(this.rtfAbout);
            this.Controls.Add(this.cmdOK);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Panappta";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.RichTextBox rtfAbout;
    }
}