namespace QLinkCleaner
{
    partial class AppConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppConfigForm));
            checkBox_RunMonitoringWhenStartingApp = new CheckBox();
            checkBox_FollowSystemStartup = new CheckBox();
            checkBox_CleanNowWhenStartingApp = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkBox_RunMonitoringWhenStartingApp
            // 
            checkBox_RunMonitoringWhenStartingApp.AutoSize = true;
            checkBox_RunMonitoringWhenStartingApp.Location = new Point(12, 75);
            checkBox_RunMonitoringWhenStartingApp.Name = "checkBox_RunMonitoringWhenStartingApp";
            checkBox_RunMonitoringWhenStartingApp.Size = new Size(367, 21);
            checkBox_RunMonitoringWhenStartingApp.TabIndex = 0;
            checkBox_RunMonitoringWhenStartingApp.Text = "Run the monitor immediately after starting the application.";
            checkBox_RunMonitoringWhenStartingApp.UseVisualStyleBackColor = true;
            // 
            // checkBox_FollowSystemStartup
            // 
            checkBox_FollowSystemStartup.AutoSize = true;
            checkBox_FollowSystemStartup.Location = new Point(12, 48);
            checkBox_FollowSystemStartup.Name = "checkBox_FollowSystemStartup";
            checkBox_FollowSystemStartup.Size = new Size(309, 21);
            checkBox_FollowSystemStartup.TabIndex = 1;
            checkBox_FollowSystemStartup.Text = "The application starts with the operating system.";
            checkBox_FollowSystemStartup.UseVisualStyleBackColor = true;
            // 
            // checkBox_CleanNowWhenStartingApp
            // 
            checkBox_CleanNowWhenStartingApp.AutoSize = true;
            checkBox_CleanNowWhenStartingApp.Location = new Point(12, 102);
            checkBox_CleanNowWhenStartingApp.Name = "checkBox_CleanNowWhenStartingApp";
            checkBox_CleanNowWhenStartingApp.Size = new Size(430, 21);
            checkBox_CleanNowWhenStartingApp.TabIndex = 2;
            checkBox_CleanNowWhenStartingApp.Text = "Immediately perform cleaning actions after launching the application.";
            checkBox_CleanNowWhenStartingApp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(380, 158);
            button1.Name = "button1";
            button1.Size = new Size(122, 32);
            button1.TabIndex = 3;
            button1.Text = "&Close Window";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 17);
            label1.TabIndex = 4;
            label1.Text = "You can modify these settings below, don't worry, they will be automatically saved.";
            // 
            // AppConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 202);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkBox_CleanNowWhenStartingApp);
            Controls.Add(checkBox_FollowSystemStartup);
            Controls.Add(checkBox_RunMonitoringWhenStartingApp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppConfigForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "App Configure";
            Load += AppConfigForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_RunMonitoringWhenStartingApp;
        private CheckBox checkBox_FollowSystemStartup;
        private CheckBox checkBox_CleanNowWhenStartingApp;
        private Button button1;
        private Label label1;
    }
}