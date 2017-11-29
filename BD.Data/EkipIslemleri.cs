using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class EkipIslemleri
    {
        public List<DTO.EkiplerDTO> Listeleme()
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.Ekipler.Select(x => new DTO.EkiplerDTO()
                    {
                        EkipAdi = x.EkipAdi,
                        Durum = x.Durum,
                        EkipID = x.EkipID
                    }).Where(x => x.Durum == true).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.EkiplerDTO>();
            }

        }

        public bool Ekle(DTO.EkiplerDTO ekipDTO)
        {
            try
            {
                if (ekipDTO.EkipAdi != "")
                {
                    using (var db = new ProjeBEntities())
                    {
                        db.Ekipler.Add(new Ekipler()
                        {
                            EkipAdi = ekipDTO.EkipAdi,
                            Durum = ekipDTO.Durum
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

        public bool Duzenle(DTO.EkiplerDTO ekipDTO)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Ekipler ek = db.Ekipler.FirstOrDefault(x => x.EkipID == ekipDTO.EkipID);
                    if (ek.EkipID != 16)
                    {
                        ek.EkipID = ekipDTO.EkipID;
                        ek.EkipAdi = ekipDTO.EkipAdi;
                        ek.Durum = true;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
                    Ekipler ekip = db.Ekipler.FirstOrDefault(x => x.EkipID == id);
                    var per = db.Personel.ToList();
                    if (ekip.EkipID != 16)
                    {
                        foreach (var item in per)
                        {
                            if (item.EkipID == id)
                            {
                                item.EkipID = 16;
                                db.SaveChanges();
                            }
                        }
                        db.Ekipler.Remove(ekip);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DTO.EkiplerDTO> EkipListeArama(string arama)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.Ekipler.Select(x => new DTO.EkiplerDTO()
                    {
                        EkipAdi = x.EkipAdi,
                        Durum = x.Durum,
                        EkipID = x.EkipID
                    }).Where(x => x.EkipAdi.Contains(arama)).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.EkiplerDTO>();
            }
        }
    }
}
