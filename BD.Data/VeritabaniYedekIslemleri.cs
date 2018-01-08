using BD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                        BackupKonum = backup.BackupKonum,
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

        public string ConnectionString()
        {
            string connec = ("data source=.;initial catalog=ProjeB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            return connec;
        }

        public bool Backup(string txtbackup)
        {
            try
            {
                string tarih = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-sss");
                string connectionString1 = this.ConnectionString();
                SqlConnection cn = new SqlConnection(connectionString1);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = @"BACKUP DATABASE ProjeB TO DISK ='" + txtbackup + "\\" + tarih + "_BoğazDenizcilik.bak'";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                reader = cmd.ExecuteReader();
                cn.Close();

                VeritabaniYedekDTO backup = new VeritabaniYedekDTO();
                backup.BackupAdi = tarih + "_BoğazDenizcilik.bak";
                backup.BackupKonum = txtbackup;
                this.Ekle(backup);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Restore(string txtRestore)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = this.ConnectionString();

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string sqlStmt2 = string.Format("ALTER DATABASE ProjeB SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE ProjeB FROM DISK='" + txtRestore + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE ProjeB SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Arsiv()
        {
            try
            {
                ArsivDTO arsiv = new ArsivDTO();
                OperasyonIslemleri opeIslem = new OperasyonIslemleri();
                var operasyonListe = opeIslem.Listeleme();
                PersonelIslemleri personel = new PersonelIslemleri();
                EkipIslemleri ekip = new EkipIslemleri();
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
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
            
    }
}
