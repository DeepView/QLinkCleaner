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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(IWin32Window owner, Statistic statistic)
        {
            labelStatisticInfo.Text = statistic.ToString();
            return ShowDialog(owner);
        }

        private static void CopyToClipboard(string val) => Clipboard.SetText(val);

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            CopyToClipboard(labelStatisticInfo.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
