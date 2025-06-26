namespace QLinkCleaner
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            labelStatisticInfo = new Label();
            buttonClose = new Button();
            buttonCopyToClipboard = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelStatisticInfo
            // 
            labelStatisticInfo.AutoSize = true;
            labelStatisticInfo.Location = new Point(12, 56);
            labelStatisticInfo.Name = "labelStatisticInfo";
            labelStatisticInfo.Size = new Size(31, 17);
            labelStatisticInfo.TabIndex = 0;
            labelStatisticInfo.Text = "N/A";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(225, 148);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(126, 30);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "&Confirm";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonCopyToClipboard
            // 
            buttonCopyToClipboard.Location = new Point(93, 148);
            buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            buttonCopyToClipboard.Size = new Size(126, 30);
            buttonCopyToClipboard.TabIndex = 2;
            buttonCopyToClipboard.Text = "Co&py to clipboard";
            buttonCopyToClipboard.UseVisualStyleBackColor = true;
            buttonCopyToClipboard.Click += buttonCopyToClipboard_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 47);
            label1.TabIndex = 3;
            label1.Text = "This displays the statistical information of all interception records of the application.\r\n";
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 190);
            Controls.Add(label1);
            Controls.Add(buttonCopyToClipboard);
            Controls.Add(buttonClose);
            Controls.Add(labelStatisticInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StatisticForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStatisticInfo;
        private Button buttonClose;
        private Button buttonCopyToClipboard;
        private Label label1;
    }
}