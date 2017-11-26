using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
   public class SifreGirisZamanalarıDTO
    {
        public int GirisID { get; set; }

        public DateTime? GirisZamani { get; set; }
        
        public string ErisilenSayfa { get; set; }
    }
}
