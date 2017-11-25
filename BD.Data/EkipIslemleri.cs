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
            using (var db = new ProjeBEntities())
            {
                return db.Ekipler.Select(x => new DTO.EkiplerDTO()
                {
                    EkipAdi = x.EkipAdi,
                    Durum = x.Durum,
                    EkipID = x.EkipID
                }).ToList();
            }
        }
    }
}
