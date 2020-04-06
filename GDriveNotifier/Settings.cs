using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDriveNotifier
{
   public partial class Settings : Form
   {
      public Settings()
      {
         InitializeComponent();
      }

      private void nudCheckMins_ValueChanged(object sender, EventArgs e)
      {
         Properties.Settings.Default.CheckSeconds = (int)nudCheckMins.Value * 60;
      }

      private void txtName_TextChanged(object sender, EventArgs e)
      {
         Properties.Settings.Default.MyName = txtName.Text;
      }

      private void chkWindowNote_CheckedChanged(object sender, EventArgs e)
      {
         Properties.Settings.Default.WindowsNotifications = chkWindowNote.Checked;
         nudWindowsNoteSecs.Enabled = chkWindowNote.Checked;
         lblWindowsNoteSecs.Enabled = chkWindowNote.Checked;

      }

      private void chkFilesFromTaskbar_CheckedChanged(object sender, EventArgs e)
      {
         Properties.Settings.Default.AddFilesToTaskbar = chkFilesFromTaskbar.Checked;
      }
      private void nudWindowsNoteSecs_ValueChanged(object sender, EventArgs e)
      {
         Properties.Settings.Default.WindowsNotificationsSeconds = (int)nudWindowsNoteSecs.Value *1000;
      }

      private void Settings_Load(object sender, EventArgs e)
      {
         nudCheckMins.Value = Properties.Settings.Default.CheckSeconds / 60;
         txtName.Text = Properties.Settings.Default.MyName;
         chkWindowNote.Checked = Properties.Settings.Default.WindowsNotifications;
         chkFilesFromTaskbar.Checked = Properties.Settings.Default.AddFilesToTaskbar;
         nudWindowsNoteSecs.Value = Properties.Settings.Default.WindowsNotificationsSeconds/1000;
      }

      private void Settings_FormClosing(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default.Save();
      }
   }
}
