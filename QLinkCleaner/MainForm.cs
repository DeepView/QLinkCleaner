using Carlos.Extends;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using App = System.Windows.Forms.Application;

namespace QLinkCleaner
{
    public partial class MainForm : Form
    {
        private const string DEFAULT_MANIFEST_PATH = @"manifest\actived.ql-manifest";
        private const string STATISTIC_FILE_PATH = @"statistic.ini";
        public string OpenedManifestPath { get; set; } = string.Empty;
        public FileSystemWatcher[] Monitors { get; set; }
        public bool IsMonitoring { get; set; } = false;
        public bool IsSaved { get; set; } = false;
        public ApplicationLog Log { get; set; }
        public Statistic Statistic { get; set; }
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(@"log"))
                Directory.CreateDirectory(@"log");
            string logName = $"app.{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.log";
            Log = new ApplicationLog($@"log\{logName}");
            Statistic = Statistic.FromFile(STATISTIC_FILE_PATH);
            WriteLog("App", "Application started.");
            WriteLog("Statistic", "Statistical record loading completed.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsSaved)
                WriteLog("Manifest", $"The opened inventory file may not have been saved, file path is {OpenedManifestPath}");
            WriteLog("App", "Application exited.");
            notifyIcon_Main.Visible = false; // Hide the notify icon
            App.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkedListBox_Manifest.Items.Clear();
            if (!Directory.Exists(@"manifest"))
                Directory.CreateDirectory(@"manifest");
            if (!File.Exists(DEFAULT_MANIFEST_PATH))
            {
                string tips = "No activated manifest file detected, do you need to open a new manifest file? Or create a new blank inventory file? If you need to open a new inventory file, please click \"Yes\", otherwise click \"No\".";
                DialogResult msgboxres = MessageBox.Show(tips, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msgboxres == DialogResult.Yes)
                {
                    DialogResult dlgres = openFileDialog_OpenMainifest.ShowDialog(Owner);
                    if (dlgres == DialogResult.OK)
                    {
                        OpenedManifestPath = openFileDialog_OpenMainifest.FileName;
                        File.Copy(openFileDialog_OpenMainifest.FileName, DEFAULT_MANIFEST_PATH, true);
                    }
                    else
                    {
                        MessageBox.Show("You must select a manifest file to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        App.Exit();
                    }
                }
                else
                {
                    File.Create(DEFAULT_MANIFEST_PATH).Close();
                }
            }
            else LoadManifest(DEFAULT_MANIFEST_PATH);
            CheckStartupShortcut();
            CheckStartingSettings();
            if (IsMonitoring)
            {
                toolStripStatus_MonitorStatus.Text = "Monitoring is ON";
            }
            else
            {
                toolStripStatus_MonitorStatus.Text = "Monitoring is OFF";
            }
        }

        public static void CheckStartupShortcut()
        {
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupFolderPath, "QLink Cleaner.lnk");
            if (!File.Exists(shortcutPath))
            {
                Properties.Settings.Default.FollowSystemStartup = false;
                Properties.Settings.Default.Save();
            }
        }

        private void CheckStartingSettings()
        {
            object sender = new();
            EventArgs e = new();
            if (Properties.Settings.Default.CleanNowWhenStartingApp)
            {
                cleanNowToolStripMenuItem_Click(sender, e);
            }
            if (Properties.Settings.Default.RunMonitoringWhenStartingApp)
            {
                startMonitorToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgres = openFileDialog_OpenMainifest.ShowDialog(Owner);
            if (dlgres == DialogResult.OK)
            {
                checkedListBox_Manifest.Items.Clear();
                LoadManifest(openFileDialog_OpenMainifest.FileName);
            }
        }

        private void LoadManifest(string path)
        {
            int index = 0;
            string pattern = @"^[-+][C-Zc-z]:\\.+$";
            using StreamReader streamReader = new(path, Encoding.UTF8);
            while (!streamReader.EndOfStream)
            {
                string? line = streamReader.ReadLine();
                if (line != null)
                {
                    bool isMatch = Regex.IsMatch(line, pattern);
                    if (isMatch)
                    {
                        bool isChecked = line.Left(1) == "+";
                        checkedListBox_Manifest.Items.Add(line.Right(line.Length - 1));
                        checkedListBox_Manifest.SetItemChecked(index, isChecked);
                        index++;
                    }
                }
            }
            OpenedManifestPath = path;
            WriteLog("Manifest", $"Manifest file loaded from {path}.");
        }

        private void SaveManifest(string path)
        {
            using StreamWriter streamWriter = new(path, false, Encoding.UTF8);
            foreach (string item in checkedListBox_Manifest.Items)
            {
                string line = $"{(checkedListBox_Manifest.GetItemChecked(checkedListBox_Manifest.Items.IndexOf(item)) ? "+" : "-")}{item}";
                streamWriter.WriteLine(line);
            }
            IsSaved = true;
        }

        public void WriteLog(string category, string message) => Log.WriteLine(category, message);

        private void saveManifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OpenedManifestPath))
            {
                SaveManifest(OpenedManifestPath);
                if (!OpenedManifestPath.IsEquals(DEFAULT_MANIFEST_PATH))
                {
                    File.Copy(OpenedManifestPath, DEFAULT_MANIFEST_PATH, true);
                    WriteLog("Manifest", $"Manifest file saved to {OpenedManifestPath} and copied to default path {DEFAULT_MANIFEST_PATH}.");
                }
                else
                {
                    WriteLog("Manifest", $"Manifest file saved to {OpenedManifestPath}.");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgres = saveFileDialog_SaveManifest.ShowDialog(Owner);
            if (dlgres == DialogResult.OK)
            {
                string savePath = saveFileDialog_SaveManifest.FileName;
                SaveManifest(savePath);
                OpenedManifestPath = savePath;
                WriteLog("Manifest", $"Manifest file saved to {OpenedManifestPath}.");
            }
        }

        private void existsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an existing shortcuts or URL file.",
                Filter = "Shortcuts (*.lnk)|*.lnk|URL Files (*.url)|*.url",
                InitialDirectory = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) ?? string.Empty
            };
            DialogResult dlgres = openFileDialog.ShowDialog(Owner);
            if (dlgres == DialogResult.OK)
            {
                if (checkedListBox_Manifest.Items.Contains(openFileDialog.FileName))
                {
                    MessageBox.Show("This file is already in the manifest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    checkedListBox_Manifest.Items.Add(openFileDialog.FileName);
                    WriteLog("Manifest", $"Added existing file {openFileDialog.FileName} to the manifest.");
                }
            }
        }

        private void nonexistentShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextTransferForm textTransferForm = new()
            {
                Text = "Add a new shortcut or URL file to the manifest"
            };
            DialogResult dlgres = textTransferForm.ShowDialog(Owner);
            if (dlgres == DialogResult.OK)
            {
                string content = textTransferForm.TextboxContent;
                string pattern = @"^[C-Zc-z]:\\.+?\.(?:lnk|url)$";
                bool isMatch = Regex.IsMatch(content, pattern);
                if (isMatch)
                {
                    if (checkedListBox_Manifest.Items.Contains(content))
                    {
                        MessageBox.Show("This file is already in the manifest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        checkedListBox_Manifest.Items.Add(content);
                        WriteLog("Manifest", $"Added new file {content} to the manifest.");
                    }
                }
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Manifest.SelectedItem != null)
            {
                checkedListBox_Manifest.Items.Remove(checkedListBox_Manifest.SelectedItem);
                WriteLog("Manifest", $"Removed item {checkedListBox_Manifest.SelectedItem} from the manifest.");
            }
            else
            {
                MessageBox.Show("No item is selected to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextTransferForm textTransferForm = new()
            {
                Text = "Change the selected shortcut or URL file in the manifest"
            };
            if (checkedListBox_Manifest.SelectedItem != null)
            {
                textTransferForm.TextboxContent = checkedListBox_Manifest.SelectedItem.ToString() ?? string.Empty;
                DialogResult dlgres = textTransferForm.ShowDialog(Owner);
                if (dlgres == DialogResult.OK)
                {
                    string content = textTransferForm.TextboxContent.Trim();
                    string pattern = @"^[C-Zc-z]:\\.+?\.(?:lnk|url)$";
                    bool isMatch = Regex.IsMatch(content, pattern);
                    if (isMatch)
                    {
                        int selectedIndex = checkedListBox_Manifest.SelectedIndex;
                        checkedListBox_Manifest.Items[selectedIndex] = content;
                    }
                    WriteLog("Manifest", $"Changed item {checkedListBox_Manifest.SelectedItem} to {content} in the manifest.");
                }
            }
            else
            {
                MessageBox.Show("No item is selected to change.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Manifest.Items.Count == 0)
            {
                MessageBox.Show("The manifest is empty, please add items to monitor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Monitors = new FileSystemWatcher[checkedListBox_Manifest.Items.Count];
            for (int i = 0; i < checkedListBox_Manifest.Items.Count; i++)
            {
                string itemPath = checkedListBox_Manifest.Items[i].ToString() ?? string.Empty;

                Monitors[i] = new()
                {
                    NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size,
                    Path = Path.GetDirectoryName(itemPath) ?? string.Empty,
                    Filter = Path.GetFileName(itemPath),
                };
                bool isChecked = checkedListBox_Manifest.GetItemChecked(i);
                Monitors[i].Created += OnCreated;
                Monitors[i].Changed += OnCreated;
                Monitors[i].Renamed += OnCreated;
                Monitors[i].Deleted += OnDeleted;
                Monitors[i].EnableRaisingEvents = true;
            }

            IsMonitoring = true;
            toolStripStatus_MonitorStatus.Text = "Monitoring is ON";
            checkedListBox_Manifest.Enabled = !IsMonitoring;

            SetManifestMenuEnabled(!IsMonitoring);
            ChangeNotifyIconText();
            WriteLog("Monitor", "File system monitoring started for all items in the manifest.");
        }
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            int index = Array.FindIndex(Monitors, monitor => monitor == sender);
            if (index >= 0 && checkedListBox_Manifest.GetItemChecked(index))
            {
                string itemPath = checkedListBox_Manifest.Items[index].ToString() ?? string.Empty;
                if (File.Exists(itemPath))
                {
                    File.Delete(itemPath);
                    WriteLog("Monitor", $"Detected the existence of file {itemPath}, automatically cleaned up.");
                    notifyIcon_Main.BalloonTipText = $"Detected the existence of file {itemPath}, automatically cleaned up.";
                    notifyIcon_Main.ShowBalloonTip(3000); // Show a balloon tip for 3 seconds
                }
            }
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            int index = Array.FindIndex(Monitors, monitor => monitor == sender);
            if (index >= 0 && checkedListBox_Manifest.GetItemChecked(index))
            {
                string itemPath = checkedListBox_Manifest.Items[index].ToString() ?? string.Empty;
                if (!File.Exists(itemPath))
                {
                    Statistic.UpdateRecord();
                    do
                    {
                        Thread.Sleep(50); // Wait until the file is not locked
                    } while (!IsFileLocked(STATISTIC_FILE_PATH));
                    Statistic.Save(STATISTIC_FILE_PATH);
                }
            }
        }

        public static bool IsFileLocked(string filePath)
        {
            try
            {
                using FileStream stream = new(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                using StreamReader reader = new(stream);
                // If we get here, the file is not locked
                return false;
            }
            catch (IOException)
            {
                // The file is locked by another process or thread
                return true;
            }
        }

        private void SetManifestMenuEnabled(bool enabled)
        {
            existsedToolStripMenuItem.Enabled = enabled;
            nonexistentShortcutToolStripMenuItem.Enabled = enabled;
            removeToolStripMenuItem1.Enabled = enabled;
            changeToolStripMenuItem.Enabled = enabled;

            startMonitorToolStripMenuItem.Enabled = enabled;
            stopMonitorToolStripMenuItem.Enabled = !enabled;
        }

        private void stopMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Manifest.Items.Count == 0)
            {
                MessageBox.Show("The manifest is empty, there are no monitors to stop.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (FileSystemWatcher monitor in Monitors)
            {
                if (monitor != null)
                {
                    monitor.EnableRaisingEvents = false;
                    monitor.Dispose();
                }
            }
            IsMonitoring = false;
            checkedListBox_Manifest.Enabled = !IsMonitoring;
            SetManifestMenuEnabled(!IsMonitoring);
            ChangeNotifyIconText();
            toolStripStatus_MonitorStatus.Text = "Monitoring is OFF";
            MessageBox.Show("All monitors have been stopped, you can modify the manifest file now.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            WriteLog("Monitor", "File system monitoring stopped for all items in the manifest.");
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void cleanNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int failedCount = 0;
            int totalCount = checkedListBox_Manifest.Items.Count;
            foreach (string item in checkedListBox_Manifest.Items)
            {
                if (File.Exists(item))
                {
                    try
                    {
                        if (checkedListBox_Manifest.GetItemChecked(checkedListBox_Manifest.Items.IndexOf(item)))
                        {
                            File.Delete(item);
                        }
                        else
                        {
                            failedCount++;
                        }
                    }
                    catch
                    {
                        failedCount++;
                    }
                }
            }
            if (failedCount == 0)
            {
                MessageBox.Show("All shortcuts and URL files in the manifest have been cleaned.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WriteLog("App", $"Successfully cleaned {totalCount} shortcuts and URL files in the manifest.");
            }
            else
            {
                MessageBox.Show($"Failed to clean {failedCount} out of {totalCount} shortcuts and URL files in the manifest.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WriteLog("App", $"Failed to clean {failedCount} out of {totalCount} shortcuts and URL files in the manifest.");
            }
        }

        private void openLogDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetFullPath(@"log"));
        }

        private void viewCurrentLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Log.LogFilePath);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutBoxForm = new();
            aboutBoxForm.ShowDialog(Owner);
        }

        private void viewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is a simple tool for managing and cleaning up shortcuts and URL files in a manifest. It allows you to add, remove, and monitor files, as well as clean them up when needed.", "About QLinkCleaner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void appConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not yet implemented.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppConfigForm appConfigForm = new AppConfigForm
            {
                Owner = this
            };
            appConfigForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event to prevent the form from closing
                string monitorStatus = IsMonitoring ? "ON" : "OFF";
                notifyIcon_Main.Visible = true; // Show the notify icon
                notifyIcon_Main.BalloonTipText = "The application did not exit, it has switched to running in the background.";
                notifyIcon_Main.ShowBalloonTip(3000); // Show a balloon tip for 3 seconds
                //notifyIcon_Main.ContextMenuStrip = contextMenu_Notify; // Set the context menu for the notify icon
                ChangeNotifyIconText();
                WriteLog("App", "The application did not exit, it has switched to running in the background.");
                Hide();
            }
        }

        private void ChangeNotifyIconText()
        {
            string monitorStatus = IsMonitoring ? "ON" : "OFF";
            notifyIcon_Main.Text = $"QLink Cleaner\nApp monitoring is {monitorStatus}";
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            //Enabled = true; // Re-enable the form to allow interaction
            WriteLog("App", "The application has switched to running in the foreground.");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void contextMenu_Notify_DoubleClick(object sender, EventArgs e)
        {
            //showWindowToolStripMenuItem_Click(sender, e);
        }

        private void checkedListBox_Manifest_Click(object sender, EventArgs e)
        {
            if (IsMonitoring)
                MessageBox.Show("File system monitoring is currently enabled, you cannot modify the manifest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkedListBox_Manifest_EnabledChanged(object sender, EventArgs e)
        {
            checkedListBox_Manifest_Click(sender, e);
        }

        private void notifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showWindowToolStripMenuItem_Click(sender, e);
        }

        private void clearReacordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear all statistical records? This action cannot be undone.", "Confirm Clear Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Statistic.Reset();
                Statistic.Save(STATISTIC_FILE_PATH);
                WriteLog("Statistic", "All statistical records have been cleared.");
            }
        }

        private void viewStatisticalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new();
            statisticForm.ShowDialog(this, Statistic);
        }
    }
}
