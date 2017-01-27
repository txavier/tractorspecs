namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Core.Models;

    public partial class EfDataDbContext : DbContext
    {
        public EfDataDbContext()
            : base("name=EfDataDbContext")
        {
        }

        public virtual DbSet<APIkey> APIkeys { get; set; }
        public virtual DbSet<APIspecReqCounter> APIspecReqCounters { get; set; }
        public virtual DbSet<APIspecRequest> APIspecRequests { get; set; }
        public virtual DbSet<APISpecTracker> APISpecTrackers { get; set; }
        public virtual DbSet<attachment> attachments { get; set; }
        public virtual DbSet<b> b { get; set; }
        public virtual DbSet<EquipClassSpecClass> EquipClassSpecClasses { get; set; }
        public virtual DbSet<equipmentClass> equipmentClasses { get; set; }
        public virtual DbSet<link> links { get; set; }
        public virtual DbSet<make_alias> make_alias { get; set; }
        public virtual DbSet<make> makes { get; set; }
        public virtual DbSet<Miss> Misses { get; set; }
        public virtual DbSet<Model_Alias> Model_Alias { get; set; }
        public virtual DbSet<modelPicture> modelPictures { get; set; }
        public virtual DbSet<modelPrice> modelPrices { get; set; }
        public virtual DbSet<model> models { get; set; }
        public virtual DbSet<PrintView> PrintViews { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<rssDealerID> rssDealerIDs { get; set; }
        public virtual DbSet<SpecChangeLog> SpecChangeLogs { get; set; }
        public virtual DbSet<SpecClass> SpecClasses { get; set; }
        public virtual DbSet<specification> specifications { get; set; }
        public virtual DbSet<SpecName> SpecNames { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<setting> settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APIkey>()
                .Property(e => e.APIkey1)
                .IsUnicode(false);

            modelBuilder.Entity<APIkey>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<APIspecReqCounter>()
                .Property(e => e.API_key)
                .IsUnicode(false);

            modelBuilder.Entity<APIspecRequest>()
                .Property(e => e.API_key)
                .IsUnicode(false);

            modelBuilder.Entity<APIspecRequest>()
                .Property(e => e.PriorityNotes)
                .IsUnicode(false);

            modelBuilder.Entity<APIspecRequest>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<APIspecRequest>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<APISpecTracker>()
                .Property(e => e.ApiKey)
                .IsUnicode(false);

            modelBuilder.Entity<equipmentClass>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<equipmentClass>()
                .Property(e => e.ClassURL)
                .IsUnicode(false);

            modelBuilder.Entity<link>()
                .Property(e => e.linkURL)
                .IsUnicode(false);

            modelBuilder.Entity<link>()
                .Property(e => e.linkText)
                .IsUnicode(false);

            modelBuilder.Entity<link>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<make_alias>()
                .Property(e => e.MfgAlias)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgName)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgURL)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgDesc)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgLogoImg)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgImg)
                .IsUnicode(false);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgValueAdjust)
                .HasPrecision(5, 2);

            modelBuilder.Entity<make>()
                .Property(e => e.mfgLink)
                .IsUnicode(false);

            modelBuilder.Entity<Miss>()
                .Property(e => e.make)
                .IsUnicode(false);

            modelBuilder.Entity<Miss>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Model_Alias>()
                .Property(e => e.AliasName)
                .IsUnicode(false);

            modelBuilder.Entity<Model_Alias>()
                .Property(e => e.AliasDescription)
                .IsUnicode(false);

            modelBuilder.Entity<modelPicture>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<modelPicture>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.TRApicID)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.modelyear)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.DorP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.msrp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<model>()
                .Property(e => e.modelnumber)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.modelURL)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.mfgName)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.modelnumber)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.specValue)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.SpecMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.mfgLogoImg)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.mfgURL)
                .IsUnicode(false);

            modelBuilder.Entity<PrintView>()
                .Property(e => e.modelURL)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.reviewText)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.reviewName)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<review>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<rssDealerID>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<SpecChangeLog>()
                .Property(e => e.SpecValue)
                .IsUnicode(false);

            modelBuilder.Entity<SpecChangeLog>()
                .Property(e => e.IPaddr)
                .IsUnicode(false);

            modelBuilder.Entity<SpecChangeLog>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<SpecClass>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<SpecClass>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.specValue)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.extendedValue)
                .IsUnicode(false);

            modelBuilder.Entity<SpecName>()
                .Property(e => e.SpecName1)
                .IsUnicode(false);

            modelBuilder.Entity<SpecName>()
                .Property(e => e.SpecMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<SpecName>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);
        }
    }
}
