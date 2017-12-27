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
    public partial class HataliKayitAktarimi : Form
    {
        public HataliKayitAktarimi()
        {
            InitializeComponent();
        }

        private void HataliKayitAktarimi_Load(object sender, EventArgs e)
        {
          
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            label1.Text = "Hatalı Operasyon Kayıtları Kontrol Ediliyor.";
               FTPIslemleri ftp = new FTPIslemleri();
            ftp.XmlKaydet(progressBar1, @"\XmlHata\");
            this.Close();
        }
    }
}
