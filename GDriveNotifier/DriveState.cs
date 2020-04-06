using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDriveNotifier
{
   class DriveState
   {
      public Dictionary<string, FileState> FileStates = new Dictionary<string, FileState>();
      public DateTime LastUpdate = DateTime.Now;
   }
}
