using BD.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Data
{
    public class PersonelIslemleri
    {
        public bool Ekle(DTO.PersonelDTO personel)
        {

            try
            {
                if (personel.Adi != "" && personel.Soyad != "" && personel.KartID != "")
                {
                    using (var db = new ProjeBEntities())
                    {
                        db.Personel.Add(new Personel()
                        {
                            Adi = personel.Adi,
                            Soyad = personel.Soyad,
                            EkipID = personel.EkipID,
                            KartID = personel.KartID,
                            PersonelID = personel.PersonelID,
                            Durum = personel.Durum
                        });
                        db.SaveChanges();
                        return true;
                    }
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

        public bool Sil(int id)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Personel personel = db.Personel.FirstOrDefault(x => x.PersonelID == id);
                    personel.Durum = false;
                    personel.KartID = "Ayrılmış Personel";
                    personel.EkipID = 16;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Duzenle(DTO.PersonelDTO personel)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Personel per = db.Personel.FirstOrDefault(x => x.PersonelID == personel.PersonelID);
                    per.PersonelID = personel.PersonelID;
                    per.Adi = personel.Adi;
                    per.Soyad = personel.Soyad;
                    per.EkipID = personel.EkipID;
                    per.KartID = personel.KartID;
                    per.Durum = personel.Durum;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DTO.PersonelEkipModelViewDTO> PersonelEkipListe(bool durum)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from p in db.Personel
                                 from ek in db.Ekipler
                                 where p.EkipID == ek.EkipID
                                 select new DTO.PersonelEkipModelViewDTO
                                 {
                                     Adi = p.Adi,
                                     Durum = p.Durum,
                                     EkipAdi = ek.EkipAdi,
                                     KartID = p.KartID,
                                     PersonelID = p.PersonelID,
                                     Soyad = p.Soyad
                                 }).Where(x => x.Durum == durum).OrderBy(x => x.EkipAdi).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.PersonelEkipModelViewDTO>();
                }

            }
        }

        public List<DTO.PersonelEkipModelViewDTO> EkipsizPersonelListesi()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from p in db.Personel
                                 from ek in db.Ekipler
                                 where p.EkipID == ek.EkipID
                                 select new DTO.PersonelEkipModelViewDTO
                                 {
                                     Adi = p.Adi,
                                     Durum = p.Durum,
                                     EkipAdi = ek.EkipAdi,
                                     KartID = p.KartID,
                                     PersonelID = p.PersonelID,
                                     Soyad = p.Soyad
                                 }).Where(x => x.Durum == true && x.EkipAdi == "GENEL").OrderBy(x => x.EkipAdi).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.PersonelEkipModelViewDTO>();
                }

            }
        }

        public List<DTO.PersonelEkipModelViewDTO> PersonelEkipAramaListe(string arama)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    var liste = (from p in db.Personel
                                 from ek in db.Ekipler
                                 where p.EkipID == ek.EkipID
                                 select new DTO.PersonelEkipModelViewDTO
                                 {
                                     Adi = p.Adi,
                                     Durum = p.Durum,
                                     EkipAdi = ek.EkipAdi,
                                     KartID = p.KartID,
                                     PersonelID = p.PersonelID,
                                     Soyad = p.Soyad
                                 }).Where(x => x.Durum == true && x.Adi.Contains(arama) || x.Soyad.Contains(arama) || x.KartID.Contains(arama) || x.EkipAdi.Contains(arama)).ToList();
                    return liste;
                }
                catch (Exception)
                {
                    return new List<DTO.PersonelEkipModelViewDTO>();
                }

            }
        }

        public List<DTO.PersonelDTO> PersonelListe()
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    return db.Personel.Select(x => new DTO.PersonelDTO()
                    {
                        PersonelID = x.PersonelID,
                        Adi = x.Adi,
                        Soyad = x.Soyad,
                        KartID = x.KartID,
                        EkipID = x.EkipID,
                        Durum = x.Durum
                    }).Where(x => x.Durum == true).ToList();
                }
                catch (Exception)
                {
                    return new List<DTO.PersonelDTO>();
                }

            }
        }

        public int PersonelId(string perIsim)
        {
            using (var db = new ProjeBEntities())
            {
                Personel personel = db.Personel.FirstOrDefault(x => x.Adi + " " + x.Soyad == perIsim);

                return personel.PersonelID;
            }
        }

        public string PersonelEkipAdi(string perIsim)
        {
            using (var db = new ProjeBEntities())
            {
                Personel personel = db.Personel.FirstOrDefault(x => x.Adi + " " + x.Soyad == perIsim);
                Ekipler ekip = db.Ekipler.FirstOrDefault(x => x.EkipID == personel.EkipID);
                return ekip.EkipAdi;
            }
        }

        public DTO.PersonelDTO TekPersonel(string kartId)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    return db.Personel.Select(x => new DTO.PersonelDTO()
                    {
                        PersonelID = x.PersonelID,
                        Adi = x.Adi,
                        Soyad = x.Soyad,
                        KartID = x.KartID,
                        EkipID = x.EkipID,
                        Durum = x.Durum
                    }).FirstOrDefault(x => x.KartID == kartId);
                }
                catch (Exception)
                {
                    return new DTO.PersonelDTO();
                }
            }
        }

        public bool KartIDKontrol(string kartId)
        {
            using (var db = new ProjeBEntities())
            {
                Personel kontrol = db.Personel.FirstOrDefault(x => x.KartID == kartId);
                if (kontrol == null)
                    return true;
                else
                    return false;
            }
        }
    }
}

