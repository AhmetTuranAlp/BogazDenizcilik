using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class CihazIslemleri
    {
        public List<DTO.CihazDTO> Listeleme()
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.Cihaz.Select(x => new DTO.CihazDTO()
                    {
                        CihazID = x.CihazID,
                        CihazAdi = x.CihazAdi,
                        FtpAdres = x.FtpAdres,
                        ftpPort = x.ftpPort,
                        FtpUser = x.FtpUser,
                        FtpPas = x.FtpPas
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.CihazDTO>();
            }

        }

        public bool Ekle(DTO.CihazDTO cihazDTO)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.Cihaz.Add(new Cihaz()
                    {
                        CihazID = cihazDTO.CihazID,
                        CihazAdi = cihazDTO.CihazAdi,
                        FtpAdres = cihazDTO.FtpAdres,
                        ftpPort = cihazDTO.ftpPort,
                        FtpUser = cihazDTO.FtpUser,
                        FtpPas = cihazDTO.FtpPas
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

        public bool Duzenle(DTO.CihazDTO cihazDTO)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    Cihaz ch = db.Cihaz.FirstOrDefault(x => x.CihazID == cihazDTO.CihazID);
                    if (ch != null)
                    {
                        ch.CihazID = cihazDTO.CihazID;
                        ch.CihazAdi = cihazDTO.CihazAdi;
                        ch.FtpAdres = cihazDTO.FtpAdres;
                        ch.ftpPort = cihazDTO.ftpPort;
                        ch.FtpUser = cihazDTO.FtpUser;
                        ch.FtpPas = cihazDTO.FtpPas;
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
                    Cihaz ch = db.Cihaz.FirstOrDefault(x => x.CihazID == id);
                    db.Cihaz.Remove(ch);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DTO.CihazDTO> CihazListeArama(string arama)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    return db.Cihaz.Select(x => new DTO.CihazDTO()
                    {
                        CihazID = x.CihazID,
                        CihazAdi = x.CihazAdi,
                        FtpAdres = x.FtpAdres,
                        ftpPort = x.ftpPort,
                        FtpUser = x.FtpUser,
                        FtpPas = x.FtpPas
                    }).Where(x => x.CihazAdi.Contains(arama)).ToList();
                }
            }
            catch (Exception)
            {
                return new List<DTO.CihazDTO>();
            }
        }

        public DTO.CihazDTO CihazId(int id)
        {
            using (var db = new ProjeBEntities())
            {
                try
                {
                    return db.Cihaz.Select(x => new DTO.CihazDTO()
                    {
                        CihazID = x.CihazID,
                        CihazAdi = x.CihazAdi,
                        FtpAdres = x.FtpAdres,
                        ftpPort = x.ftpPort,
                        FtpUser = x.FtpUser,
                        FtpPas = x.FtpPas
                    }).FirstOrDefault(x => x.CihazID == id);
                }
                catch (Exception)
                {
                    return new DTO.CihazDTO();
                }
            }
        }
    }
}
