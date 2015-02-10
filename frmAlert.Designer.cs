namespace Panappta {
    partial class frmAlert {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Parallels Security Exploit",
            "11/21/2013",
            "Thomas Mack",
            "CRITICAL"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "lin-web10 provisioning issues",
            "11/18/2013",
            "Randy Stubbs",
            "Medium"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPostBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pDesc = new System.Windows.Forms.Panel();
            this.rtfNotice = new System.Windows.Forms.RichTextBox();
            this.pFooter = new System.Windows.Forms.Panel();
            this.cmdOK = new System.Windows.Forms.Button();
            this.pText = new System.Windows.Forms.Panel();
            this.pDesc.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.pText.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSubject,
            this.chDate,
            this.chPostBy,
            this.chSeverity});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(787, 143);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chSubject
            // 
            this.chSubject.Text = "Subject";
            this.chSubject.Width = 430;
            // 
            // chDate
            // 
            this.chDate.Text = "Date Posted";
            this.chDate.Width = 120;
            // 
            // chPostBy
            // 
            this.chPostBy.Text = "Posted By";
            this.chPostBy.Width = 130;
            // 
            // chSeverity
            // 
            this.chSeverity.Text = "Severity";
            this.chSeverity.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(672, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Posted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(579, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Severity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(4, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parallels Security Exploit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(579, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "CRITICAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "November 21, 2013";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(458, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Posted By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Thomas Mack";
            // 
            // pDesc
            // 
            this.pDesc.Controls.Add(this.rtfNotice);
            this.pDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDesc.Location = new System.Drawing.Point(0, 192);
            this.pDesc.Name = "pDesc";
            this.pDesc.Size = new System.Drawing.Size(787, 259);
            this.pDesc.TabIndex = 10;
            // 
            // rtfNotice
            // 
            this.rtfNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfNotice.Location = new System.Drawing.Point(0, 0);
            this.rtfNotice.Name = "rtfNotice";
            this.rtfNotice.Size = new System.Drawing.Size(787, 259);
            this.rtfNotice.TabIndex = 11;
            this.rtfNotice.Text = resources.GetString("rtfNotice.Text");
            // 
            // pFooter
            // 
            this.pFooter.Controls.Add(this.cmdOK);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 441);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(787, 37);
            this.pFooter.TabIndex = 11;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(704, 8);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // pText
            // 
            this.pText.Controls.Add(this.label3);
            this.pText.Controls.Add(this.label1);
            this.pText.Controls.Add(this.label2);
            this.pText.Controls.Add(this.label8);
            this.pText.Controls.Add(this.label4);
            this.pText.Controls.Add(this.label7);
            this.pText.Controls.Add(this.label5);
            this.pText.Controls.Add(this.label6);
            this.pText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pText.Location = new System.Drawing.Point(0, 143);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(787, 49);
            this.pText.TabIndex = 12;
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 478);
            this.ControlBox = false;
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pDesc);
            this.Controls.Add(this.pText);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Notifications";
            this.pDesc.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this.pText.ResumeLayout(false);
            this.pText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chSubject;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chPostBy;
        private System.Windows.Forms.ColumnHeader chSeverity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pDesc;
        private System.Windows.Forms.RichTextBox rtfNotice;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Panel pText;
        private System.Windows.Forms.Button cmdOK;
    }
}