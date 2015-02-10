namespace Panappta {
    partial class frmUpdate {
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.rtfUpdate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(437, 245);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(77, 27);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(354, 245);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(77, 27);
            this.cmdCheck.TabIndex = 1;
            this.cmdCheck.Text = "Check Now";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "                   ";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(1, 126);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(64, 15);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "                   ";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(267, 245);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(81, 27);
            this.cmdUpdate.TabIndex = 5;
            this.cmdUpdate.Text = "Update Now";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // rtfUpdate
            // 
            this.rtfUpdate.Location = new System.Drawing.Point(4, 3);
            this.rtfUpdate.Name = "rtfUpdate";
            this.rtfUpdate.Size = new System.Drawing.Size(510, 236);
            this.rtfUpdate.TabIndex = 6;
            this.rtfUpdate.Text = "";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 276);
            this.ControlBox = false;
            this.Controls.Add(this.rtfUpdate);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.cmdOK);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUpdate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updates";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.RichTextBox rtfUpdate;
    }
}