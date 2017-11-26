using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class SifreDegistirme
    {
        public List<DTO.SifreGirisZamanalarıDTO> Listeleme()
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.SifreGirisZamanaları.Select(x => new DTO.SifreGirisZamanalarıDTO()
                    {
                        GirisID = x.GirisID,
                        GirisZamani = x.GirisZamani,
                        ErisilenSayfa =x.ErisilenSayfa
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.SifreGirisZamanalarıDTO>();
            }

        }

        public bool SifreGuncelle(string sifre)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Ayarlar dogrulama = db.Ayarlar.FirstOrDefault(x => x.ID == 1);
                    dogrulama.Sifre = sifre;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
