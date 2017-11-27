using System;
using System.Collections.Generic;
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
                       PersonelID =dosya.PersonelID,
                       EkipID=dosya.EkipID,
                       Barkod = dosya.Barkod,
                       Tip = dosya.Tip,
                       Zaman=dosya.Zaman,
                       AnahtarKaybi=dosya.AnahtarKaybi,
                       AracHasar=dosya.AracHasar,
                       CamAcik=dosya.CamAcik,
                       VitesKonum=dosya.VitesKonum,
                       ElfrenKonum=dosya.ElfrenKonum,
                       Diger=dosya.Diger,
                       SorunYok=dosya.SorunYok,
                       SorunDurum=dosya.SorunDurum
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
                                     }).Where(x => x.Barkod == o.Barkod).ToList();
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
                        MessageBox.Show("Bu Kayıtlı araç'ta yükleme aşamasında sorunlar tesbit edilmiştir.");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        int deger = 1;
        public void gridViewSiralama(DataGridView izgara, int column)
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

                    if (izgara.Columns[column].Name == "OperasyonID")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.OperasyonID).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.OperasyonID).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Barkod")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Barkod).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Barkod).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Adi")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Adi).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Adi).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Soyad")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Soyad).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Soyad).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "KartID")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.KartID).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.KartID).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "EkipAdi")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.EkipAdi).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.EkipAdi).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Tip")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Tip).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Tip).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Zaman")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Zaman).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Zaman).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "AnahtarKaybi")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.AnahtarKaybi).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.AnahtarKaybi).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "AracHasar")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.AracHasar).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.AracHasar).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "CamAcik")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.CamAcik).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.CamAcik).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "VitesKonum")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.VitesKonum).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.VitesKonum).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "ElfrenKonum")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.ElfrenKonum).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.ElfrenKonum).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "Diger")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.Diger).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.Diger).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "SorunYok")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.SorunYok).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.SorunYok).ToList();
                            deger = 1;
                        }
                    }
                    else if (izgara.Columns[column].Name == "SorunDurum")
                    {
                        if (deger == 1)
                        {
                            izgara.DataSource = liste.OrderByDescending(x => x.SorunDurum).ToList();
                            deger = 2;
                        }
                        else if (deger == 2)
                        {
                            izgara.DataSource = liste.OrderBy(x => x.SorunDurum).ToList();
                            deger = 1;
                        }
                    }
                    for (int i = 0; i < izgara.Rows.Count; i++)
                    {
                        Application.DoEvents();
                        DataGridViewCellStyle renk = new DataGridViewCellStyle();
                        if (izgara.Rows[i].Cells["SorunYok"].Value.ToString() == "False")
                        {
                            renk.BackColor = Color.Red;
                        }
                        izgara.Rows[i].DefaultCellStyle = renk;
                    }
                }
                catch (Exception)
                {
                }

            }
        }

        public DateTime Zaman(string barkod)
        {
            using (var db = new ProjeBEntities())
            {
                Operasyon operasyon = db.Operasyon.FirstOrDefault(x => x.Barkod == barkod);
                return Convert.ToDateTime(operasyon.Zaman);
            }
        }
    }
}
