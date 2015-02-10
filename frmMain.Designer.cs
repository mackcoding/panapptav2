namespace Panappta {
    partial class frmMain {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pDetails = new System.Windows.Forms.Panel();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.lblHostname = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.lblAlertType = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pList = new System.Windows.Forms.Panel();
            this.lvServers = new System.Windows.Forms.ListView();
            this.chHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdSuppress = new System.Windows.Forms.Button();
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uptimeRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsePanoptaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseUptimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.debugLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNoAlarms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nSystem = new System.Windows.Forms.NotifyIcon(this.components);
            this.TInterfaceCheck = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.pDetails.SuspendLayout();
            this.pList.SuspendLayout();
            this.mStrip.SuspendLayout();
            this.pNoAlarms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 230);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(692, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Ready.";
            // 
            // pDetails
            // 
            this.pDetails.Controls.Add(this.lblURL);
            this.pDetails.Controls.Add(this.lblHostname);
            this.pDetails.Controls.Add(this.label17);
            this.pDetails.Controls.Add(this.label16);
            this.pDetails.Controls.Add(this.lblReportedBy);
            this.pDetails.Controls.Add(this.lblAlertType);
            this.pDetails.Controls.Add(this.lblTotalTime);
            this.pDetails.Controls.Add(this.label10);
            this.pDetails.Controls.Add(this.label9);
            this.pDetails.Controls.Add(this.label7);
            this.pDetails.Controls.Add(this.lblLastUpdate);
            this.pDetails.Controls.Add(this.lblStartTime);
            this.pDetails.Controls.Add(this.label4);
            this.pDetails.Controls.Add(this.label3);
            this.pDetails.Controls.Add(this.lblName);
            this.pDetails.Controls.Add(this.label1);
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetails.Location = new System.Drawing.Point(237, 24);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(455, 206);
            this.pDetails.TabIndex = 2;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(7, 179);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(73, 15);
            this.lblURL.TabIndex = 19;
            this.lblURL.TabStop = true;
            this.lblURL.Text = "                      ";
            this.lblURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblURL_LinkClicked);
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHostname.Location = new System.Drawing.Point(252, 28);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(91, 15);
            this.lblHostname.TabIndex = 18;
            this.lblHostname.Text = "                            ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(252, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Hostname/IP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label16.Location = new System.Drawing.Point(7, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "Alert Details";
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReportedBy.Location = new System.Drawing.Point(252, 179);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(82, 15);
            this.lblReportedBy.TabIndex = 13;
            this.lblReportedBy.Text = "                         ";
            // 
            // lblAlertType
            // 
            this.lblAlertType.AutoSize = true;
            this.lblAlertType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAlertType.Location = new System.Drawing.Point(7, 134);
            this.lblAlertType.Name = "lblAlertType";
            this.lblAlertType.Size = new System.Drawing.Size(97, 15);
            this.lblAlertType.TabIndex = 12;
            this.lblAlertType.Text = "                              ";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalTime.Location = new System.Drawing.Point(252, 134);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(88, 15);
            this.lblTotalTime.TabIndex = 10;
            this.lblTotalTime.Text = "                           ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(252, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Reported by";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(7, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Type of Alert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(252, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total time alarming";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastUpdate.Location = new System.Drawing.Point(252, 81);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(52, 15);
            this.lblLastUpdate.TabIndex = 5;
            this.lblLastUpdate.Text = "               ";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStartTime.Location = new System.Drawing.Point(7, 81);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(61, 15);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "                  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(252, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alert Started";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(7, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "                ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // pList
            // 
            this.pList.Controls.Add(this.lvServers);
            this.pList.Controls.Add(this.cmdSuppress);
            this.pList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pList.Location = new System.Drawing.Point(0, 24);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(237, 206);
            this.pList.TabIndex = 3;
            // 
            // lvServers
            // 
            this.lvServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHeader,
            this.chAgent});
            this.lvServers.FullRowSelect = true;
            this.lvServers.GridLines = true;
            this.lvServers.Location = new System.Drawing.Point(1, 3);
            this.lvServers.Name = "lvServers";
            this.lvServers.Size = new System.Drawing.Size(233, 177);
            this.lvServers.TabIndex = 4;
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            this.lvServers.SelectedIndexChanged += new System.EventHandler(this.lvServers_SelectedIndexChanged);
            // 
            // chHeader
            // 
            this.chHeader.Text = "Server Name";
            this.chHeader.Width = 155;
            // 
            // chAgent
            // 
            this.chAgent.Text = "Service";
            this.chAgent.Width = 73;
            // 
            // cmdSuppress
            // 
            this.cmdSuppress.Location = new System.Drawing.Point(160, 182);
            this.cmdSuppress.Name = "cmdSuppress";
            this.cmdSuppress.Size = new System.Drawing.Size(75, 23);
            this.cmdSuppress.TabIndex = 3;
            this.cmdSuppress.Text = "Hide Alert";
            this.cmdSuppress.UseVisualStyleBackColor = true;
            this.cmdSuppress.Click += new System.EventHandler(this.cmdSuppress_Click);
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.monitorsToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mStrip.Size = new System.Drawing.Size(692, 24);
            this.mStrip.TabIndex = 4;
            this.mStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // monitorsToolStripMenuItem
            // 
            this.monitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uptimeRobotToolStripMenuItem});
            this.monitorsToolStripMenuItem.Name = "monitorsToolStripMenuItem";
            this.monitorsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.monitorsToolStripMenuItem.Text = "Monitors";
            this.monitorsToolStripMenuItem.Visible = false;
            // 
            // uptimeRobotToolStripMenuItem
            // 
            this.uptimeRobotToolStripMenuItem.Name = "uptimeRobotToolStripMenuItem";
            this.uptimeRobotToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.uptimeRobotToolStripMenuItem.Text = "Uptime Robot";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAlertToolStripMenuItem,
            this.displayNotificationToolStripMenuItem,
            this.parsePanoptaToolStripMenuItem,
            this.parseUptimeToolStripMenuItem,
            this.errorOutToolStripMenuItem,
            this.toolStripMenuItem4,
            this.debugLogToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // displayAlertToolStripMenuItem
            // 
            this.displayAlertToolStripMenuItem.Name = "displayAlertToolStripMenuItem";
            this.displayAlertToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.displayAlertToolStripMenuItem.Text = "Display Alert";
            this.displayAlertToolStripMenuItem.Click += new System.EventHandler(this.displayAlertToolStripMenuItem_Click);
            // 
            // displayNotificationToolStripMenuItem
            // 
            this.displayNotificationToolStripMenuItem.Name = "displayNotificationToolStripMenuItem";
            this.displayNotificationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.displayNotificationToolStripMenuItem.Text = "Display Notification";
            this.displayNotificationToolStripMenuItem.Visible = false;
            this.displayNotificationToolStripMenuItem.Click += new System.EventHandler(this.displayNotificationToolStripMenuItem_Click);
            // 
            // parsePanoptaToolStripMenuItem
            // 
            this.parsePanoptaToolStripMenuItem.Name = "parsePanoptaToolStripMenuItem";
            this.parsePanoptaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.parsePanoptaToolStripMenuItem.Text = "Parse Panopta";
            this.parsePanoptaToolStripMenuItem.Visible = false;
            // 
            // parseUptimeToolStripMenuItem
            // 
            this.parseUptimeToolStripMenuItem.Name = "parseUptimeToolStripMenuItem";
            this.parseUptimeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.parseUptimeToolStripMenuItem.Text = "Parse Uptime";
            this.parseUptimeToolStripMenuItem.Visible = false;
            // 
            // errorOutToolStripMenuItem
            // 
            this.errorOutToolStripMenuItem.Name = "errorOutToolStripMenuItem";
            this.errorOutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.errorOutToolStripMenuItem.Text = "Error Check";
            this.errorOutToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(175, 6);
            this.toolStripMenuItem4.Visible = false;
            // 
            // debugLogToolStripMenuItem
            // 
            this.debugLogToolStripMenuItem.Name = "debugLogToolStripMenuItem";
            this.debugLogToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.debugLogToolStripMenuItem.Text = "Debug Log";
            this.debugLogToolStripMenuItem.Click += new System.EventHandler(this.debugLogToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pNoAlarms
            // 
            this.pNoAlarms.Controls.Add(this.pictureBox1);
            this.pNoAlarms.Location = new System.Drawing.Point(492, 236);
            this.pNoAlarms.Name = "pNoAlarms";
            this.pNoAlarms.Size = new System.Drawing.Size(270, 202);
            this.pNoAlarms.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Panappta.Properties.Resources.noalarms;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nSystem
            // 
            this.nSystem.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nSystem.Icon = ((System.Drawing.Icon)(resources.GetObject("nSystem.Icon")));
            this.nSystem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nSystem_MouseDoubleClick);
            // 
            // TInterfaceCheck
            // 
            this.TInterfaceCheck.Enabled = true;
            this.TInterfaceCheck.Interval = 500;
            this.TInterfaceCheck.Tick += new System.EventHandler(this.TInterfaceCheck_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 252);
            this.Controls.Add(this.pNoAlarms);
            this.Controls.Add(this.pDetails);
            this.Controls.Add(this.pList);
            this.Controls.Add(this.mStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panappta - v1.0.0.2 BETA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            this.pList.ResumeLayout(false);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.pNoAlarms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReportedBy;
        private System.Windows.Forms.Label lblAlertType;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parsePanoptaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseUptimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem debugLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uptimeRobotToolStripMenuItem;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel lblURL;
        private System.Windows.Forms.Panel pNoAlarms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon nSystem;
        private System.Windows.Forms.Timer TInterfaceCheck;
        private System.Windows.Forms.Button cmdSuppress;
        private System.Windows.Forms.ListView lvServers;
        private System.Windows.Forms.ColumnHeader chHeader;
        private System.Windows.Forms.ColumnHeader chAgent;
    }
}

