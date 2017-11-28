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
    public partial class SorunKontrol : Form
    {
        public SorunKontrol()
        {
            InitializeComponent();
        }
        OperasyonIslemleri operasyon = new OperasyonIslemleri();
        PersonelIslemleri personel = new PersonelIslemleri();
        SorunKontrolIslemleri sorunIslem = new SorunKontrolIslemleri();
        Tools arac = new Tools();

        public void OperasyonListeleme()
        {
            dataGridView1.DataSource = sorunIslem.OperasyonListeleme();
            dataGridView1.Columns["SorunDurum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView1, 15);
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
        }

        public void CmbPersonel()
        {
            List<DTO.PersonelEkipModelViewDTO> liste = new List<DTO.PersonelEkipModelViewDTO>();
            liste = personel.PersonelEkipListe(true);
            foreach (var item in liste)
            {
                if (item.KartID.ToString() != "Ayrılmış Personel")
                {
                    cmbPersonel.Items.Add(item.Adi + " " + item.Soyad);
                }
            }
        }

        private void SorunKontrol_Load(object sender, EventArgs e)
        {
            OperasyonListeleme();
            CmbPersonel();
        }

        private void barkodAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                txtBarkod.Text = row.Cells["Barkod"].Value.ToString();
                cmbPersonel.Text = row.Cells["Adi"].Value.ToString() + " " + row.Cells["Soyad"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Aktarma İşleminde Hata Oluştu.");
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && cmbPersonel.Text != "" && txtAciklama.Text != "")
            {
                SorunlarDTO sorun = new SorunlarDTO();
                sorun.Barkod = txtBarkod.Text;
                sorun.PersonelID = personel.PersonelId(cmbPersonel.Text.ToString());
                sorun.Aciklama = txtAciklama.Text;
                sorun.Zaman = operasyon.Zaman(txtBarkod.Text.ToString());
                if (sorunIslem.Ekle(sorun))
                    MessageBox.Show("Kayıt Eklendi.");
                else
                    MessageBox.Show("Kayıt ekleme işleminde hata oluştu.");
                OperasyonListeleme();
            }
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            dataGridView1.DataSource = sorunIslem.OperasyonAramaListe(ara);
            dataGridView1.Columns["SorunDurum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView1, 15);
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            OperasyonListeleme();
        }
    }
}
