namespace GDriveNotifier
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.lvwChanges = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuListOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListExcudeDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListMe = new System.Windows.Forms.ToolStripMenuItem();
            this.nfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTaskBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.indefinitelyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocExclusions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mnuList.SuspendLayout();
            this.mnuTaskBar.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 1000;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // lvwChanges
            // 
            this.lvwChanges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colFile,
            this.colWho});
            this.lvwChanges.ContextMenuStrip = this.mnuList;
            this.lvwChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwChanges.FullRowSelect = true;
            this.lvwChanges.HideSelection = false;
            this.lvwChanges.Location = new System.Drawing.Point(0, 0);
            this.lvwChanges.Name = "lvwChanges";
            this.lvwChanges.Size = new System.Drawing.Size(800, 426);
            this.lvwChanges.TabIndex = 0;
            this.lvwChanges.UseCompatibleStateImageBehavior = false;
            this.lvwChanges.View = System.Windows.Forms.View.Details;
            this.lvwChanges.SelectedIndexChanged += new System.EventHandler(this.lvwChanges_SelectedIndexChanged);
            this.lvwChanges.DoubleClick += new System.EventHandler(this.lvwChanges_DoubleClick);
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 120;
            // 
            // colFile
            // 
            this.colFile.Text = "File Name";
            this.colFile.Width = 200;
            // 
            // colWho
            // 
            this.colWho.Text = "User";
            this.colWho.Width = 120;
            // 
            // mnuList
            // 
            this.mnuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListOpen,
            this.mnuListExcudeDoc,
            this.mnuListMe});
            this.mnuList.Name = "mnuList";
            this.mnuList.ShowImageMargin = false;
            this.mnuList.Size = new System.Drawing.Size(150, 70);
            // 
            // mnuListOpen
            // 
            this.mnuListOpen.Name = "mnuListOpen";
            this.mnuListOpen.Size = new System.Drawing.Size(149, 22);
            this.mnuListOpen.Text = "&Open Document";
            this.mnuListOpen.Click += new System.EventHandler(this.mnuListOpen_Click);
            // 
            // mnuListExcudeDoc
            // 
            this.mnuListExcudeDoc.Name = "mnuListExcudeDoc";
            this.mnuListExcudeDoc.Size = new System.Drawing.Size(149, 22);
            this.mnuListExcudeDoc.Text = "Exclude Document";
            this.mnuListExcudeDoc.Click += new System.EventHandler(this.mnuListExcudeDoc_Click);
            // 
            // mnuListMe
            // 
            this.mnuListMe.Name = "mnuListMe";
            this.mnuListMe.Size = new System.Drawing.Size(149, 22);
            this.mnuListMe.Text = "This is &Me";
            this.mnuListMe.Click += new System.EventHandler(this.mnuListMe_Click);
            // 
            // nfyIcon
            // 
            this.nfyIcon.ContextMenuStrip = this.mnuTaskBar;
            this.nfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyIcon.Icon")));
            this.nfyIcon.Text = "GDrive Notifier";
            this.nfyIcon.Visible = true;
            this.nfyIcon.Click += new System.EventHandler(this.nfyIcon_Click);
            this.nfyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfyIcon_MouseDoubleClick);
            // 
            // mnuTaskBar
            // 
            this.mnuTaskBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEventsToolStripMenuItem,
            this.pauseNotificationsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuTaskBar.Name = "mnuTaskBar";
            this.mnuTaskBar.Size = new System.Drawing.Size(181, 126);
            // 
            // showEventsToolStripMenuItem
            // 
            this.showEventsToolStripMenuItem.Name = "showEventsToolStripMenuItem";
            this.showEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showEventsToolStripMenuItem.Text = "&Show Events";
            this.showEventsToolStripMenuItem.Click += new System.EventHandler(this.showEventsToolStripMenuItem_Click);
            // 
            // pauseNotificationsToolStripMenuItem
            // 
            this.pauseNotificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unpauseToolStripMenuItem,
            this.minutesToolStripMenuItem,
            this.minutesToolStripMenuItem1,
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3,
            this.hourToolStripMenuItem,
            this.hoursToolStripMenuItem,
            this.hoursToolStripMenuItem1,
            this.indefinitelyToolStripMenuItem});
            this.pauseNotificationsToolStripMenuItem.Name = "pauseNotificationsToolStripMenuItem";
            this.pauseNotificationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseNotificationsToolStripMenuItem.Text = "&Pause Notifications";
            // 
            // minutesToolStripMenuItem
            // 
            this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
            this.minutesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minutesToolStripMenuItem.Text = "5 minutes";
            this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
            // 
            // minutesToolStripMenuItem1
            // 
            this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
            this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.minutesToolStripMenuItem1.Text = "10 minutes";
            this.minutesToolStripMenuItem1.Click += new System.EventHandler(this.minutesToolStripMenuItem1_Click);
            // 
            // minutesToolStripMenuItem2
            // 
            this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
            this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.minutesToolStripMenuItem2.Text = "15 minutes";
            this.minutesToolStripMenuItem2.Click += new System.EventHandler(this.minutesToolStripMenuItem2_Click);
            // 
            // minutesToolStripMenuItem3
            // 
            this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
            this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.minutesToolStripMenuItem3.Text = "30 minutes";
            this.minutesToolStripMenuItem3.Click += new System.EventHandler(this.minutesToolStripMenuItem3_Click);
            // 
            // hourToolStripMenuItem
            // 
            this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            this.hourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hourToolStripMenuItem.Text = "1 hour";
            this.hourToolStripMenuItem.Click += new System.EventHandler(this.hourToolStripMenuItem_Click);
            // 
            // hoursToolStripMenuItem
            // 
            this.hoursToolStripMenuItem.Name = "hoursToolStripMenuItem";
            this.hoursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hoursToolStripMenuItem.Text = "12 hours";
            this.hoursToolStripMenuItem.Click += new System.EventHandler(this.hoursToolStripMenuItem_Click);
            // 
            // hoursToolStripMenuItem1
            // 
            this.hoursToolStripMenuItem1.Name = "hoursToolStripMenuItem1";
            this.hoursToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hoursToolStripMenuItem1.Text = "24 hours";
            this.hoursToolStripMenuItem1.Click += new System.EventHandler(this.hoursToolStripMenuItem1_Click);
            // 
            // indefinitelyToolStripMenuItem
            // 
            this.indefinitelyToolStripMenuItem.Name = "indefinitelyToolStripMenuItem";
            this.indefinitelyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indefinitelyToolStripMenuItem.Text = "Indefinitely";
            this.indefinitelyToolStripMenuItem.Click += new System.EventHandler(this.indefinitelyToolStripMenuItem_Click);
            // 
            // unpauseToolStripMenuItem
            // 
            this.unpauseToolStripMenuItem.Name = "unpauseToolStripMenuItem";
            this.unpauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unpauseToolStripMenuItem.Text = "Unpause";
            this.unpauseToolStripMenuItem.Visible = false;
            this.unpauseToolStripMenuItem.Click += new System.EventHandler(this.unpauseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "S&ettings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.documentsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainSettings,
            this.mnuMainExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuMainSettings
            // 
            this.mnuMainSettings.Name = "mnuMainSettings";
            this.mnuMainSettings.Size = new System.Drawing.Size(180, 22);
            this.mnuMainSettings.Text = "&Settings";
            this.mnuMainSettings.Click += new System.EventHandler(this.mnuMainSettings_Click);
            // 
            // mnuMainExit
            // 
            this.mnuMainExit.Name = "mnuMainExit";
            this.mnuMainExit.Size = new System.Drawing.Size(180, 22);
            this.mnuMainExit.Text = "E&xit";
            this.mnuMainExit.Click += new System.EventHandler(this.mnuMainExit_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDocRefresh,
            this.mnuDocExclusions});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "&Documents";
            // 
            // mnuDocRefresh
            // 
            this.mnuDocRefresh.Name = "mnuDocRefresh";
            this.mnuDocRefresh.Size = new System.Drawing.Size(141, 22);
            this.mnuDocRefresh.Text = "&Refresh Now";
            this.mnuDocRefresh.Click += new System.EventHandler(this.mnuDocRefresh_Click);
            // 
            // mnuDocExclusions
            // 
            this.mnuDocExclusions.Name = "mnuDocExclusions";
            this.mnuDocExclusions.Size = new System.Drawing.Size(141, 22);
            this.mnuDocExclusions.Text = "E&xclusions";
            this.mnuDocExclusions.Click += new System.EventHandler(this.mnuDocExclusions_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lvwChanges);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 426);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mnuMain);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "GDrive Notifier";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mnuList.ResumeLayout(false);
            this.mnuTaskBar.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.ListView lvwChanges;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colWho;
        private System.Windows.Forms.NotifyIcon nfyIcon;
        private System.Windows.Forms.ContextMenuStrip mnuTaskBar;
        private System.Windows.Forms.ToolStripMenuItem showEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuListExcudeDoc;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMainExit;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDocRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuDocExclusions;
        private System.Windows.Forms.ToolStripMenuItem mnuListOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuListMe;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuMainSettings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem pauseNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indefinitelyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpauseToolStripMenuItem;
    }
}

