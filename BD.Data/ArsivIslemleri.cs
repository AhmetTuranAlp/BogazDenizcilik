using BD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Data
{
    public class ArsivIslemleri
    {
        VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();
        public bool Arsiv(ProgressBar bar)
        {
            try
            {
                ArsivDTO arsiv = new ArsivDTO();
                OperasyonIslemleri opeIslem = new OperasyonIslemleri();
                var operasyonListe = opeIslem.Listeleme();
                PersonelIslemleri personel = new PersonelIslemleri();
                EkipIslemleri ekip = new EkipIslemleri();

                int dosyaSayisi = operasyonListe.Count();
                bar.Minimum = 0;
                bar.Maximum = dosyaSayisi;
                bar.Step = 1;
                int sayac = 0;
                if (dosyaSayisi != 0)
                {
                    using (var db = new ProjeBEntities())
                    {
                        foreach (var ope in operasyonListe)
                        {
                            db.Arsiv.Add(new Arsiv()
                            {
                                OperasyonID = ope.OperasyonID,
                                Barkod = ope.Barkod,
                                PersonelID = personel.PersonelId(ope.Adi + " " + ope.Soyad),
                                EkipID = ekip.EkipId(ope.EkipAdi),
                                Tip = ope.Tip,
                                Zaman = ope.Zaman,
                                AnahtarKaybi = ope.AnahtarKaybi,
                                AracHasar = ope.AracHasar,
                                CamAcik = ope.CamAcik,
                                VitesKonum = ope.VitesKonum,
                                ElfrenKonum = ope.ElfrenKonum,
                                Diger = ope.Diger,
                                SorunYok = ope.SorunYok,
                                SorunDurum = ope.SorunDurum,
                            });
                            db.SaveChanges();
                            opeIslem.Sil(ope.OperasyonID);
                            bar.Value = sayac++;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Ekle(DTO.ArsivDTO dosya)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.Arsiv.Add(new Arsiv()
                    {
                        OperasyonID = dosya.OperasyonID,
                        PersonelID = dosya.PersonelID,
                        EkipID = dosya.EkipID,
                        Barkod = dosya.Barkod,
                        Tip = dosya.Tip,
                        Zaman = dosya.Zaman,
                        AnahtarKaybi = dosya.AnahtarKaybi,
                        AracHasar = dosya.AracHasar,
                        CamAcik = dosya.CamAcik,
                        VitesKonum = dosya.VitesKonum,
                        ElfrenKonum = dosya.ElfrenKonum,
                        Diger = dosya.Diger,
                        SorunYok = dosya.SorunYok,
                        SorunDurum = dosya.SorunDurum
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable TableListe(string sp)
        {
            try
            {
                string connec = dbIslem.ConnectionString();
                SqlConnection con = new SqlConnection(connec);
                SqlDataAdapter adp = new SqlDataAdapter(sp, con);
                DataTable tablo = new DataTable();
                adp.Fill(tablo);
                return tablo;
            }
            catch (Exception)
            {
                return new DataTable();
            }

        }

        public List<DTO.ArsivDTO> ArsivListe()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    return db.Arsiv.Select(x => new DTO.ArsivDTO()
                    {
                        ArsivID = x.ArsivID,
                        OperasyonID = x.OperasyonID,
                        Barkod = x.Barkod,
                        PersonelID = x.PersonelID,
                        Tip = x.Tip,
                        EkipID = x.EkipID,
                        Zaman = (DateTime)x.Zaman,
                        AnahtarKaybi = (bool)x.AnahtarKaybi,
                        AracHasar = (bool)x.AracHasar,
                        CamAcik = (bool)x.CamAcik,
                        VitesKonum = (bool)x.VitesKonum,
                        ElfrenKonum = (bool)x.ElfrenKonum,
                        Diger = (bool)x.Diger,
                        SorunYok = (bool)x.SorunYok,
                        SorunDurum = (bool)x.SorunDurum
                    }).ToList();
                }
                catch (Exception)
                {
                    return new List<DTO.ArsivDTO>();
                }

            }
        }

        public void TabloIcerigiSil()
        {
            try
            {
                string connec = dbIslem.ConnectionString();
                SqlConnection con = new SqlConnection(connec);
                string sorgu = "DELETE FROM Arsiv";
                SqlCommand komut = new SqlCommand(sorgu, con);
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
        }

    }
}
