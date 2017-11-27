using BD.Data;
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
    public partial class FtpDosyaAktarimi : Form
    {
        public FtpDosyaAktarimi()
        {
            InitializeComponent();
        }

        FTPIslemleri ftp = new FTPIslemleri();

        private void FtpDosyaAktarimi_Load(object sender, EventArgs e)
        {

        }
    }
}
