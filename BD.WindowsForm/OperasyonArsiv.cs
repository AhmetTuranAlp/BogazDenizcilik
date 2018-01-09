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
    public partial class OperasyonArsiv : Form
    {
        public OperasyonArsiv()
        {
            InitializeComponent();
        }
        Tools arac = new Tools();
        ArsivIslemleri arsiv = new ArsivIslemleri();
        public void OperasyonArsivListe()
        {
            dataGridView1.DataSource = arsiv.TableListe("spOperasyonArsivListe");
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Toplam Kayıt: " + (dataGridView1.RowCount - 1);
        }

        private void OperasyonArsiv_Load(object sender, EventArgs e)
        {
            OperasyonArsivListe();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = arsiv.ArsivAramaListe(txtAra.Text.ToString());
            arac.DatagridBoyutlandir(dataGridView1, 17);
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
        }
    }
}
