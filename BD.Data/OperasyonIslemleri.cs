using BD.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Data
{
    public class OperasyonIslemleri
    {
        public bool Ekle(DTO.OperasyonDTO dosya)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.Operasyon.Add(new Operasyon()
                    {
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

        public bool Ekle_OMV(DTO.OperasyonModelViewDTO dosya)
        {
            try
            {
                var operasyonListe = this.Listeleme();
                PersonelIslemleri personel = new PersonelIslemleri();
                EkipIslemleri ekip = new EkipIslemleri();
                using (var db = new ProjeBEntities())
                {
                    db.Operasyon.Add(new Operasyon()
                    {
                        OperasyonID = dosya.OperasyonID,
                        Barkod = dosya.Barkod,
                        PersonelID = personel.PersonelId(dosya.Adi + " " + dosya.Soyad),
                        EkipID = ekip.EkipId(dosya.EkipAdi),
                        Tip = dosya.Tip,
                        Zaman = dosya.Zaman,
                        AnahtarKaybi = dosya.AnahtarKaybi,
                        AracHasar = dosya.AracHasar,
                        CamAcik = dosya.CamAcik,
                        VitesKonum = dosya.VitesKonum,
                        ElfrenKonum = dosya.ElfrenKonum,
                        Diger = dosya.Diger,
                        SorunYok = dosya.SorunYok,
                        SorunDurum = dosya.SorunDurum,
                    });
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Sil(int id)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Operasyon operasyon = db.Operasyon.FirstOrDefault(x => x.OperasyonID == id);
                    db.Operasyon.Remove(operasyon);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DTO.OperasyonModelViewDTO> Listeleme()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from op in db.Operasyon
                                 from p in db.Personel
                                 from ek in db.Ekipler
                                 where op.PersonelID == p.PersonelID && p.EkipID == ek.EkipID
                                 select new DTO.OperasyonModelViewDTO
                                 {
                                     OperasyonID = (int)op.OperasyonID,
                                     Barkod = op.Barkod,
                                     Adi = p.Adi,
                                     Soyad = p.Soyad,
                                     Tip = op.Tip,
                                     KartID = p.KartID,
                                     EkipAdi = ek.EkipAdi,
                                     Zaman = (DateTime)op.Zaman,
                                     AnahtarKaybi = (bool)op.AnahtarKaybi,
                                     AracHasar = (bool)op.AracHasar,
                                     CamAcik = (bool)op.CamAcik,
                                     VitesKonum = (bool)op.VitesKonum,
                                     ElfrenKonum = (bool)op.ElfrenKonum,
                                     Diger = (bool)op.Diger,
                                     SorunYok = (bool)op.SorunYok,
                                     SorunDurum = (bool)op.SorunDurum
                                 }).OrderBy(x => x.OperasyonID).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.OperasyonModelViewDTO>();
                }

            }
        }

        public List<DTO.OperasyonModelViewDTO> SorunluKayitlariListeleme()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from op in db.Operasyon
                                 from p in db.Personel
                                 from ek in db.Ekipler
                                 where op.PersonelID == p.PersonelID && p.EkipID == ek.EkipID
                                 select new DTO.OperasyonModelViewDTO
                                 {
                                     OperasyonID = (int)op.OperasyonID,
                                     Barkod = op.Barkod,
                                     Adi = p.Adi,
                                     Soyad = p.Soyad,
                                     Tip = op.Tip,
                                     KartID = p.KartID,
                                     EkipAdi = ek.EkipAdi,
                                     Zaman = (DateTime)op.Zaman,
                                     AnahtarKaybi = (bool)op.AnahtarKaybi,
                                     AracHasar = (bool)op.AracHasar,
                                     CamAcik = (bool)op.CamAcik,
                                     VitesKonum = (bool)op.VitesKonum,
                                     ElfrenKonum = (bool)op.ElfrenKonum,
                                     Diger = (bool)op.Diger,
                                     SorunYok = (bool)op.SorunYok,
                                     SorunDurum = (bool)op.SorunDurum
                                 }).Where(x => x.SorunYok == false).OrderBy(x => x.OperasyonID).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.OperasyonModelViewDTO>();
                }

            }
        }

        public List<DTO.OperasyonModelViewDTO> OperasyonAramaListe(string arama)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    return (from op in db.Operasyon
                            from p in db.Personel
                            from ek in db.Ekipler
                            where op.PersonelID == p.PersonelID && p.EkipID == ek.EkipID
                            select new DTO.OperasyonModelViewDTO
                            {
                                OperasyonID = (int)op.OperasyonID,
                                Barkod = op.Barkod,
                                Adi = p.Adi,
                                Soyad = p.Soyad,
                                Tip = op.Tip,
                                KartID = p.KartID,
                                EkipAdi = ek.EkipAdi,
                                Zaman = (DateTime)op.Zaman,
                                AnahtarKaybi = (bool)op.AnahtarKaybi,
                                AracHasar = (bool)op.AracHasar,
                                CamAcik = (bool)op.CamAcik,
                                VitesKonum = (bool)op.VitesKonum,
                                ElfrenKonum = (bool)op.ElfrenKonum,
                                Diger = (bool)op.Diger,
                                SorunYok = (bool)op.SorunYok,
                                SorunDurum = (bool)op.SorunDurum
                            }).Where(x => x.Barkod.Contains(arama)).ToList();
                }
                catch (Exception)
                {
                    return new List<DTO.OperasyonModelViewDTO>();
                }

            }
        }

        public void OperasyonHataKontrol(string arama, DataGridView grid)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    Operasyon o = db.Operasyon.FirstOrDefault(x => x.Barkod.ToString() == arama);
                    if (o.SorunYok == false)
                    {
                        Application.DoEvents();
                        DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                        rowColor.BackColor = Color.Red;
                        grid.Rows[0].DefaultCellStyle = rowColor;
                        MessageBox.Show("Bu kayıtlı araç'ta sorun tesbit edilmiştir.");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public DateTime Zaman(string barkod)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Operasyon operasyon = db.Operasyon.FirstOrDefault(x => x.Barkod == barkod);
                    return Convert.ToDateTime(operasyon.Zaman);
                }
            }
            catch (Exception)
            {
                return DateTime.MaxValue;
            }

        }

        public DataTable TableListe(string sp)
        {
            try
            {
                VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();
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

        public int TableCount()
        {
            try
            {
                VeritabaniYedekIslemleri dbIslem = new VeritabaniYedekIslemleri();
                string connec = dbIslem.ConnectionString();
                SqlConnection con = new SqlConnection(connec);
                SqlCommand cmd = new SqlCommand("Select Count(*) from Operasyon", con);
                con.Open();
                int deger = (int)cmd.ExecuteScalar();
                con.Close();
                return deger;
            }
            catch (Exception)
            {
                return 0;
            }

        }


    }
}
