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
        
        Tools arac = new Tools();
        SifreIslemleri sifre = new SifreIslemleri();
        VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();
        
        public void SifreTabloListeleme()
        {
            dtgSifreView.DataSource = sifre.Listeleme();
            arac.DatagridBoyutlandir(dtgSifreView, 3);
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            SifreTabloListeleme();
            VeritabaniListeleme();
        }

    
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

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
        //ConnectionString otomatik olarak cek

        public void VeritabaniListeleme()
        {
            dataGridView2.DataSource = dbIslem.Listeleme();
            arac.DatagridBoyutlandir(dataGridView2, 3);
        }

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

                VeritabaniYedekDTO backup = new VeritabaniYedekDTO();
                backup.BackupAdi = tarih + "_BoğazDenizcilik.bak";
                backup.BackupKonum = txtBackup.Text;
                dbIslem.Ekle(backup);
                VeritabaniListeleme();
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

        string resDosyaAdi;
        private void btnRestore_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =.; initial catalog = ProjeB; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework";

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE ProjeB SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE ProjeB FROM DISK='" + txtRestore.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE ProjeB SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Veritabanı başarılı bir şekilde yüklenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void konumAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView2.CurrentRow;
                string adi = row.Cells["BackupAdi"].Value.ToString();
                string konum = row.Cells["BackupKonum"].Value.ToString();
                txtRestore.Text = konum + "\\" + adi;
                resDosyaAdi = adi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

