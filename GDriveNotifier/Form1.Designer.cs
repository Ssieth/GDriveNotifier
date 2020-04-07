﻿namespace GDriveNotifier
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
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuMain = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuMainExit = new System.Windows.Forms.ToolStripMenuItem();
         this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuDocRefresh = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuDocExclusions = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuMainSettings = new System.Windows.Forms.ToolStripMenuItem();
         this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuList.SuspendLayout();
         this.mnuTaskBar.SuspendLayout();
         this.mnuMain.SuspendLayout();
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
         this.lvwChanges.Size = new System.Drawing.Size(800, 450);
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
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.mnuTaskBar.Name = "mnuTaskBar";
         this.mnuTaskBar.Size = new System.Drawing.Size(181, 104);
         // 
         // showEventsToolStripMenuItem
         // 
         this.showEventsToolStripMenuItem.Name = "showEventsToolStripMenuItem";
         this.showEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.showEventsToolStripMenuItem.Text = "&Show Events";
         this.showEventsToolStripMenuItem.Click += new System.EventHandler(this.showEventsToolStripMenuItem_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
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
         // toolStripMenuItem2
         // 
         this.toolStripMenuItem2.Name = "toolStripMenuItem2";
         this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
         // 
         // mnuMainSettings
         // 
         this.mnuMainSettings.Name = "mnuMainSettings";
         this.mnuMainSettings.Size = new System.Drawing.Size(180, 22);
         this.mnuMainSettings.Text = "&Settings";
         this.mnuMainSettings.Click += new System.EventHandler(this.mnuMainSettings_Click);
         // 
         // settingsToolStripMenuItem
         // 
         this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
         this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.settingsToolStripMenuItem.Text = "S&ettings";
         this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.mnuMain);
         this.Controls.Add(this.lvwChanges);
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
         this.ResumeLayout(false);
         this.PerformLayout();

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
    }
}
