namespace Panappta {
    partial class frmWelcome {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtfUpdate = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtfUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 316);
            this.panel1.TabIndex = 0;
            // 
            // rtfUpdate
            // 
            this.rtfUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfUpdate.Location = new System.Drawing.Point(0, 0);
            this.rtfUpdate.Name = "rtfUpdate";
            this.rtfUpdate.Size = new System.Drawing.Size(526, 316);
            this.rtfUpdate.TabIndex = 0;
            this.rtfUpdate.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 36);
            this.panel2.TabIndex = 2;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(444, 7);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 358);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panappta - Change Log";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtfUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdOK;
    }
}