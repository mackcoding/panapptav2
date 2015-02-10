namespace Panappta {
    partial class frmOptions {
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWindows = new System.Windows.Forms.CheckBox();
            this.chkUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUpdatePanopta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPanoptaEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nUpdateUptime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUptimeEnable = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nIntervalNotif = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdatePanopta)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdateUptime)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIntervalNotif)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(160, 188);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(73, 27);
            this.cmdOK.TabIndex = 8;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(234, 188);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(73, 27);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWindows);
            this.groupBox1.Controls.Add(this.chkUpdates);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Startup Settings";
            // 
            // chkWindows
            // 
            this.chkWindows.AutoSize = true;
            this.chkWindows.Location = new System.Drawing.Point(132, 22);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(126, 19);
            this.chkWindows.TabIndex = 2;
            this.chkWindows.Text = "Start with Windows";
            this.chkWindows.UseVisualStyleBackColor = true;
            // 
            // chkUpdates
            // 
            this.chkUpdates.AutoSize = true;
            this.chkUpdates.Location = new System.Drawing.Point(6, 22);
            this.chkUpdates.Name = "chkUpdates";
            this.chkUpdates.Size = new System.Drawing.Size(120, 19);
            this.chkUpdates.TabIndex = 1;
            this.chkUpdates.Text = "Check for updates";
            this.chkUpdates.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nUpdatePanopta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkPanoptaEnabled);
            this.groupBox2.Location = new System.Drawing.Point(7, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panopta";
            // 
            // nUpdatePanopta
            // 
            this.nUpdatePanopta.Location = new System.Drawing.Point(6, 53);
            this.nUpdatePanopta.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpdatePanopta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpdatePanopta.Name = "nUpdatePanopta";
            this.nUpdatePanopta.Size = new System.Drawing.Size(52, 23);
            this.nUpdatePanopta.TabIndex = 4;
            this.nUpdatePanopta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Interval (minutes)";
            // 
            // chkPanoptaEnabled
            // 
            this.chkPanoptaEnabled.AutoSize = true;
            this.chkPanoptaEnabled.Checked = true;
            this.chkPanoptaEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPanoptaEnabled.Enabled = false;
            this.chkPanoptaEnabled.Location = new System.Drawing.Point(5, 18);
            this.chkPanoptaEnabled.Name = "chkPanoptaEnabled";
            this.chkPanoptaEnabled.Size = new System.Drawing.Size(68, 19);
            this.chkPanoptaEnabled.TabIndex = 3;
            this.chkPanoptaEnabled.Text = "Enabled";
            this.chkPanoptaEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nUpdateUptime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chkUptimeEnable);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(160, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 83);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uptime Robot";
            // 
            // nUpdateUptime
            // 
            this.nUpdateUptime.Location = new System.Drawing.Point(6, 53);
            this.nUpdateUptime.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpdateUptime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpdateUptime.Name = "nUpdateUptime";
            this.nUpdateUptime.Size = new System.Drawing.Size(52, 23);
            this.nUpdateUptime.TabIndex = 6;
            this.nUpdateUptime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Interval (minutes)";
            // 
            // chkUptimeEnable
            // 
            this.chkUptimeEnable.AutoSize = true;
            this.chkUptimeEnable.Checked = true;
            this.chkUptimeEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUptimeEnable.Location = new System.Drawing.Point(5, 18);
            this.chkUptimeEnable.Name = "chkUptimeEnable";
            this.chkUptimeEnable.Size = new System.Drawing.Size(68, 19);
            this.chkUptimeEnable.TabIndex = 5;
            this.chkUptimeEnable.Text = "Enabled";
            this.chkUptimeEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nIntervalNotif);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(7, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 68);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notifications";
            // 
            // nIntervalNotif
            // 
            this.nIntervalNotif.Location = new System.Drawing.Point(8, 37);
            this.nIntervalNotif.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nIntervalNotif.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIntervalNotif.Name = "nIntervalNotif";
            this.nIntervalNotif.Size = new System.Drawing.Size(52, 23);
            this.nIntervalNotif.TabIndex = 7;
            this.nIntervalNotif.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display Interval";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 219);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdatePanopta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpdateUptime)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIntervalNotif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkWindows;
        private System.Windows.Forms.CheckBox chkUpdates;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPanoptaEnabled;
        private System.Windows.Forms.NumericUpDown nUpdatePanopta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nUpdateUptime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUptimeEnable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nIntervalNotif;
        private System.Windows.Forms.Label label3;
    }
}