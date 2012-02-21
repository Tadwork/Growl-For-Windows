using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Growl.Installation
{
    public partial class InstallLanguage : Form
    {
        private const string USER_AGENT = "Growl for Windows - AutoInstaller";
        private const string TEMP_FOLDER = "__temp";

        private Growl.CoreLibrary.WebClientEx wc;
        private string uri;
        private bool appIsAlreadyRunning;
        private string tempFolder = Path.Combine(Utility.UserSettingFolder, TEMP_FOLDER);
        private System.Threading.ManualResetEvent mre = new System.Threading.ManualResetEvent(false);
        private System.Threading.AutoResetEvent are = new System.Threading.AutoResetEvent(false);
        private DownloadProgressChangedEventArgs progress;
        private object progress_lock = new object();
        private string errorMessage;

        public InstallLanguage()
        {
            InitializeComponent();

            // localize text
            this.Text = Properties.Resources.LanguageInstaller_FormTitle;
            //this.InfoLabel.Text gets set below when displayed
            this.YesButton.Text = Properties.Resources.Button_Yes;
            this.NoButton.Text = Properties.Resources.Button_Cancel;
            this.OKButton.Text = Properties.Resources.Button_OK;

            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        public bool LaunchInstaller(string uri, bool appIsAlreadyRunning, ref List<InternalNotification> queuedNotifications, ref int cultureCodeHash)
        {
            bool languageInstalled = false;
            this.uri = uri;
            this.appIsAlreadyRunning = appIsAlreadyRunning;

            try
            {
                // handle special case where we are resetting the value
                if (uri == "reset")
                {
                    Properties.Settings.Default.CultureCode = "";
                    Properties.Settings.Default.Save();
                    cultureCodeHash = 0;
                    languageInstalled = true;
                    return languageInstalled;
                }

                this.wc = new Growl.CoreLibrary.WebClientEx();
                wc.Headers.Add("User-Agent", USER_AGENT);

                byte[] data = wc.DownloadData(this.uri);
                string definition = Encoding.UTF8.GetString(data).Trim();
                LanguageInfo info = LanguageInfo.Parse(definition);
                if (info != null)
                {
                    this.InfoLabel.Text = String.Format(Utility.GetResourceString(Properties.Resources.LanguageInstaller_Prompt), info.Name);
                    this.YesButton.Visible = true;
                    this.NoButton.Visible = true;
                    this.OKButton.Visible = false;

                    /* NOTE: there is a bug that is caused when Growl is launched via protocol handler (growl:) from Opera.
                     * when that happens, the call to ShowDialog hangs.
                     * i could not find any documentation on this or any reason why it would be happening (not on a non-ui thread, windows handle is already created, etc).
                     * the only fix i could find was to Show/Hide the form before calling ShowDialog. i dont even know why this works, but it does.
                     * */
                    this.Show();
                    this.Hide();

                    DialogResult result = this.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        this.InfoLabel.Text = Utility.GetResourceString(Properties.Resources.LanguageInstaller_Installing);
                        this.progressBar1.Value = 0;
                        this.progressBar1.Visible = true;
                        this.YesButton.Enabled = false;
                        this.NoButton.Enabled = false;
                        this.Show();
                        this.Refresh();

                        if (Directory.Exists(this.tempFolder))
                            Directory.Delete(this.tempFolder, true);
                        Directory.CreateDirectory(this.tempFolder);
                        string guid = System.Guid.NewGuid().ToString();
                        string zipFileName = GetTempZipFileName(guid);
                        info.LocalZipFileLocation = zipFileName;

                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);

                        StartDownload(info);

                        Utility.WriteDebugInfo(String.Format("Downloading language pack '{0}' to {1}", info.Name, info.LocalZipFileLocation));

                        System.Threading.WaitHandle[] handles = new System.Threading.WaitHandle[] { are, mre };
                        while (System.Threading.WaitHandle.WaitAny(handles) == 0)
                        {
                            lock (this.progress_lock)
                            {
                                this.progressBar1.Value = this.progress.ProgressPercentage;
                                Application.DoEvents();
                            }
                        }

                        this.progressBar1.Value = 100;
                        Application.DoEvents();

                        Utility.WriteDebugInfo(String.Format("Finished downloading language pack '{0}' to {1}", info.Name, info.LocalZipFileLocation));

                        if (this.errorMessage == null)
                        {
                            // unzip files to the correct location
                            string languageFolder = GetLanguageFolder(info.CultureCode);
                            if (!ApplicationMain.HasProgramLaunchedYet || !Directory.Exists(languageFolder))
                            {
                                Utility.WriteDebugInfo(String.Format("Language '{0}' downloaded - starting unzip.", info.Name));

                                // NOTE: installing a language pack requires elevated privileges (to write the resource assemblies to the bin folder).
                                // as such, we have to be elevated first
                                if (UserAccountControlHelper.IsElevated())
                                {
                                    cultureCodeHash = UnzipFilesToBin(info.Name, info.LocalZipFileLocation, info.CultureCode, ref queuedNotifications);
                                }
                                else
                                {
                                    string argument = String.Format("growl:languageelevatedinstall*{0}~{1}~{2}", info.CultureCode, info.Name, guid);
                                    UserAccountControlHelper.LaunchElevatedApplication(System.Windows.Forms.Application.ExecutablePath, argument, true);
                                }

                                this.Close();
                            }
                            else
                            {
                                // display with the same name aleady exists...
                                ShowMessage(String.Format(Utility.GetResourceString(Properties.Resources.LanguageInstaller_AlreadyInstalled), info.Name), true);
                            }
                        }
                        else
                        {
                            Utility.WriteDebugInfo(String.Format("Error downloading language pack '{0}'.", info.Name));
                            ShowMessage(errorMessage, true);
                        }
                    }
                }
                else
                {
                    // definition file was malformed
                    ShowMessage(String.Format(Utility.GetResourceString(Properties.Resources.LanguageInstaller_BadDefinitionFile), this.uri), true);
                }
            }
            catch (Exception ex)
            {
                // error downloading definition file
                Utility.WriteDebugInfo(String.Format("Error downloading language pack. {0} - {1}", ex.Message, ex.StackTrace));
                ShowMessage(String.Format(Utility.GetResourceString(Properties.Resources.LanguageInstaller_NonexistentDefinitionFile), this.uri), true);
            }
            return languageInstalled;
        }

        public bool FinishElevatedInstall(string data, ref List<InternalNotification> queuedNotifications, ref int cultureCodeHash)
        {
            // data format: {culturecode}~{name}~{tempfolderguid}
            string[] parts = data.Split('~');
            string cultureCode = parts[0];
            string name = parts[1];
            string tempfolderguid = parts[2];

            string zipFileLocation = GetTempZipFileName(tempfolderguid);
            cultureCodeHash = UnzipFilesToBin(name, zipFileLocation, cultureCode, ref queuedNotifications);
            return true;
        }

        private int UnzipFilesToBin(string name, string zipFileLocation, string cultureCode, ref List<InternalNotification> queuedNotifications)
        {
            // unzip
            string languageFolder = GetLanguageFolder(cultureCode);
            Unzipper.UnZipFiles(zipFileLocation, languageFolder, false);

            // clean up
            Utility.WriteDebugInfo(String.Format("Deleteing '{0}' zip file at {1}", name, zipFileLocation));
            if (File.Exists(zipFileLocation)) File.Delete(zipFileLocation);

            // notify
            string text = String.Format(Properties.Resources.LanguageInstaller_LanguageInstalledText, name);
            if (ApplicationMain.HasProgramLaunchedYet) text += (" " + Properties.Resources.LanguageInstaller_RestartRequiredText);
            InternalNotification n = new InternalNotification(Properties.Resources.LanguageInstaller_LanguageInstalledTitle, Utility.GetResourceString(text), null);
            queuedNotifications.Add(n);

            // done
            Properties.Settings.Default.CultureCode = cultureCode;
            int cultureCodeHash = cultureCode.GetHashCode();
            return cultureCodeHash;
        }

        private string GetLanguageFolder(string cultureCode)
        {
            string languageFolder = Path.Combine(Application.StartupPath, cultureCode);
            return languageFolder;
        }

        private string GetTempZipFileName(string guid)
        {
            string zipFileName = Path.Combine(this.tempFolder, String.Format("{0}.zip", guid));
            return zipFileName;
        }

        private void StartDownload(object obj)
        {
            LanguageInfo info = (LanguageInfo)obj;
            this.wc.DownloadFileAsync(new Uri(info.PackageUrl), info.LocalZipFileLocation, info);
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Utility.WriteDebugInfo(e.Error.Message);
                Utility.WriteDebugInfo(e.Error.StackTrace);
                this.errorMessage = Utility.GetResourceString(Properties.Resources.LanguageInstaller_DownloadError);
            }
            else if (e.Cancelled)
            {
                this.errorMessage = Utility.GetResourceString(Properties.Resources.LanguageInstaller_DownloadCancelled);
            }
            else
            {
                // sometimes the downloaded file is still being written to disk.
                // this will wait until the file is readable before returning.
                LanguageInfo info = (LanguageInfo)e.UserState;
                bool fileAvailable = false;
                int counter = 0;
                while (!fileAvailable && counter < 10)
                {
                    counter++;
                    try
                    {
                        FileStream fs = File.OpenRead(info.LocalZipFileLocation);
                        using (fs)
                        {
                            fileAvailable = true;
                        }
                    }
                    catch
                    {
                        // wait a bit to allow the disk I/O to complete
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }

            mre.Set();
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lock (this.progress_lock)
            {
                this.progress = e;
                are.Set();
            }
        }

        private void ShowMessage(string message)
        {
            ShowMessage(message, false);
        }

        private void ShowMessage(string message, bool modal)
        {
            this.InfoLabel.Text = message;
            this.progressBar1.Visible = false;
            this.YesButton.Visible = false;
            this.NoButton.Visible = false;
            this.OKButton.Visible = true;
            if (this.appIsAlreadyRunning || modal)
            {
                this.Hide();
                DialogResult result = this.ShowDialog();
            }
            else
            {
                this.Show();
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.wc != null)
                {
                    wc.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                    wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                    wc.Dispose();
                    wc = null;
                }

                if (this.mre != null) mre.Close();
                if (this.are != null) are.Close();
                if (this.components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }

        public class LanguageInfo
        {
            private LanguageInfo() { }

            public LanguageInfo(string name, string cultureCode, string packageUrl)
            {
                this.Name = name;
                this.CultureCode = cultureCode;
                this.PackageUrl = packageUrl;
            }

            public readonly string Name;
            public readonly string CultureCode;
            public readonly string PackageUrl;
            public string LocalZipFileLocation;

            public static LanguageInfo Parse(string data)
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(data);

                    XmlElement root = xml.DocumentElement;
                    XmlElement nameNode = root["name"];
                    XmlElement cultureCodeNode = root["culture"];
                    XmlElement packageUrlNode = root["packageurl"];

                    string name = nameNode.InnerText.Trim();
                    string cultureCode = cultureCodeNode.InnerText.Trim();
                    string packageUrl = packageUrlNode.InnerText.Trim();

                    LanguageInfo info = new LanguageInfo(name, cultureCode, packageUrl);
                    return info;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}