namespace Panappta.Debug {
    partial class frmError {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.cmdContinue = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.rtfError = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSendError = new System.Windows.Forms.CheckBox();
            this.cmdShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdContinue
            // 
            this.cmdContinue.Location = new System.Drawing.Point(402, 123);
            this.cmdContinue.Name = "cmdContinue";
            this.cmdContinue.Size = new System.Drawing.Size(75, 23);
            this.cmdContinue.TabIndex = 3;
            this.cmdContinue.Text = "Continue";
            this.cmdContinue.UseVisualStyleBackColor = true;
            this.cmdContinue.Click += new System.EventHandler(this.cmdContinue_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(321, 123);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(75, 23);
            this.cmdCopy.TabIndex = 2;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 51);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(3, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(213, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "An unrecoverable error has occured.";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(483, 123);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "End Now";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // rtfError
            // 
            this.rtfError.DetectUrls = false;
            this.rtfError.Location = new System.Drawing.Point(7, 152);
            this.rtfError.Name = "rtfError";
            this.rtfError.ReadOnly = true;
            this.rtfError.Size = new System.Drawing.Size(551, 220);
            this.rtfError.TabIndex = 7;
            this.rtfError.Text = "";
            this.rtfError.TextChanged += new System.EventHandler(this.rtfError_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // chkSendError
            // 
            this.chkSendError.AutoSize = true;
            this.chkSendError.Checked = true;
            this.chkSendError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendError.Location = new System.Drawing.Point(12, 127);
            this.chkSendError.Name = "chkSendError";
            this.chkSendError.Size = new System.Drawing.Size(105, 17);
            this.chkSendError.TabIndex = 1;
            this.chkSendError.Text = "Send error report";
            this.chkSendError.UseVisualStyleBackColor = true;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(240, 123);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 5;
            this.cmdShow.Text = "Show Error";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 151);
            this.ControlBox = false;
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.chkSendError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdContinue);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.rtfError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception Occurred";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdContinue;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.RichTextBox rtfError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSendError;
        private System.Windows.Forms.Button cmdShow;

    }
}