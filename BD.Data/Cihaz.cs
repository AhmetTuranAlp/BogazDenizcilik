//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cihaz
    {
        public int CihazID { get; set; }
        public string CihazAdi { get; set; }
        public string FtpAdres { get; set; }
        public string FtpUser { get; set; }
        public string FtpPas { get; set; }
        public Nullable<int> ftpPort { get; set; }
    }
}
