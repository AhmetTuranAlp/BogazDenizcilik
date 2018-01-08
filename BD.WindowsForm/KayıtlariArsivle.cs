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
    public partial class KayıtlariArsivle : Form
    {
        public KayıtlariArsivle()
        {
            InitializeComponent();
        }

        private void btnArsiveAktar_Click(object sender, EventArgs e)
        {
            ArsivIslemleri arsivIslem = new ArsivIslemleri();
            if (arsivIslem.Arsiv(progressBar1))
            {
                MessageBox.Show("Dosyalar Arşiv'e Taşındı.");
            }
            else
            {
                MessageBox.Show("Dosya Taşıma İşlemi Gerçekleşmedi. Arşivlenecek Kayıt Yok veya Taşıma İşleminde Hata Oluştu.");
            }
            this.Close();
        }
    }
}
