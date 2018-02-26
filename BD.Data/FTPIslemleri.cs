using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BD.Data
{
    public class FTPIslemleri
    {

        PersonelIslemleri Personel = new PersonelIslemleri();
        OperasyonIslemleri Operasyon = new OperasyonIslemleri();

        public DTO.FtpServerDTO FtpServer()
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.FtpServer.Select(x => new DTO.FtpServerDTO()
                    {
                        ServerID = x.ServerID,
                        FtpUser = x.FtpUser,
                        FtpPass = x.FtpPass,
                        FtpPort = x.FtpPort
                    }).FirstOrDefault(x => x.ServerID == 1);
                }
            }
            catch (Exception)
            {
                return new DTO.FtpServerDTO();
            }

        }

        public void Listeleme(string klasor, List<string> liste)
        {
            string path = Application.StartupPath + klasor;
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] rgFiles = di.GetFiles();
            foreach (FileInfo fi in rgFiles)
            {
                liste.Add(fi.Name);
            }
        }

        public void XmlKaydet(ProgressBar bar, string klasor)
        {
            List<string> dataKloser = new List<string>();
            Listeleme(klasor, dataKloser);

            int dosyaSayisi = Directory.GetFiles(Application.StartupPath + klasor, "*.*", SearchOption.AllDirectories).Length;
            bar.Minimum = 0;
            bar.Maximum = dosyaSayisi;
            bar.Step = 1;

            int sayac = 0;

            if (!Directory.Exists(Application.StartupPath + @"\XmlBackup"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\XmlBackup");
            }


            if (!Directory.Exists(Application.StartupPath + @"\XmlHata"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\XmlHata");
            }


            List<string> HataPersonelListe = new List<string>();
            foreach (string data in dataKloser)
            {

                DTO.PersonelDTO GelenPersonel = new DTO.PersonelDTO();
                DTO.OperasyonDTO o = new DTO.OperasyonDTO();
                XmlDocument doc = new XmlDocument();
                doc.Load((Application.StartupPath + klasor + data));
                XmlNode operasyon = doc.SelectSingleNode("operasyon");
                string kartID = operasyon.SelectSingleNode("Personel").InnerText.Trim();
                try
                {
                    GelenPersonel = Personel.TekPersonel(kartID);
                    o.PersonelID = GelenPersonel.PersonelID;
                    o.EkipID = GelenPersonel.EkipID;
                    o.Barkod = operasyon.SelectSingleNode("Barkod").InnerText.ToString();
                    o.Tip = operasyon.SelectSingleNode("Tip").InnerText.ToString();
                    o.Zaman = Convert.ToDateTime(operasyon.SelectSingleNode("Zaman").InnerText);
                    o.AnahtarKaybi = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("AnahtarKaybi").InnerText));
                    o.AracHasar = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("AracHasar").InnerText));
                    o.CamAcik = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("CamAcik").InnerText));
                    o.VitesKonum = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("VitesKonum").InnerText));
                    o.ElfrenKonum = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("ElfrenKonum").InnerText));
                    o.Diger = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("Diger").InnerText));
                    o.SorunYok = Convert.ToBoolean(Int32.Parse(operasyon.SelectSingleNode("SorunYok").InnerText));

                    if (o.SorunYok == false)
                    {
                        o.SorunDurum = true;
                    }
                    else
                    {
                        o.SorunDurum = false;
                    }
                    Operasyon.Ekle(o);
                    bar.Value = sayac++;
                    File.Move(Application.StartupPath + klasor + data, Application.StartupPath + @"\XmlBackup\" + data);
                }
                catch
                {
                    if (!HataPersonelListe.Contains(kartID))
                    {
                        HataPersonelListe.Add(kartID.ToString());
                    }
                    try
                    {
                        File.Move(Application.StartupPath + klasor + data, Application.StartupPath + @"\XmlHata\" + data);
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }
            }
            bar.Value = dosyaSayisi;
            if (HataPersonelListe.Count != 0)
            {
                string hata = "";
                int syc = 1;
                foreach (string item in HataPersonelListe)
                {

                    hata = hata + (syc++ + "-)" + item + "\n");
                }
                MessageBox.Show("Kaydetme işlemi sırasında hata oluşan KartID : " + "\n" + hata);
            }
        }

        public int gunFark(DateTime dt1, DateTime dt2)
        {
            TimeSpan zaman = new TimeSpan();
            zaman = dt1 - dt2;
            return Math.Abs(zaman.Days);
        }

        public void DosyaSil(string klasor)
        {
            List<string> backupKlasor = new List<string>();
            Listeleme(klasor, backupKlasor);

            DateTime bugun = new DateTime();
            bugun = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy}", DateTime.Now));
            DateTime gelenTarih = new DateTime();

            foreach (var item in backupKlasor)
            {
                if (item.StartsWith("Terminal"))
                {

                    string tarih = item.Substring(9, 19);
                    int yil = Convert.ToInt32(tarih.Substring(0, 4));
                    int ay = Convert.ToInt32(tarih.Substring(5, 2));
                    int gun = Convert.ToInt32(tarih.Substring(8, 2));
                    gelenTarih = DateTime.Parse(gun + "." + ay + "." + yil);
                    int fark = gunFark(bugun, gelenTarih);

                    if (fark >= 30)
                    {
                        File.Delete(Application.StartupPath + klasor + item);
                    }
                }
                else
                {
                    string tarih = item.Substring(8, 19);
                    int yil = Convert.ToInt32(tarih.Substring(0, 4));
                    int ay = Convert.ToInt32(tarih.Substring(5, 2));
                    int gun = Convert.ToInt32(tarih.Substring(8, 2));
                    gelenTarih = DateTime.Parse(gun + "." + ay + "." + yil);
                    int fark = gunFark(bugun, gelenTarih);

                    if (fark >= 30)
                    {
                        File.Delete(Application.StartupPath + klasor + item);
                    }
                }
            }
        }


    }
}
