using BD.Common;
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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        CihazIslemleri cihaz = new CihazIslemleri();
        Tools arac = new Tools();
        public void CihazListeleme()
        {
            dataGridView1.DataSource = cihaz.Listeleme();
            arac.DatagridBoyutlandir(dataGridView1, 6);

        }

        public void FtpTextClear()
        {
            txtCihazAd.Clear();
            txtFtpAdres.Clear();
            txtFtpPas.Clear();
            txtFtpPort.Clear();
            txtFtpUser.Clear();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            CihazListeleme();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtCihazAd.Text != "" && txtFtpAdres.Text != "" && txtFtpUser.Text != "" && txtFtpPas.Text != "" && txtFtpPort.Text != "")
            {
                CihazDTO ch = new CihazDTO();
                ch.CihazAdi = txtCihazAd.Text;
                ch.FtpAdres = txtFtpAdres.Text;
                ch.FtpUser = txtFtpUser.Text;
                ch.FtpPas = txtFtpPas.Text;
                ch.ftpPort = Convert.ToInt32(txtFtpPort.Text);
                if (cihaz.Ekle(ch))
                    MessageBox.Show("Cihaz Eklendi.");
                else
                    MessageBox.Show("Cihaz ekleme işleminde hata oluştu.");
                CihazListeleme();
                FtpTextClear();
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurmanız Gerekiyor.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtCihazAd.Tag != null)
            {
                CihazDTO ch = new CihazDTO();
                ch.CihazID= (int)txtCihazAd.Tag;
                ch.CihazAdi = txtCihazAd.Text;
                ch.FtpAdres = txtFtpAdres.Text;
                ch.FtpUser = txtFtpUser.Text;
                ch.FtpPas = txtFtpPas.Text;
                ch.ftpPort = Convert.ToInt32(txtFtpPort.Text);
                if (cihaz.Duzenle(ch))
                    MessageBox.Show("Cihaz bilgileri düzenlendi.");
                else
                    MessageBox.Show("Cihaz düzenleme işleminde hata oluştu.");
                CihazListeleme();
                FtpTextClear();
            }
            else
            {
                MessageBox.Show("Bos deger girmeyin");
            }
        }

        private void bilgileriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                txtCihazAd.Text = row.Cells["CihazAdi"].Value.ToString();
                txtFtpAdres.Text = row.Cells["FtpAdres"].Value.ToString();
                txtFtpUser.Text = row.Cells["FtpUser"].Value.ToString();
                txtFtpPas.Text = row.Cells["FtpPas"].Value.ToString();
                txtFtpPort.Text = row.Cells["ftpPort"].Value.ToString();
                txtCihazAd.Tag = row.Cells["CihazID"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CihazSilme()
        {
            DialogResult sonuc = MessageBox.Show("Secili Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int cihazID = (int)dataGridView1.CurrentRow.Cells["CihazID"].Value;
                if (cihaz.Sil(cihazID))
                    MessageBox.Show("Cihaz Silinmiştir.");
                else
                    MessageBox.Show("Cihaz silme işleminde hata oluştu.");
                CihazListeleme();
                FtpTextClear();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CihazSilme();
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CihazSilme();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            dataGridView1.DataSource = cihaz.CihazListeArama(ara);
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEkle, "Cihaz Ekle");
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuncelle, "Cihaz Düzenle");
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuncelle, "Cihaz Sil");
        }
    }
}
