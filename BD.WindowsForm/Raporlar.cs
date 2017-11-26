using BD.Common;
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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }


        OperasyonIslemleri operasyon = new OperasyonIslemleri();
        Tools arac = new Tools();
        PersonelIslemleri personel = new PersonelIslemleri();
        EkipIslemleri ekip = new EkipIslemleri();

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operasyon.Listeleme();
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Operasyon Adet: " + dataGridView1.RowCount;
        }

        public void TwoDtp()
        {
            lblPersonelCalisma.Visible = false;
            dtpCalismaTarih.Visible = false;

            lblBaslangic.Visible = true;
            dtpBaslangic.Visible = true;

            lblBitis.Visible = true;
            dtpBitis.Visible = true;
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTur.SelectedItem.ToString() == "Personel Raporu")
            {
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                cmbSecimIcerik.Items.Add("Genel Rapor");
                var perso = personel.PersonelListe();
                foreach (var per in perso)
                {
                    cmbSecimIcerik.Items.Add(per.Adi + " " + per.Soyad);
                }
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
                foreach (var item in perso)
                {
                    veri.Add(item.Adi + " " + item.Soyad);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veri;
            }
            else if (cmbTur.SelectedItem.ToString() == "Operasyon Raporu")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                cmbSecimIcerik.AutoCompleteCustomSource = null;
                cmbSecimIcerik.Items.Add("Yükleme");
                cmbSecimIcerik.Items.Add("Tahliye");
                cmbSecimIcerik.Items.Add("Terminal");
            }
            else if (cmbTur.SelectedItem.ToString() == "Performans(Personel)")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                var perso = personel.PersonelListe();
                cmbSecimIcerik.Items.Add("Genel Performans");
                foreach (var per in perso)
                {
                    cmbSecimIcerik.Items.Add(per.Adi + " " + per.Soyad);
                }
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
                foreach (var item in perso)
                {
                    veri.Add(item.Adi + " " + item.Soyad);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veri;
            }
            else if (cmbTur.SelectedItem.ToString() == "Performans(Ekip)")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                var ek = ekip.Listeleme();
                cmbSecimIcerik.Items.Add("Genel Performans");
                foreach (var item in ek)
                {
                    cmbSecimIcerik.Items.Add(item.EkipAdi);
                }
                AutoCompleteStringCollection veriEkip = new AutoCompleteStringCollection();
                foreach (var item in ek)
                {
                    veriEkip.Add(item.EkipAdi);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veriEkip;
            }
            else if (cmbTur.SelectedItem.ToString() == "Operasyon Sorun Raporu")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = false;
            }
        }

        private void cmbSecimIcerik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTur.SelectedItem.ToString() == "Personel Raporu")
                {
                    if (cmbSecimIcerik.SelectedItem.ToString() == "Genel Rapor")
                    {
                        TwoDtp();
                    }
                    else
                    {
                        lblPersonelCalisma.Visible = true;
                        dtpCalismaTarih.Visible = true;

                        lblBaslangic.Visible = false;
                        dtpBaslangic.Visible = false;

                        lblBitis.Visible = false;
                        dtpBitis.Visible = false;

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
