using System;
using System.Collections.Generic;
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

        List<string> dataKloser = new List<string>();

        public void Listeleme()
        {
            string path = Application.StartupPath + @"\XmlData\";
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] rgFiles = di.GetFiles();
            foreach (FileInfo fi in rgFiles)
            {
                dataKloser.Add(fi.Name);
            }
        }

        public void XmlKaydet(ProgressBar bar)
        {
            try
            {
                int dosyaSayisi = Directory.GetFiles(Application.StartupPath + @"\XmlData", "*.*", SearchOption.AllDirectories).Length;
                bar.Minimum = 0;
                bar.Maximum = dosyaSayisi;
                bar.Step = 1;

                int sayac = 0;
                XmlDocument doc = new XmlDocument();


                if (!Directory.Exists(Application.StartupPath + @"\XmlBackup"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\XmlBackup");
                }

                foreach (string data in dataKloser)
                {
                    DTO.PersonelDTO GelenPersonel = new DTO.PersonelDTO();
                    doc.Load((Application.StartupPath + @"\XmlData\" + data));
                    XmlNode operasyon = doc.SelectSingleNode("operasyon");
                    string kartID = operasyon.SelectSingleNode("Personel").InnerText;
                    GelenPersonel = Personel.TekPersonel(kartID);
                    DTO.OperasyonDTO o = new DTO.OperasyonDTO();
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
                    File.Move(Application.StartupPath + @"\XmlData\" + data, Application.StartupPath + @"\XmlBackup\" + data);
                }

                MessageBox.Show("Kaydetme İşlemi Tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
