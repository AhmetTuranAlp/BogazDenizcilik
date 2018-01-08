using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class ArsivDTO
    {
        public int ArsivID { get; set; }

        public int OperasyonID { get; set; }

        public string Barkod { get; set; }

        public int? PersonelID { get; set; }

        public int? EkipID { get; set; }

        public string Tip { get; set; }

        public DateTime? Zaman { get; set; }

        public bool? AnahtarKaybi { get; set; }

        public bool? AracHasar { get; set; }

        public bool? CamAcik { get; set; }

        public bool? VitesKonum { get; set; }

        public bool? ElfrenKonum { get; set; }

        public bool? Diger { get; set; }

        public bool? SorunYok { get; set; }

        public bool? SorunDurum { get; set; }
    }
}
