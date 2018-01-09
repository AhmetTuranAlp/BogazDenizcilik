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
using static BD.Common.GoogleDriveYukle;

namespace BD.WindowsForm
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public int sayi = 0;

        Tools arac = new Tools();
        SifreIslemleri sifre = new SifreIslemleri();
        VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();

        public void SifreTabloListeleme()
        {
            dtgSifreView.DataSource = sifre.Listeleme();
            arac.DatagridBoyutlandir(dtgSifreView, 3);
        }

        private String GetFileType(string file)
        {
            string extension = Path.GetExtension(file);
            System.Diagnostics.Debug.WriteLine("extension: " + extension);
            string mime;
            switch (extension.ToLower())
            {
                case ".jpg":
                    mime = "image/jpeg";
                    break;
                case ".jpeg":
                    mime = "image/jpeg";
                    break;
                case ".png":
                    mime = "image/png";
                    break;
                case ".doc":
                    mime = "application/msword";
                    break;
                case ".pdf":
                    mime = "application/pdf";
                    break;
                default:
                    mime = "text/plain";
                    break;
            }
            return mime;
        }

        private static string json_secret_file = @".\client_secret.json";
        private static string application_name = @".NET Google Drive Uploader";
        public void GoogleDriveYukle()
        {
            string tarih = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-sss");
            string yol = txtBackup.Text + "\\" + tarih + "_BoğazDenizcilik.bak";
            DriveUploader driveUploader = new DriveUploader(json_secret_file, application_name);
            System.Diagnostics.Debug.WriteLine(yol);
            try
            {
                byte[] byteArray = System.IO.File.ReadAllBytes(yol);
                string filePath = yol;
                string fileName = tarih + "_BoğazDenizcilik.bak";
                string description = tarih + "_BoğazDenizcilik.bak";
                string fileType = GetFileType(filePath);
                driveUploader.UploadFile(ref byteArray, fileName, description, fileType);
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
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

        public void VeritabaniListeleme()
        {
            List<VeritabaniYedekDTO> dbList = new List<VeritabaniYedekDTO>();
            dbList = dbIslem.Listeleme();
            foreach (VeritabaniYedekDTO dbItem in dbList)
            {
                if (File.Exists(dbItem.BackupKonum + "\\" + dbItem.BackupAdi) == false)
                {
                    dbIslem.Sil(dbItem.BackupAdi);
                }
            }
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

        public void BackupAl()
        {
            Tools arac = new Tools();
            if (dbIslem.Backup(txtBackup.Text.ToString()))
            {
              
                if (chkGoogleDriveBackup.Checked == true)
                {
                    if (arac.InternetKontrol())
                    {
                        GoogleDriveYukle();
                        MessageBox.Show("Yedek alma işlemi başarılı bir şekilde alınmıştır. Dosya bilgisayara ve Google Drive Hesabına Kaydedilmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Yedek alma işlemi başarılı bir şekilde alınmıştır. Ancak Internet bağlantısı olmadıgı için dosya Google Drive hesabına Kaydedilmedi.");
                    }
                  
                }
                else
                {
                    MessageBox.Show("Yedek alma işlemi başarılı bir şekilde alınmıştır.");
                }
               
                VeritabaniListeleme();
            }
            else
            {
                MessageBox.Show("Yedek alma işleminde hata oluştu.");
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            pcbBackupLoading.Visible = true;
            lblBackupLoading.Visible = true;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackupAl();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbBackupLoading.Visible = false;
            lblBackupLoading.Visible = false;
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

        public void RestoreYap()
        {
            ArsivIslemleri arsivIslem = new ArsivIslemleri();
            OperasyonIslemleri opeIslem = new OperasyonIslemleri();
            VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();
            List<VeritabaniYedekDTO> dbList = new List<VeritabaniYedekDTO>();
            List<OperasyonModelViewDTO> opeList = new List<OperasyonModelViewDTO>();
            List<ArsivDTO> arsivList = new List<ArsivDTO>();
            arsivList = arsivIslem.ArsivListe();
            opeList = opeIslem.Listeleme();
            dbList = dbIslem.Listeleme();
            if (dbIslem.Restore(txtRestore.Text.ToString()))
            {
                foreach (OperasyonModelViewDTO opeItem in opeList)
                {
                    opeIslem.Ekle_OMV(opeItem);
                }
                foreach (VeritabaniYedekDTO dbItem in dbList)
                {
                    if (!dbIslem.DosyaKontrol(dbItem.BackupAdi))
                    {
                        dbIslem.Ekle(dbItem);
                    }
                   
                }
                arsivIslem.TabloIcerigiSil();
                foreach (ArsivDTO arsivItem in arsivList)
                {
                    arsivIslem.Ekle(arsivItem);
                }
                MessageBox.Show("Veritabanı geri yükleme başarılı olmuştur.");
            }
            else
            {
                MessageBox.Show("Veritabanı geri yükleme işleminde hata oluştu.");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
            pcbRestoreLoading.Visible = true;
            lblRestoreLoading.Visible = true;
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbRestoreLoading.Visible = false;
            lblRestoreLoading.Visible = false;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            RestoreYap();
        }
        string resDosyaAdi;
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

