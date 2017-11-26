using BD.Data;
using BD.DTO;
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
    public partial class Sifre : Form
    {
        public Sifre()
        {
            InitializeComponent();
        }

        SifreIslemleri sifre = new SifreIslemleri();

        public void SifreAl()
        {
            if (sifre.SifreGiris(txtSifre.Text.ToString()))
            {
                if (Anasayfa.Sayfa.ToString() == "Ayarlar")
                {
                    SifreGirisZamanalarıDTO sfr = new SifreGirisZamanalarıDTO();
                    sfr.ErisilenSayfa = "Ayarlar";
                    sfr.GirisZamani = DateTime.Now;
                    sifre.Ekle(sfr);
                    Ayarlar Ayarlar = new Ayarlar();
                    this.Close();
                    Ayarlar.Show();
                }
                else if (Anasayfa.Sayfa.ToString() == "Personel")
                {
                    SifreGirisZamanalarıDTO sfr = new SifreGirisZamanalarıDTO();
                    sfr.ErisilenSayfa = "Personel Yönetimi";
                    sfr.GirisZamani = DateTime.Now;
                    sifre.Ekle(sfr);
                    PersonelYonetimi Personel = new PersonelYonetimi();
                    this.Close();
                    Personel.Show();
                }
                else if (Anasayfa.Sayfa.ToString() == "Sorunlar")
                {
                    SifreGirisZamanalarıDTO sfr = new SifreGirisZamanalarıDTO();
                    sfr.ErisilenSayfa = "Sorunlar";
                    sfr.GirisZamani = DateTime.Now;
                    SorunKontrol Sorunlar = new SorunKontrol();
                    this.Close();
                    Sorunlar.Show();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girdiniz.");
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            SifreAl();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SifreAl();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
