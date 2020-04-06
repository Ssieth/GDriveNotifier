namespace GDriveNotifier
{
   partial class Excludes
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excludes));
         this.lvwChanges = new System.Windows.Forms.ListView();
         this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colWho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // lvwChanges
         // 
         this.lvwChanges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colFile,
            this.colWho});
         this.lvwChanges.ContextMenuStrip = this.contextMenuStrip1;
         this.lvwChanges.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lvwChanges.FullRowSelect = true;
         this.lvwChanges.HideSelection = false;
         this.lvwChanges.Location = new System.Drawing.Point(0, 0);
         this.lvwChanges.Name = "lvwChanges";
         this.lvwChanges.Size = new System.Drawing.Size(800, 450);
         this.lvwChanges.TabIndex = 1;
         this.lvwChanges.UseCompatibleStateImageBehavior = false;
         this.lvwChanges.View = System.Windows.Forms.View.Details;
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
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemove});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
         // 
         // mnuRemove
         // 
         this.mnuRemove.Name = "mnuRemove";
         this.mnuRemove.Size = new System.Drawing.Size(170, 22);
         this.mnuRemove.Text = "Remove Exclusion";
         this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
         // 
         // Excludes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lvwChanges);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Excludes";
         this.Text = "Excluded Files";
         this.Load += new System.EventHandler(this.Excludes_Load);
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.ListView lvwChanges;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colWho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
    }
}