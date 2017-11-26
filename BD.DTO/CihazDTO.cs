using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class CihazDTO
    {
        public int CihazID { get; set; }
        
        public string CihazAdi { get; set; }
        
        public string FtpAdres { get; set; }
        
        public string FtpUser { get; set; }
        
        public string FtpPas { get; set; }

        public int? ftpPort { get; set; }
    }
}
