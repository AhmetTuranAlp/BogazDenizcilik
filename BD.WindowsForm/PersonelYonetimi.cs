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
    public partial class PersonelYonetimi : Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
        }

        PersonelIslemleri per = new PersonelIslemleri();
        EkipIslemleri ekipDto = new EkipIslemleri();

        public void PersonelListe()
        {
            dataGridView1.DataSource = per.PersonelEkipListe(true);
            dataGridView1.Columns["Durum"].Visible = false;
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void GridFont()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8F);
            dataGridViewCellStyle1.Font = new Font(dataGridViewCellStyle1.Font, dataGridViewCellStyle1.Font.Style ^ FontStyle.Bold);
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
        }
        private void PersonelYonetimi_Load(object sender, EventArgs e)
        {
            PersonelListe();
            GridFont();
            cmbEkip.DataSource = ekipDto.Listeleme();
            cmbEkip.DisplayMember = "EkipAdi";
            cmbEkip.ValueMember = "EkipID";
            cmbEkip.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DTO.PersonelDTO perDtoEkle = new PersonelDTO();
            perDtoEkle.Adi = txtAd.Text;
            perDtoEkle.Soyad = txtSoyad.Text;
            perDtoEkle.KartID = txtKartID.Text;
            perDtoEkle.EkipID = (int)cmbEkip.SelectedValue;
            perDtoEkle.Durum = true;
            if (per.Ekle(perDtoEkle))
                MessageBox.Show("Personel Eklendi.");
            else
                MessageBox.Show("Personel ekleme işleminde hata oluştu.");
            PersonelListe();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DTO.PersonelDTO perDtoDuzenle = new PersonelDTO();
            perDtoDuzenle.PersonelID = Convert.ToInt32(txtAd.Tag);
            perDtoDuzenle.Adi = txtAd.Text;
            perDtoDuzenle.Soyad = txtSoyad.Text;
            perDtoDuzenle.KartID = txtKartID.Text;
            perDtoDuzenle.EkipID = (int)cmbEkip.SelectedValue;
            perDtoDuzenle.Durum = true;
            if (per.Duzenle(perDtoDuzenle))
                MessageBox.Show("Personel bilgileri düzenlendi.");
            else
                MessageBox.Show("Personel bilgi düzenleme işleminde hata oluştu.");
            PersonelListe();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Secili Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int perID = (int)dataGridView1.CurrentRow.Cells["PersonelID"].Value;
                per.Sil(perID);
                if (per.Sil(perID))
                    MessageBox.Show("Personel Silinmiştir.");
                else
                    MessageBox.Show("Personel silme işleminde hata oluştu.");
                PersonelListe();
            }
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Secili Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int perID = (int)dataGridView1.CurrentRow.Cells["PersonelID"].Value;
                per.Sil(perID);
                if (per.Sil(perID))
                    MessageBox.Show("Personel Silinmiştir.");
                else
                    MessageBox.Show("Personel silme işleminde hata oluştu.");
                PersonelListe();
            }
        }

        private void bilgileriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                txtAd.Text = row.Cells["Adi"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtKartID.Text = row.Cells["KartID"].Value.ToString();
                cmbEkip.Text = "";
                cmbEkip.Text = row.Cells["EkipAdi"].Value.ToString();
                txtAd.Tag = row.Cells["PersonelID"].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Aktarma İşleminde Hata Oluştu.");
            }
        }

        private void ayrılmışPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = per.PersonelEkipListe(false);
            dataGridView1.Columns["Durum"].Visible = false;
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void aktifPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListe();
        }

        private void ekipsizPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = per.EkipsizPersonelListesi();
            dataGridView1.Columns["Durum"].Visible = false;
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
