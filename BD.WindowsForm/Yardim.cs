using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.WindowsForm
{
    public partial class Yardim : Form
    {
        public Yardim()
        {
            InitializeComponent();
        }

        private void pcbTeamviewer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.teamviewer.com/tr/download/windows");
        }

        private void pcbAlpemix_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.alpemix.com/site/download.asp?durum=download");
        }

        private void pcbAnydesk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://anydesk.com/tr/download");
        }
    }
}
