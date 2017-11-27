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
        CihazIslemleri Cihaz = new CihazIslemleri();
        PersonelIslemleri Personel = new PersonelIslemleri();
        OperasyonIslemleri Operasyon = new OperasyonIslemleri();

        List<string> files = new List<string>();
        List<string> dataKloser = new List<string>();

        public void XmlListeleme(int id)
        {
            var ayarlar = Cihaz.CihazId(id);
            try
            {
                FtpWebRequest reguest = FtpWebRequest.Create("ftp://" + ayarlar.FtpAdres + ":" + ayarlar.ftpPort) as FtpWebRequest;
                reguest.Method = WebRequestMethods.Ftp.ListDirectory;
                reguest.Credentials = new NetworkCredential(ayarlar.FtpUser, ayarlar.FtpPas.ToString());
                FtpWebResponse response = (FtpWebResponse)reguest.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }
                response.Close();
                responseStream.Close();
                reader.Close();

                if (System.IO.Directory.Exists("../XmlData") == false)
                {
                    Directory.CreateDirectory("../XmlData");
                }

                foreach (string xml in files)
                {
                    if (xml.Contains(".xml"))
                    {
                        WebClient istemci = new WebClient();
                        istemci.Credentials = new NetworkCredential(ayarlar.FtpUser, ayarlar.FtpPas);
                        byte[] veriDosya = istemci.DownloadData("ftp://" + ayarlar.FtpAdres + ":" + ayarlar.ftpPort + "/" + xml);
                        FileStream dosya = File.Create("../XmlData/" + xml);
                        dosya.Write(veriDosya, 0, veriDosya.Length);
                        dosya.Close();
                        dataKloser.Add(xml);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }

        }

        public void XmlKaydet()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                foreach (string data in dataKloser)
                {
                    DTO.PersonelDTO GelenPersonel = new DTO.PersonelDTO();
            
                    doc.Load("../XmlData/" + data);
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
                }

                MessageBox.Show("Dosyalar Kaydedidi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        public void XmlDosyaTasima()
        {
            if (System.IO.Directory.Exists("../XmlBackup") == false)
            {
                Directory.CreateDirectory("../XmlBackup");
            }
            foreach (var dosya in dataKloser)
            {
                File.Move("../XmlData/" + dosya, "../XmlBackup/" + dosya);
            }
        }
        
        public void XmlDosyaSilme(int id)
        {
            var ayarlar = Cihaz.CihazId(id);
            try
            {
                foreach (var xml in dataKloser)
                {
                    string uri = "ftp://" + ayarlar.FtpAdres + ":" + ayarlar.ftpPort + "/" + xml;
                    FtpWebRequest reqFTP;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                    reqFTP.Credentials = new NetworkCredential(ayarlar.FtpUser, ayarlar.FtpPas);
                    reqFTP.KeepAlive = false;
                    reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                    string result = String.Empty;
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    long size = response.ContentLength;
                    Stream datastream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(datastream);
                    result = sr.ReadToEnd();
                    sr.Close();
                    datastream.Close();
                    response.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FTP 2.0 Delete");
            }
        }
    }
}
