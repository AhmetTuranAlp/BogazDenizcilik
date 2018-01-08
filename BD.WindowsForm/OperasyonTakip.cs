using BD.Common;
using BD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.WindowsForm
{
    public partial class OperasyonTakip : Form
    {
        public OperasyonTakip()
        {
            InitializeComponent();
        }

        OperasyonIslemleri operasyon = new OperasyonIslemleri();
        Tools arac = new Tools();

        public void OperasyonListeleme()
        {
            dataGridView1.DataSource = operasyon.TableListe("spOperasyonListe");
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Toplam Kayıt: " + (dataGridView1.RowCount - 1);
        }

        private void OperasyonTakip_Load(object sender, EventArgs e)
        {
            OperasyonListeleme();
        }
        
        private void aramaKutusunaBarkodAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtAra.Text = row.Cells["Barkod"].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operasyon.OperasyonAramaListe(txtAra.Text.ToString());
            arac.DatagridBoyutlandir(dataGridView1, 16);
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
        }
    }
}
