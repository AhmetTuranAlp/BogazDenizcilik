using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class SorunlarPersonelModelViewDTO
    {
        public int SorunID { get; set; }

        public string Barkod { get; set; }

        public string Adi { get; set; }
        public string Soyad { get; set; }

        public DateTime? Zaman { get; set; }

        public string Aciklama { get; set; }
    }
}
