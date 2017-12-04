using BD.Common;
using BD.Data;
using BD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        SifreIslemleri sifre = new SifreIslemleri();

        public void CihazListeleme()
        {
            dataGridView1.DataSource = cihaz.Listeleme();
            arac.DatagridBoyutlandir(dataGridView1, 6);

        }

        public void SifreTabloListeleme()
        {
            dtgSifreView.DataSource = sifre.Listeleme();
            arac.DatagridBoyutlandir(dtgSifreView, 3);
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
            SifreTabloListeleme();
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
                ch.CihazID = (int)txtCihazAd.Tag;
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var alan1 = textBox1.Text;
            var alan2 = textBox2.Text;
            if (alan1 == "" && alan2 == "")
            {
                MessageBox.Show("Boş Değer Girilemez.");
            }
            else
            {
                if (alan1 == alan2)
                {
                    sifre.SifreGuncelle(alan1.ToString());
                    MessageBox.Show("Şifre Değiştirildi.");
                    SifreTabloListeleme();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Degil!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        //C:\--Özellikler--Güvenlik--Düzenle--Kullanıcı Sec--Yazma=Yetki Ver.
        private void btnBackupKonum_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }
        
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string tarih = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-sss");
                string connectionString1 = ("data source=.;initial catalog=ProjeB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                SqlConnection cn = new SqlConnection(connectionString1);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = @"BACKUP DATABASE ProjeB TO DISK ='" + txtBackup.Text + "\\" + tarih + "_BoğazDenizcilik.bak'";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                reader = cmd.ExecuteReader();
                cn.Close();
                MessageBox.Show("Database Backup Successfull.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnResoreKonum_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString1 = ("data source=.;initial catalog=ProjeB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                SqlConnection cn = new SqlConnection(connectionString1);
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = @"use master; RESTORE DATABASE ProjeB FROM DISK = '" + textBox2.Text + "'WITH REPLACE;";
                cmd.CommandText = "DBCC CHECKDB ('ProjeB')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                reader = cmd.ExecuteReader();
                cn.Close();
                MessageBox.Show("Database Restored Successfull.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

