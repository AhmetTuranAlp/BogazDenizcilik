using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DTO
{
    public class FtpServerDTO
    {
        public int ServerID { get; set; }
        public int? FtpPort { get; set; }
        public string FtpUser { get; set; }
        public string FtpPass { get; set; }
    }
}
