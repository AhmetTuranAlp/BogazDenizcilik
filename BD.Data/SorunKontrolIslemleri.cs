using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class SorunKontrolIslemleri
    {
        public List<DTO.OperasyonModelViewDTO> OperasyonListeleme()
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
                                 }).Where(x => x.SorunDurum == true).ToList();
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
                    Operasyon o = db.Operasyon.FirstOrDefault(x => x.Barkod.ToString() == arama);
                    if (o != null)
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
                                     }).Where(x => x.Barkod == o.Barkod && x.SorunDurum == true).ToList();
                        return liste;
                    }
                    else
                    {
                        return new List<DTO.OperasyonModelViewDTO>();
                    }

                }
                catch (Exception)
                {
                    return new List<DTO.OperasyonModelViewDTO>();
                }

            }
        }

        public bool Ekle(DTO.SorunlarDTO sorun)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.Sorunlar.Add(new Sorunlar()
                    {
                        Barkod = sorun.Barkod,
                        PersonelID = sorun.PersonelID,
                        Aciklama = sorun.Aciklama,
                        Zaman = sorun.Zaman
                    });
                    Operasyon ope = db.Operasyon.FirstOrDefault(x => x.Barkod == sorun.Barkod && x.PersonelID == sorun.PersonelID);
                    ope.SorunDurum = false;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DTO.SorunlarPersonelModelViewDTO> SorunluKayitlarListeleme()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from s in db.Sorunlar
                                 from p in db.Personel
                                 where s.PersonelID == p.PersonelID
                                 select new DTO.SorunlarPersonelModelViewDTO
                                 {
                                     SorunID = s.SorunID,
                                     Barkod = s.Barkod,
                                     Adi = p.Adi,
                                     Soyad = p.Soyad,
                                     Aciklama = s.Aciklama,
                                     Zaman = s.Zaman,

                                 }).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.SorunlarPersonelModelViewDTO>();
                }

            }
        }
    }
}
