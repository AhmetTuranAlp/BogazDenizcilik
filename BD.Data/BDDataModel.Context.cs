﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjeBEntities : DbContext
    {
        public ProjeBEntities()
            : base("name=ProjeBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arsiv> Arsiv { get; set; }
        public virtual DbSet<Ayarlar> Ayarlar { get; set; }
        public virtual DbSet<Cihaz> Cihaz { get; set; }
        public virtual DbSet<Ekipler> Ekipler { get; set; }
        public virtual DbSet<FtpServer> FtpServer { get; set; }
        public virtual DbSet<Operasyon> Operasyon { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<SifreGirisZamanaları> SifreGirisZamanaları { get; set; }
        public virtual DbSet<Sorunlar> Sorunlar { get; set; }
        public virtual DbSet<VeritabaniYedek> VeritabaniYedek { get; set; }
    
        public virtual ObjectResult<spEkipGenelPerformans_Result> spEkipGenelPerformans()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEkipGenelPerformans_Result>("spEkipGenelPerformans");
        }
    
        public virtual ObjectResult<spOperasyonListe_Result> spOperasyonListe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spOperasyonListe_Result>("spOperasyonListe");
        }
    
        public virtual ObjectResult<spPersonelGenelPerformans_Result> spPersonelGenelPerformans()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPersonelGenelPerformans_Result>("spPersonelGenelPerformans");
        }
    }
}
