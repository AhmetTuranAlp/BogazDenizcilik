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

        public static string Sayfa;
        private void personelYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa.Sayfa = "Personel";
            Sifre sifre = new Sifre();
            yavruform(sifre);
        }

        private void operasyonTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperasyonTakip operasyon = new OperasyonTakip();
            yavruform(operasyon);
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
    }
}
