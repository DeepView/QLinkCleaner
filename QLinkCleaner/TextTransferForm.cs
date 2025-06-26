using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLinkCleaner
{
    public partial class TextTransferForm : Form
    {
        private string _textboxContent;
        public string TextboxContent
        {
            get => _textboxContent;
            set => _textboxContent = value;
        }
        public TextTransferForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            TextboxContent = textBox_TextTransfer.Text;
            DialogResult = DialogResult.OK;
        }

        private void TextTransferForm_Load(object sender, EventArgs e)
        {
            textBox_TextTransfer.Text = TextboxContent;
        }
    }
}
