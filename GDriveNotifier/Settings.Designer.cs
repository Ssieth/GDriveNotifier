namespace GDriveNotifier
{
   partial class Settings
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
         this.label1 = new System.Windows.Forms.Label();
         this.nudCheckMins = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.chkWindowNote = new System.Windows.Forms.CheckBox();
         this.lblWindowsNoteSecs = new System.Windows.Forms.Label();
         this.nudWindowsNoteSecs = new System.Windows.Forms.NumericUpDown();
         this.chkFilesFromTaskbar = new System.Windows.Forms.CheckBox();
         this.label5 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.nudCheckMins)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudWindowsNoteSecs)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 19);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(169, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Check every (minutes):";
         // 
         // nudCheckMins
         // 
         this.nudCheckMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.nudCheckMins.Location = new System.Drawing.Point(217, 17);
         this.nudCheckMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
         this.nudCheckMins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nudCheckMins.Name = "nudCheckMins";
         this.nudCheckMins.Size = new System.Drawing.Size(63, 26);
         this.nudCheckMins.TabIndex = 1;
         this.nudCheckMins.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
         this.nudCheckMins.ValueChanged += new System.EventHandler(this.nudCheckMins_ValueChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 57);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(209, 20);
         this.label3.TabIndex = 3;
         this.label3.Text = "Your name on Google Drive:";
         // 
         // txtName
         // 
         this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtName.Location = new System.Drawing.Point(217, 54);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(328, 26);
         this.txtName.TabIndex = 4;
         this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 93);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(220, 20);
         this.label2.TabIndex = 5;
         this.label2.Text = "Trigger windows notifications?";
         // 
         // chkWindowNote
         // 
         this.chkWindowNote.AutoSize = true;
         this.chkWindowNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkWindowNote.Location = new System.Drawing.Point(238, 97);
         this.chkWindowNote.Name = "chkWindowNote";
         this.chkWindowNote.Size = new System.Drawing.Size(15, 14);
         this.chkWindowNote.TabIndex = 6;
         this.chkWindowNote.UseVisualStyleBackColor = true;
         this.chkWindowNote.CheckedChanged += new System.EventHandler(this.chkWindowNote_CheckedChanged);
         // 
         // lblWindowsNoteSecs
         // 
         this.lblWindowsNoteSecs.AutoSize = true;
         this.lblWindowsNoteSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblWindowsNoteSecs.Location = new System.Drawing.Point(301, 93);
         this.lblWindowsNoteSecs.Name = "lblWindowsNoteSecs";
         this.lblWindowsNoteSecs.Size = new System.Drawing.Size(172, 20);
         this.lblWindowsNoteSecs.TabIndex = 7;
         this.lblWindowsNoteSecs.Text = "Display time (seconds):";
         this.lblWindowsNoteSecs.Visible = false;
         // 
         // nudWindowsNoteSecs
         // 
         this.nudWindowsNoteSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.nudWindowsNoteSecs.Location = new System.Drawing.Point(482, 91);
         this.nudWindowsNoteSecs.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
         this.nudWindowsNoteSecs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nudWindowsNoteSecs.Name = "nudWindowsNoteSecs";
         this.nudWindowsNoteSecs.Size = new System.Drawing.Size(63, 26);
         this.nudWindowsNoteSecs.TabIndex = 8;
         this.nudWindowsNoteSecs.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
         this.nudWindowsNoteSecs.Visible = false;
         this.nudWindowsNoteSecs.ValueChanged += new System.EventHandler(this.nudWindowsNoteSecs_ValueChanged);
         // 
         // chkFilesFromTaskbar
         // 
         this.chkFilesFromTaskbar.AutoSize = true;
         this.chkFilesFromTaskbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkFilesFromTaskbar.Location = new System.Drawing.Point(206, 133);
         this.chkFilesFromTaskbar.Name = "chkFilesFromTaskbar";
         this.chkFilesFromTaskbar.Size = new System.Drawing.Size(15, 14);
         this.chkFilesFromTaskbar.TabIndex = 10;
         this.chkFilesFromTaskbar.UseVisualStyleBackColor = true;
         this.chkFilesFromTaskbar.CheckedChanged += new System.EventHandler(this.chkFilesFromTaskbar_CheckedChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(12, 129);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(188, 20);
         this.label5.TabIndex = 9;
         this.label5.Text = "Files from taskbar menu?";
         // 
         // Settings
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(559, 170);
         this.Controls.Add(this.chkFilesFromTaskbar);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.nudWindowsNoteSecs);
         this.Controls.Add(this.lblWindowsNoteSecs);
         this.Controls.Add(this.chkWindowNote);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.nudCheckMins);
         this.Controls.Add(this.label1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Settings";
         this.Text = "Settings";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
         this.Load += new System.EventHandler(this.Settings_Load);
         ((System.ComponentModel.ISupportInitialize)(this.nudCheckMins)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudWindowsNoteSecs)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCheckMins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWindowNote;
        private System.Windows.Forms.Label lblWindowsNoteSecs;
        private System.Windows.Forms.NumericUpDown nudWindowsNoteSecs;
        private System.Windows.Forms.CheckBox chkFilesFromTaskbar;
        private System.Windows.Forms.Label label5;
    }
}