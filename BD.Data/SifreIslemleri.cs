﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class SifreIslemleri
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
                        ErisilenSayfa = x.ErisilenSayfa
                    }).OrderByDescending(x => x.GirisID).ToList();
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

        public bool Ekle(DTO.SifreGirisZamanalarıDTO sayfaDTO)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    db.SifreGirisZamanaları.Add(new SifreGirisZamanaları()
                    {
                        GirisID = sayfaDTO.GirisID,
                        GirisZamani = sayfaDTO.GirisZamani,
                        ErisilenSayfa = sayfaDTO.ErisilenSayfa
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

        public bool SifreGiris(string sifre)
        {
            try
            {
                using (var db = new ProjeBEntities())
                {
                    var Sifre = db.Ayarlar.FirstOrDefault(x => x.ID == 1);
                    var adminSifre = db.Ayarlar.FirstOrDefault(x => x.ID == 2);
                    if (sifre == Sifre.Sifre || sifre == adminSifre.Sifre)
                    {
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
    }
}
