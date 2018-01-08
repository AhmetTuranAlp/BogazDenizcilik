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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public void yavruform(Form yavru)
        {
            try
            {
                bool durum = false;
                foreach (Form eleman in this.MdiChildren)
                {
                    if (eleman.Text == yavru.Text)
                    {
                        durum = true;
                        eleman.Activate();
                    }
                    else
                    {
                        eleman.Close();
                    }
                }
                if (durum == false)
                {
                    yavru.MdiParent = this;
                    yavru.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string Sayfa;
        private void personelYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa.Sayfa = "Personel";
            Sifre sifre = new Sifre();
            yavruform(sifre);
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardim yardim = new Yardim();
            yavruform(yardim);
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa.Sayfa = "Ayarlar";
            Sifre sifre = new Sifre();
            yavruform(sifre);
        }

        private void sorunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa.Sayfa = "Sorunlar";
            Sifre sifre = new Sifre();
            yavruform(sifre);
        }

        private void rapolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            yavruform(rapor);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Programdan Çıkış Yapmak İstiyor musunuz?", "Programdan Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void elTerminaldenAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FtpDosyaAktarimi ftp = new FtpDosyaAktarimi();
            yavruform(ftp);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void operasyonSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperasyonTakip operasyon = new OperasyonTakip();
            yavruform(operasyon);
        }

        private void operasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperasyonEkle operasyonEkle = new OperasyonEkle();
            yavruform(operasyonEkle);
        }

        private void hatalıKayıtlarıKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HataliKayitAktarimi hata = new HataliKayitAktarimi();
            yavruform(hata);
        }

        private void kayıtlarıAvşivleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           KayıtlariArsivle arsiv = new KayıtlariArsivle();
            yavruform(arsiv);
        }

        private void arşivlenmişKayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperasyonArsiv opeArsiv = new OperasyonArsiv();
            yavruform(opeArsiv);
        }
    }
}
