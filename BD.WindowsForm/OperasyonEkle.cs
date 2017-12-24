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
    public partial class OperasyonEkle : Form
    {
        public OperasyonEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelIslemleri per = new PersonelIslemleri();
            OperasyonIslemleri ope = new OperasyonIslemleri();
            OperasyonDTO o = new OperasyonDTO();
            DTO.PersonelDTO GelenPersonel = new DTO.PersonelDTO();
            GelenPersonel = per.TekPersonel(cmbKartID.SelectedItem.ToString());
            o.Barkod = txtBarkod.Text;
            o.PersonelID = GelenPersonel.PersonelID;
            o.EkipID = GelenPersonel.EkipID;
            o.Tip = cmbTip.SelectedItem.ToString();
            o.Zaman = DTPZaman.Value;

            if (chkSorunYok.Checked == true)
            {
                chkAnahtarKaybi.Enabled = false;
                o.AnahtarKaybi = false;
                chkAracHasar.Enabled = false;
                o.AracHasar = false;
                chkCamAcik.Enabled = false;
                o.CamAcik = false;
                chkDiger.Enabled = false;
                o.Diger = false;
                chkElfrenKonum.Enabled = false;
                o.ElfrenKonum = false;
                chkVitesKonum.Enabled = false;
                o.VitesKonum = false;
                o.SorunYok = true;
                o.SorunDurum = false;
            }
            else if (chkSorunYok.Checked == false)
            {
                chkAnahtarKaybi.Enabled = true;
                if (chkAnahtarKaybi.Checked == true)
                    o.AnahtarKaybi = true;
                else
                    o.AnahtarKaybi = false;


                chkAracHasar.Enabled = true;
                if (chkAracHasar.Checked == true)
                    o.AracHasar = true;
                else
                    o.AracHasar = false;



                chkCamAcik.Enabled = true;
                if (chkCamAcik.Checked == true)
                    o.CamAcik = true;
                else
                    o.CamAcik = false;

                chkDiger.Enabled = true;
                if (chkDiger.Checked == true)
                    o.Diger = true;
                else
                    o.Diger = false;


                chkVitesKonum.Enabled = true;
                if (chkVitesKonum.Checked == true)
                    o.VitesKonum = true;
                else
                    o.VitesKonum = false;


                chkElfrenKonum.Enabled = true;
                if (chkElfrenKonum.Checked == true)
                    o.ElfrenKonum = true;
                else
                    o.ElfrenKonum = false;


                o.SorunYok = false;
                o.SorunDurum = true;
            }
            ope.Ekle(o);
            MessageBox.Show("Operasyon Eklendi.");
        }

        private void OperasyonEkle_Load(object sender, EventArgs e)
        {
            PersonelIslemleri personel = new PersonelIslemleri();
            var perso = personel.PersonelListe();

            foreach (var item in perso)
            {
                cmbKartID.Items.Add(item.KartID);
            }

            AutoCompleteStringCollection veriKart = new AutoCompleteStringCollection();
            foreach (var item in perso)
            {
                veriKart.Add(item.KartID);
            }
            cmbKartID.AutoCompleteCustomSource = veriKart;


    
        }

        private void chkSorunYok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSorunYok.Checked == true)
            {
                chkAnahtarKaybi.Enabled = false;
                chkAracHasar.Enabled = false;
                chkCamAcik.Enabled = false;
                chkDiger.Enabled = false;
                chkElfrenKonum.Enabled = false;
                chkVitesKonum.Enabled = false;
            }
            else
            {
                chkAnahtarKaybi.Enabled = true;
                chkAracHasar.Enabled = true;
                chkCamAcik.Enabled = true;
                chkDiger.Enabled = true;
                chkElfrenKonum.Enabled = true;
                chkVitesKonum.Enabled = true;
            }
        }
    }
}
