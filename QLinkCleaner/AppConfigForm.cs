using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carlos.Extends;

namespace QLinkCleaner
{
    public partial class AppConfigForm : Form
    {
        public AppConfigForm()
        {
            InitializeComponent();
        }

        private void AppConfigForm_Load(object sender, EventArgs e)
        {
            checkBox_CleanNowWhenStartingApp.Checked = Properties.Settings.Default.CleanNowWhenStartingApp;
            checkBox_CleanNowWhenStartingApp.CheckedChanged += (s, ev) =>
            {
                Properties.Settings.Default.CleanNowWhenStartingApp = checkBox_CleanNowWhenStartingApp.Checked;
                ((MainForm)Owner).WriteLog("Configure", "CleanNowWhenStartingApp changed to " + checkBox_CleanNowWhenStartingApp.Checked);
                Properties.Settings.Default.Save();
            };
            checkBox_FollowSystemStartup.Checked = Properties.Settings.Default.FollowSystemStartup;
            checkBox_FollowSystemStartup.CheckedChanged += (s, ev) =>
            {
                Properties.Settings.Default.FollowSystemStartup = checkBox_FollowSystemStartup.Checked;
                if (checkBox_FollowSystemStartup.Checked)
                {
                    CreateStartupShortcut(); // 创建启动快捷方式
                }
                else
                {
                    // 删除启动快捷方式
                    string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    string shortcutPath = Path.Combine(startupFolderPath, "QLink Cleaner.lnk");
                    if (File.Exists(shortcutPath))
                    {
                        File.Delete(shortcutPath);
                    }
                }
                ((MainForm)Owner).WriteLog("Configure", "FollowSystemStartup changed to " + checkBox_FollowSystemStartup.Checked);
                Properties.Settings.Default.Save();
            };
            checkBox_RunMonitoringWhenStartingApp.Checked = Properties.Settings.Default.RunMonitoringWhenStartingApp;
            checkBox_RunMonitoringWhenStartingApp.CheckedChanged += (s, ev) =>
            {
                Properties.Settings.Default.RunMonitoringWhenStartingApp = checkBox_RunMonitoringWhenStartingApp.Checked;
                ((MainForm)Owner).WriteLog("Configure", "RunMonitoringWhenStartingApp changed to " + checkBox_RunMonitoringWhenStartingApp.Checked);
                Properties.Settings.Default.Save();
            };
        }

        public static void CreateStartupShortcut()
        {
            // 获取启动文件夹的路径
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            // 获取应用程序的可执行文件路径
            string exePath = Assembly.GetExecutingAssembly().Location;
            // 创建快捷方式的文件路径
            string shortcutPath = Path.Combine(startupFolderPath, "QLink Cleaner.lnk");
            exePath = $"{exePath.Left(exePath.Length - 4)}.exe";
            // 检查快捷方式是否已存在
            if (!File.Exists(shortcutPath))
            {
                // 创建快捷方式
                var shortcut = (IWshRuntimeLibrary.WshShortcut)new IWshRuntimeLibrary.WshShell().CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.Arguments = MainForm.RUN_ARG_HIDE_IN_STARTUP; // 可以在这里添加启动参数，如果需要的话
                shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);
                shortcut.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
