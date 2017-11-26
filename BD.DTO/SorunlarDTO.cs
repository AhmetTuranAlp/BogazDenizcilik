using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class SorunlarDTO
    {
        public int SorunID { get; set; }
        
        public string Barkod { get; set; }

        public int? PersonelID { get; set; }

        public DateTime? Zaman { get; set; }
        
        public string Aciklama { get; set; }
    }
}
