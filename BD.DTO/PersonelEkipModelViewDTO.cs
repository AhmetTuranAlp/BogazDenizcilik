using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class PersonelEkipModelViewDTO
    {
        public int PersonelID { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public string KartID { get; set; }
        public string EkipAdi { get; set; }
        public bool? Durum { get; set; }
    }
}
