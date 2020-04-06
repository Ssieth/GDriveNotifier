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
   public partial class Excludes : Form
   {
      public Dictionary<string, FileState> excludedFiles;


      public Excludes(Dictionary<string, FileState> excludes)
      {
         InitializeComponent();
         excludedFiles = excludes;
      }

      private void Excludes_Load(object sender, EventArgs e)
      {
         showFiles();
      }

      public void showFiles()
      {
         lvwChanges.Items.Clear();
         foreach (FileState fileState in excludedFiles.Values.OrderByDescending((fs) => fs.name))
         {
            ListViewItem lvwNew = lvwChanges.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm}", fileState.lastEditWhen));
            lvwNew.Tag = fileState;
            lvwNew.SubItems.Add(fileState.name);
            lvwNew.SubItems.Add(fileState.lastEditBy);
         }
      }

      private void mnuRemove_Click(object sender, EventArgs e)
      {
         FileState fs = (FileState)lvwChanges.SelectedItems[0].Tag;
         excludedFiles.Remove(fs.id);
         showFiles();
      }
   }
}
