namespace QLinkCleaner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip_MainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveManifestToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            appConfigureToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            existsedToolStripMenuItem = new ToolStripMenuItem();
            nonexistentShortcutToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            changeToolStripMenuItem = new ToolStripMenuItem();
            behaviorToolStripMenuItem = new ToolStripMenuItem();
            startMonitorToolStripMenuItem = new ToolStripMenuItem();
            stopMonitorToolStripMenuItem = new ToolStripMenuItem();
            cleanNowToolStripMenuItem = new ToolStripMenuItem();
            statisticToolStripMenuItem = new ToolStripMenuItem();
            viewStatisticalRecordsToolStripMenuItem = new ToolStripMenuItem();
            clearReacordsToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            openLogDirectoryToolStripMenuItem = new ToolStripMenuItem();
            viewCurrentLogToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            maxToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            viewDocumentToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkedListBox_Manifest = new CheckedListBox();
            openFileDialog_OpenMainifest = new OpenFileDialog();
            saveFileDialog_SaveManifest = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatus_MonitorStatus = new ToolStripStatusLabel();
            notifyIcon_Main = new NotifyIcon(components);
            contextMenu_Notify = new ContextMenuStrip(components);
            showWindowToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip_MainMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenu_Notify.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_MainMenu
            // 
            menuStrip_MainMenu.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            menuStrip_MainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, behaviorToolStripMenuItem, statisticToolStripMenuItem, logToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
            menuStrip_MainMenu.Location = new Point(0, 0);
            menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            menuStrip_MainMenu.Padding = new Padding(7, 2, 0, 2);
            menuStrip_MainMenu.Size = new Size(716, 25);
            menuStrip_MainMenu.TabIndex = 1;
            menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveManifestToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, appConfigureToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(217, 22);
            openToolStripMenuItem.Text = "&Open manifest...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveManifestToolStripMenuItem
            // 
            saveManifestToolStripMenuItem.Name = "saveManifestToolStripMenuItem";
            saveManifestToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveManifestToolStripMenuItem.Size = new Size(217, 22);
            saveManifestToolStripMenuItem.Text = "&Save manifest...";
            saveManifestToolStripMenuItem.Click += saveManifestToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(217, 22);
            saveAsToolStripMenuItem.Text = "S&ave as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(214, 6);
            // 
            // appConfigureToolStripMenuItem
            // 
            appConfigureToolStripMenuItem.Name = "appConfigureToolStripMenuItem";
            appConfigureToolStripMenuItem.Size = new Size(217, 22);
            appConfigureToolStripMenuItem.Text = "App &Configure...";
            appConfigureToolStripMenuItem.Click += appConfigureToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(217, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem1, changeToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(42, 21);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { existsedToolStripMenuItem, nonexistentShortcutToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(168, 22);
            addToolStripMenuItem.Text = "&Add";
            // 
            // existsedToolStripMenuItem
            // 
            existsedToolStripMenuItem.Name = "existsedToolStripMenuItem";
            existsedToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            existsedToolStripMenuItem.Size = new Size(291, 22);
            existsedToolStripMenuItem.Text = "&Existing shortcuts...";
            existsedToolStripMenuItem.Click += existsedToolStripMenuItem_Click;
            // 
            // nonexistentShortcutToolStripMenuItem
            // 
            nonexistentShortcutToolStripMenuItem.Name = "nonexistentShortcutToolStripMenuItem";
            nonexistentShortcutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            nonexistentShortcutToolStripMenuItem.Size = new Size(291, 22);
            nonexistentShortcutToolStripMenuItem.Text = "&Non-existent shortcut...";
            nonexistentShortcutToolStripMenuItem.Click += nonexistentShortcutToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.ShortcutKeys = Keys.Delete;
            removeToolStripMenuItem1.Size = new Size(168, 22);
            removeToolStripMenuItem1.Text = "Re&move";
            removeToolStripMenuItem1.Click += removeToolStripMenuItem1_Click;
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            changeToolStripMenuItem.Size = new Size(168, 22);
            changeToolStripMenuItem.Text = "&Modify";
            changeToolStripMenuItem.Click += changeToolStripMenuItem_Click;
            // 
            // behaviorToolStripMenuItem
            // 
            behaviorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startMonitorToolStripMenuItem, stopMonitorToolStripMenuItem, cleanNowToolStripMenuItem });
            behaviorToolStripMenuItem.Name = "behaviorToolStripMenuItem";
            behaviorToolStripMenuItem.Size = new Size(71, 21);
            behaviorToolStripMenuItem.Text = "&Behavior";
            // 
            // startMonitorToolStripMenuItem
            // 
            startMonitorToolStripMenuItem.Name = "startMonitorToolStripMenuItem";
            startMonitorToolStripMenuItem.ShortcutKeys = Keys.F5;
            startMonitorToolStripMenuItem.Size = new Size(275, 22);
            startMonitorToolStripMenuItem.Text = "&Start monitor";
            startMonitorToolStripMenuItem.Click += startMonitorToolStripMenuItem_Click;
            // 
            // stopMonitorToolStripMenuItem
            // 
            stopMonitorToolStripMenuItem.Name = "stopMonitorToolStripMenuItem";
            stopMonitorToolStripMenuItem.ShortcutKeys = Keys.F6;
            stopMonitorToolStripMenuItem.Size = new Size(275, 22);
            stopMonitorToolStripMenuItem.Text = "S&top monitor";
            stopMonitorToolStripMenuItem.Click += stopMonitorToolStripMenuItem_Click;
            // 
            // cleanNowToolStripMenuItem
            // 
            cleanNowToolStripMenuItem.Name = "cleanNowToolStripMenuItem";
            cleanNowToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Delete;
            cleanNowToolStripMenuItem.Size = new Size(275, 22);
            cleanNowToolStripMenuItem.Text = "&Clean up immediately";
            cleanNowToolStripMenuItem.Click += cleanNowToolStripMenuItem_Click;
            // 
            // statisticToolStripMenuItem
            // 
            statisticToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStatisticalRecordsToolStripMenuItem, clearReacordsToolStripMenuItem });
            statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            statisticToolStripMenuItem.Size = new Size(64, 21);
            statisticToolStripMenuItem.Text = "&Statistic";
            // 
            // viewStatisticalRecordsToolStripMenuItem
            // 
            viewStatisticalRecordsToolStripMenuItem.Name = "viewStatisticalRecordsToolStripMenuItem";
            viewStatisticalRecordsToolStripMenuItem.ShortcutKeys = Keys.F12;
            viewStatisticalRecordsToolStripMenuItem.Size = new Size(246, 22);
            viewStatisticalRecordsToolStripMenuItem.Text = "View statistical records...";
            viewStatisticalRecordsToolStripMenuItem.Click += viewStatisticalRecordsToolStripMenuItem_Click;
            // 
            // clearReacordsToolStripMenuItem
            // 
            clearReacordsToolStripMenuItem.Name = "clearReacordsToolStripMenuItem";
            clearReacordsToolStripMenuItem.Size = new Size(246, 22);
            clearReacordsToolStripMenuItem.Text = "Reset statistical reacords...";
            clearReacordsToolStripMenuItem.Click += clearReacordsToolStripMenuItem_Click;
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openLogDirectoryToolStripMenuItem, viewCurrentLogToolStripMenuItem });
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(42, 21);
            logToolStripMenuItem.Text = "&Log";
            // 
            // openLogDirectoryToolStripMenuItem
            // 
            openLogDirectoryToolStripMenuItem.Name = "openLogDirectoryToolStripMenuItem";
            openLogDirectoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F5;
            openLogDirectoryToolStripMenuItem.Size = new Size(255, 22);
            openLogDirectoryToolStripMenuItem.Text = "&Open Log directory";
            openLogDirectoryToolStripMenuItem.Click += openLogDirectoryToolStripMenuItem_Click;
            // 
            // viewCurrentLogToolStripMenuItem
            // 
            viewCurrentLogToolStripMenuItem.Name = "viewCurrentLogToolStripMenuItem";
            viewCurrentLogToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F5;
            viewCurrentLogToolStripMenuItem.Size = new Size(255, 22);
            viewCurrentLogToolStripMenuItem.Text = "&View current log";
            viewCurrentLogToolStripMenuItem.Click += viewCurrentLogToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maxToolStripMenuItem, minimizeToolStripMenuItem, restoreToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(67, 21);
            windowToolStripMenuItem.Text = "&Window";
            // 
            // maxToolStripMenuItem
            // 
            maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            maxToolStripMenuItem.Size = new Size(166, 22);
            maxToolStripMenuItem.Text = "&Maximize";
            maxToolStripMenuItem.Click += maxToolStripMenuItem_Click;
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(166, 22);
            minimizeToolStripMenuItem.Text = "M&inimize";
            minimizeToolStripMenuItem.Click += minimizeToolStripMenuItem_Click;
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            restoreToolStripMenuItem.Size = new Size(166, 22);
            restoreToolStripMenuItem.Text = "&Restore";
            restoreToolStripMenuItem.Click += restoreToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewDocumentToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 21);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // viewDocumentToolStripMenuItem
            // 
            viewDocumentToolStripMenuItem.Name = "viewDocumentToolStripMenuItem";
            viewDocumentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            viewDocumentToolStripMenuItem.Size = new Size(225, 22);
            viewDocumentToolStripMenuItem.Text = "View &Document...";
            viewDocumentToolStripMenuItem.Click += viewDocumentToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(225, 22);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // checkedListBox_Manifest
            // 
            checkedListBox_Manifest.Dock = DockStyle.Fill;
            checkedListBox_Manifest.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkedListBox_Manifest.FormattingEnabled = true;
            checkedListBox_Manifest.IntegralHeight = false;
            checkedListBox_Manifest.Items.AddRange(new object[] { "ListItem01" });
            checkedListBox_Manifest.Location = new Point(0, 25);
            checkedListBox_Manifest.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_Manifest.Name = "checkedListBox_Manifest";
            checkedListBox_Manifest.Size = new Size(716, 421);
            checkedListBox_Manifest.TabIndex = 2;
            checkedListBox_Manifest.Click += checkedListBox_Manifest_Click;
            checkedListBox_Manifest.EnabledChanged += checkedListBox_Manifest_EnabledChanged;
            // 
            // openFileDialog_OpenMainifest
            // 
            openFileDialog_OpenMainifest.Filter = "QLink Manifest|*.ql-manifest|All files|*.*";
            openFileDialog_OpenMainifest.Title = "Open manifest";
            // 
            // saveFileDialog_SaveManifest
            // 
            saveFileDialog_SaveManifest.Filter = "QLink Manifest|*.ql-manifest";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatus_MonitorStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(716, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_MonitorStatus
            // 
            toolStripStatus_MonitorStatus.Name = "toolStripStatus_MonitorStatus";
            toolStripStatus_MonitorStatus.Size = new Size(131, 17);
            toolStripStatus_MonitorStatus.Text = "toolStripStatusLabel1";
            // 
            // notifyIcon_Main
            // 
            notifyIcon_Main.ContextMenuStrip = contextMenu_Notify;
            notifyIcon_Main.Icon = (Icon)resources.GetObject("notifyIcon_Main.Icon");
            notifyIcon_Main.Text = "QLink Cleaner";
            notifyIcon_Main.Visible = true;
            notifyIcon_Main.MouseDoubleClick += notifyIcon_Main_MouseDoubleClick;
            // 
            // contextMenu_Notify
            // 
            contextMenu_Notify.Items.AddRange(new ToolStripItem[] { showWindowToolStripMenuItem, exitToolStripMenuItem1 });
            contextMenu_Notify.Name = "contextMenu_Notify";
            contextMenu_Notify.Size = new Size(159, 48);
            contextMenu_Notify.DoubleClick += contextMenu_Notify_DoubleClick;
            // 
            // showWindowToolStripMenuItem
            // 
            showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            showWindowToolStripMenuItem.Size = new Size(158, 22);
            showWindowToolStripMenuItem.Text = "&Show Window";
            showWindowToolStripMenuItem.Click += showWindowToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(158, 22);
            exitToolStripMenuItem1.Text = "&Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 446);
            Controls.Add(statusStrip1);
            Controls.Add(checkedListBox_Manifest);
            Controls.Add(menuStrip_MainMenu);
            Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_MainMenu;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(538, 344);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLink Cleaner";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip_MainMenu.ResumeLayout(false);
            menuStrip_MainMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenu_Notify.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_MainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private CheckedListBox checkedListBox_Manifest;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveManifestToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem appConfigureToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem existsedToolStripMenuItem;
        private ToolStripMenuItem nonexistentShortcutToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem maxToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewDocumentToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem behaviorToolStripMenuItem;
        private ToolStripMenuItem startMonitorToolStripMenuItem;
        private ToolStripMenuItem stopMonitorToolStripMenuItem;
        private OpenFileDialog openFileDialog_OpenMainifest;
        private SaveFileDialog saveFileDialog_SaveManifest;
        private ToolStripMenuItem cleanNowToolStripMenuItem;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem openLogDirectoryToolStripMenuItem;
        private ToolStripMenuItem viewCurrentLogToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus_MonitorStatus;
        private NotifyIcon notifyIcon_Main;
        private ContextMenuStrip contextMenu_Notify;
        private ToolStripMenuItem showWindowToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem statisticToolStripMenuItem;
        private ToolStripMenuItem viewStatisticalRecordsToolStripMenuItem;
        private ToolStripMenuItem clearReacordsToolStripMenuItem;
    }
}
