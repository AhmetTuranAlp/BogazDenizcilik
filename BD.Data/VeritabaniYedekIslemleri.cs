using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
   public class VeritabaniYedekIslemleri
    {
        public List<DTO.VeritabaniYedekDTO> Listeleme()
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.VeritabaniYedek.Select(x => new DTO.VeritabaniYedekDTO()
                    {
                        BackupID = x.BackupID,
                        BackupAdi = x.BackupAdi,
                        BackupKonum = x.BackupKonum
                    }).OrderByDescending(x => x.BackupID).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.VeritabaniYedekDTO>();
            }

        }

        public bool Ekle(DTO.VeritabaniYedekDTO backup)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.VeritabaniYedek.Add(new VeritabaniYedek()
                    {
                        BackupAdi = backup.BackupAdi,
                        BackupKonum=backup.BackupKonum,
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

        public bool Sil(string dosya)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    VeritabaniYedek backup = db.VeritabaniYedek.FirstOrDefault(x => x.BackupAdi == dosya);
                    db.VeritabaniYedek.Remove(backup);
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
