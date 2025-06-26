namespace QLinkCleaner
{
    partial class TextTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextTransferForm));
            textBox_TextTransfer = new TextBox();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBox_TextTransfer
            // 
            textBox_TextTransfer.Location = new Point(12, 12);
            textBox_TextTransfer.Name = "textBox_TextTransfer";
            textBox_TextTransfer.Size = new Size(377, 23);
            textBox_TextTransfer.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(301, 118);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(88, 31);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "C&onfirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(207, 118);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 31);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // TextTransferForm
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(401, 161);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(textBox_TextTransfer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TextTransferForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += TextTransferForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_TextTransfer;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}