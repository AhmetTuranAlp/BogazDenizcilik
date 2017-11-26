using BD.Common;
using BD.Data;
using BD.DTO;
using Microsoft.VisualBasic;
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
        EkipIslemleri ekip = new EkipIslemleri();
        Tools arac = new Tools();
        public void PersonelListe()
        {
            dataGridView1.DataSource = per.PersonelEkipListe(true);
            dataGridView1.Columns["Durum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView1, 5);
        }

        public void EkipListe()
        {
            var liste = ekip.Listeleme();
            List<DTO.EkiplerDTO> lst = new List<DTO.EkiplerDTO>();
            lst.Add(liste.FirstOrDefault(x => x.EkipID == 16));
            foreach (var item in liste)
            {
                if (item.EkipID != 16)
                {
                    lst.Add(item);
                }
            }
            dataGridView2.DataSource = lst;
            dataGridView2.Columns["Durum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView2, 3);
        }

        public void GridFont()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8F);
            dataGridViewCellStyle1.Font = new Font(dataGridViewCellStyle1.Font, dataGridViewCellStyle1.Font.Style ^ FontStyle.Bold);
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
        }

        private void PersonelYonetimi_Load(object sender, EventArgs e)
        {
            EkipListe();
            PersonelListe();
            GridFont();
            cmbEkip.DataSource = ekip.Listeleme();
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

        public void KayitSil()
        {
            DialogResult sonuc = MessageBox.Show("Secili Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int perID = (int)dataGridView1.CurrentRow.Cells["PersonelID"].Value;
                if (per.Sil(perID))
                    MessageBox.Show("Personel Silinmiştir.");
                else
                    MessageBox.Show("Personel silme işleminde hata oluştu.");
                PersonelListe();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitSil();
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
            arac.DatagridBoyutlandir(dataGridView1, 5);
        }

        private void aktifPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListe();
        }

        private void ekipsizPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = per.EkipsizPersonelListesi();
            dataGridView1.Columns["Durum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView1, 5);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = per.PersonelAramaListe(txtAra.Text.ToString());
            dataGridView1.Columns["Durum"].Visible = false;
            arac.DatagridBoyutlandir(dataGridView1, 5);
        }

        private void btnEkipEkle_Click(object sender, EventArgs e)
        {
            string ekipEkle = Interaction.InputBox("Ekip Adını Giriniz", "Ekip Ekle", "", 300, 100);
            string ekipAd = ekipEkle;
            if (ekipEkle != "")
            {
                DTO.EkiplerDTO ek = new DTO.EkiplerDTO();
                ek.EkipAdi = ekipAd;
                ek.Durum = true;
                if (ekip.Ekle(ek))
                    MessageBox.Show("Ekip ekleme işlemi başarılı");
                else
                    MessageBox.Show("Ekip ekleme işleminde hata oluştu.");
                EkipListe();
            }
            else
            {
                MessageBox.Show("Ekip Adı Giriniz.");
            }
        }

        private void btnEkipDuzenle_Click(object sender, EventArgs e)
        {
            string ekipDuzenle = Interaction.InputBox("Yeni Ekip Adını Giriniz", "Ekip Güncelle", dataGridView2.CurrentRow.Cells["EkipAdi"].Value.ToString(), 300, 100);
            string ekipAd = ekipDuzenle;
            int ekipId = (int)dataGridView2.CurrentRow.Cells["EkipID"].Value;
            if (ekipDuzenle != "")
            {
                DTO.EkiplerDTO ek = new DTO.EkiplerDTO();
                ek.EkipID = ekipId;
                ek.EkipAdi = ekipAd;
                if (ekip.Duzenle(ek))
                    MessageBox.Show("Ekip düzenleme işlemi başarılı");
                else
                    MessageBox.Show("Ekip düzenleme işleminde hata oluştu.");
                EkipListe();
            }
            else
            {
                MessageBox.Show("Ekip Adı Giriniz.");
            }
        }

        private void btnEkipSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Secili Kayıt Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int ekiID = (int)dataGridView2.CurrentRow.Cells["EkipID"].Value;
                if (ekip.Sil(ekiID))
                    MessageBox.Show("Ekip silme işlemi başarılı");
                else
                    MessageBox.Show("Ekip silme işleminde hata oluştu.");
                EkipListe();
                PersonelListe();
            }
        }

        private void txtEkipAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtEkipAra.Text;
            dataGridView2.DataSource = ekip.EkipListeArama(ara);
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEkle, "Personel Ekle");
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuncelle, "Personel Düzenle");
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSil, "Personel Sil");
        }

        private void btnEkipEkle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEkipEkle, "Ekip Ekleme");
        }

        private void btnEkipDuzenle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEkipDuzenle, "Ekip Düzenleme");
        }

        private void btnEkipSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEkipSil, "Ekip Sil");
        }
    }
}
