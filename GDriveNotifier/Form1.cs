using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GDriveNotifier
{
    public partial class Form1 : Form
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive Notifier";
        string pageToken = Properties.Settings.Default.PageToken;
        bool Initialised = false;
        DriveState driveState = new DriveState();
        UserCredential credential;
        public Dictionary<string, FileState> excludedFiles = new Dictionary<string, FileState>();
        string strLastTip = "";
        int failedChecks = 0;


        DateTime datLast = Properties.Settings.Default.LastChange;
        public void log(string msg, int logLevel = 10)
        {
            string strLog = string.Format("[{0:yyyy-MM-dd HH:mm:ss}] {1}", DateTime.Now, msg);
            Console.WriteLine(strLog);
            if (Properties.Settings.Default.LogToFile && Properties.Settings.Default.LogLevel >= logLevel)
            {
                StreamWriter sw = new StreamWriter(string.Format("log-{0:yyyy-MM-dd}.txt", DateTime.Now), true);
                sw.WriteLine(strLog);
                sw.Flush();
                sw.Close();
            }
        }

        public void saveExcludes()
        {
            StreamWriter sw = new StreamWriter("exclude.json", false);
            sw.Write(JsonConvert.SerializeObject(excludedFiles, Formatting.Indented));
            sw.Flush();
            sw.Close();
            log("Saved excludes", 7);
        }

        public void saveState()
        {
            StreamWriter sw = new StreamWriter("state.json", false);
            sw.Write(JsonConvert.SerializeObject(driveState, Formatting.Indented));
            sw.Flush();
            sw.Close();
            log("Saved state", 7);
        }

        public bool loadExcludes()
        {
            if (!System.IO.File.Exists("exclude.json"))
            {
                log("Failed to excludes", 2);
                return false;
            }
            try
            {
                StreamReader sr = new StreamReader("exclude.json");
                string strExcluded = sr.ReadToEnd();
                sr.Close();
                excludedFiles = JsonConvert.DeserializeObject<Dictionary<string, FileState>>(strExcluded);
            }
            catch (Exception ex)
            {
                log("Failed to load excludes", 2);
                log(ex.Message, 2);
                return false;
            }
            log("Loaded excludes", 7);
            return true;
        }

        public bool loadState()
        {
            if (!System.IO.File.Exists("state.json"))
            {
                log("Failed to load state", 2);
                return false;
            }
            try
            {
                StreamReader sr = new StreamReader("state.json");
                string strState = sr.ReadToEnd();
                sr.Close();
                driveState = JsonConvert.DeserializeObject<DriveState>(strState);
            }
            catch (Exception ex)
            {
                log("Failed to load state", 2);
                log(ex.Message, 2);
                return false;
            }
            log("Loaded state", 7);
            return true;
        }

        public void setIcon(string iconName)
        {
            Bitmap b;
            IntPtr pIcon;
            Icon ico;
            switch (iconName.ToLower().Trim())
            {
                case "red":
                    b = (Bitmap)Image.FromFile("eye-icon-red.png");
                    break;
                case "green":
                    b = (Bitmap)Image.FromFile("eye-icon-green.png");
                    break;
                default:
                    b = (Bitmap)Image.FromFile("eye-icon.png");
                    break;
            }
            pIcon = b.GetHicon();
            ico = Icon.FromHandle(pIcon);
            nfyIcon.Icon = ico;
        }

        public void savePageToken(string tok)
        {
            Properties.Settings.Default.PageToken = tok;
            Properties.Settings.Default.Save();
        }

        private void mnuFileOpen(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;
            FileState fs = (FileState)mnu.Tag;
            openDoc(fs);
        }

        public void addOpenFileToTaskBard(int itemNo, FileState fs)
        {
            if (itemNo == 0)
            {
                // Need to clear down old items
                int menuCount = 2;
                while (mnuTaskBar.Items[2].Text != "")
                {
                    mnuTaskBar.Items.RemoveAt(2);
                }
            }
            ToolStripMenuItem mnu = new ToolStripMenuItem(fs.name, null, mnuFileOpen);
            mnu.Tag = fs;
            mnuTaskBar.Items.Insert(2 + itemNo, mnu);
        }

        public void showFiles()
        {
            int fileCount = 0;
            lvwChanges.Items.Clear();
            foreach (FileState fileState in driveState.FileStates.Values.OrderByDescending((fs) => fs.lastEditWhen))
            {
                if (fileState.lastEditWhen > DateTime.Now.AddMonths(-3) && !excludedFiles.ContainsKey(fileState.id))
                {
                    ListViewItem lvwNew = lvwChanges.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm}", fileState.lastEditWhen));
                    lvwNew.Tag = fileState;
                    lvwNew.SubItems.Add(fileState.name);
                    lvwNew.SubItems.Add(fileState.lastEditBy);
                    if (Properties.Settings.Default.AddFilesToTaskbar)
                    {
                        addOpenFileToTaskBard(fileCount, fileState);
                    }
                    fileCount++;
                }
            }
        }

        public string updateFileState(Google.Apis.Drive.v3.Data.File file)
        {
            FileState fileState;
            if (driveState.FileStates.ContainsKey(file.Id))
            {
                fileState = driveState.FileStates[file.Id];
            }
            else
            {
                fileState = new FileState();
                fileState.id = file.Id;
                driveState.FileStates[fileState.id] = fileState;
            }
            fileState.name = file.Name;
            if (file.LastModifyingUser == null || file.LastModifyingUser.DisplayName == null)
            {
                fileState.lastEditBy = "Unknown";
            }
            else
            {
                fileState.lastEditBy = file.LastModifyingUser.DisplayName;
            }
            fileState.lastEditWhen = (DateTime)file.ModifiedTime;
            fileState.editURL = file.WebViewLink;
            fileState.lastStateUpdate = DateTime.Now;
            driveState.LastUpdate = DateTime.Now;
            return fileState.lastEditBy;
        }

        public void getCredentials()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                log("Credential file saved to: " + credPath, 7);
            }
        }

        public void checkChanges()
        {
            string strDocsChanged = "";
            tmrCheck.Stop();
            log("Checking changes", 5);
            if (credential == null)
            {
                getCredentials();
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // List files.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.Fields = "nextPageToken, files(id, name, lastModifyingUser(displayName), modifiedTime, parents, trashed, webViewLink)";

            var response = listRequest.Execute();
            IList<Google.Apis.Drive.v3.Data.File> files = response.Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    string lastEditBy = updateFileState(file);
                    if (file.ModifiedTime > datLast && !excludedFiles.ContainsKey(file.Id) && Properties.Settings.Default.MyName != lastEditBy)
                    {
                        if (file.Name.Length > 35)
                        {
                            strDocsChanged += file.Name.Substring(0,34) + Environment.NewLine;
                        }
                        else
                        {
                            strDocsChanged += file.Name + Environment.NewLine;
                        }
                        setIcon("red");
                    }
                    log(file.Name, 10);
                }
            }
            else
            {
                log("No files found.", 10);
            }
            if (strDocsChanged != "")
            {
                if (Properties.Settings.Default.WindowsNotifications && strDocsChanged != strLastTip)
                {
                    nfyIcon.BalloonTipTitle = "Changed Files";
                    if (strDocsChanged.Length > 63)
                    {
                        strDocsChanged = strDocsChanged.Substring(0, 60) + "...";
                    }
                    nfyIcon.BalloonTipText = strDocsChanged;
                    nfyIcon.ShowBalloonTip(Properties.Settings.Default.WindowsNotificationsSeconds);
                    strLastTip = strDocsChanged;
                }
                nfyIcon.Text = strDocsChanged;
            }
            else
            {
                strLastTip = "";
                nfyIcon.Text = "No changes";
            }
            saveState();
            showFiles();
            tmrCheck.Interval = Properties.Settings.Default.CheckSeconds * 1000;
            tmrCheck.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(" v{0}", Properties.Settings.Default.AppVer);
            log("Started " + this.Text, 5);
            loadState();
            loadExcludes();
            if (pageToken == "")
            {
                pageToken = "start";
            }
            tmrCheck.Start();
        }

        private void doCheck()
        {
            if (!Initialised) setIcon("green");
            Initialised = true;
            try
            {
                checkChanges();
                // reset the fail count
                failedChecks = 0;
            }
            catch (Exception ex)
            {
                // increment the fail count
                failedChecks++;
                log("*** Error: " + ex.Message, 2);
                log(ex.StackTrace, 2);
                if (!tmrCheck.Enabled)
                {
                    tmrCheck.Start();
                }
                // 3 failed checks in a row bombs out.
                if (failedChecks > 3)
                {
                    throw;
                }
            }
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            doCheck();
        }

        private void nfyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void markRead()
        {
            setIcon("green");
            Properties.Settings.Default.LastChange = DateTime.Now;
            datLast = DateTime.Now;
            Properties.Settings.Default.Save();
        }

        private void nfyIcon_Click(object sender, EventArgs e)
        {
            markRead();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                nfyIcon.Visible = true;
            }
        }

        /// <summary>
        /// Open currently selected document in google docs in browser
        /// </summary>
        private void openDoc(FileState fs = null)
        {
            string strURL = "https://drive.google.com/";
            if (fs is null)
            {
                if (lvwChanges.SelectedItems.Count > 0)
                {
                    fs = (FileState)lvwChanges.SelectedItems[0].Tag;
                }
            }
            if (fs is null)
            {
                return;
            }
            else
            {
                if (fs.editURL != null)
                {
                    strURL = fs.editURL.ToString().Split('|')[0];
                }
                System.Diagnostics.Process.Start(strURL);
            }

        }

        private void lvwChanges_DoubleClick(object sender, EventArgs e)
        {
            openDoc();
        }

        private void lvwChanges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log("Finished " + this.Text, 5);
        }

        private void mnuListExcudeDoc_Click(object sender, EventArgs e)
        {
            FileState fs = (FileState)lvwChanges.SelectedItems[0].Tag;
            try
            {
                excludedFiles.Add(fs.id, fs);
                saveExcludes();
                doCheck();
            }
            catch (Exception ex)
            {
                // Do nothing here - we'd just be adding a duplicate
            }
        }

        private void mnuMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDocRefresh_Click(object sender, EventArgs e)
        {
            doCheck();
        }

        private void mnuListOpen_Click(object sender, EventArgs e)
        {
            openDoc();
        }

        private void mnuDocExclusions_Click(object sender, EventArgs e)
        {
            Excludes frmExcludes = new Excludes(excludedFiles);
            frmExcludes.ShowDialog();
            excludedFiles = frmExcludes.excludedFiles;
            saveExcludes();
            doCheck();
        }

        private void mnuListMe_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MyName = lvwChanges.SelectedItems[0].SubItems[2].Text;
            Properties.Settings.Default.Save();
            log("Setting name to: " + Properties.Settings.Default.MyName, 5);
        }


        private void showSettings()
        {
            Settings frmSet = new Settings();
            frmSet.ShowDialog();
        }

        private void mnuMainSettings_Click(object sender, EventArgs e)
        {
            showSettings();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSettings();
        }
    }
}
