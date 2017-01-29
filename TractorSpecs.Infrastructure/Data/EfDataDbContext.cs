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

        public virtual DbSet<apiKey> apiKeys { get; set; }
        public virtual DbSet<apiSpecReqCounter> apiSpecReqCounters { get; set; }
        public virtual DbSet<apiSpecRequest> apiSpecRequests { get; set; }
        public virtual DbSet<apiSpecTracker> apiSpecTrackers { get; set; }
        public virtual DbSet<attachment> attachments { get; set; }
        public virtual DbSet<equipClassSpecClass> equipClassSpecClasses { get; set; }
        public virtual DbSet<equipmentClass> equipmentClasses { get; set; }
        public virtual DbSet<link> links { get; set; }
        public virtual DbSet<make> makes { get; set; }
        public virtual DbSet<makeAlia> makeAlias { get; set; }
        public virtual DbSet<miss> misses { get; set; }
        public virtual DbSet<model> models { get; set; }
        public virtual DbSet<modelAlia> modelAlias { get; set; }
        public virtual DbSet<modelPicture> modelPictures { get; set; }
        public virtual DbSet<modelPrice> modelPrices { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<rssDealerID> rssDealerIDs { get; set; }
        public virtual DbSet<specChangeLog> specChangeLogs { get; set; }
        public virtual DbSet<specClass> specClasses { get; set; }
        public virtual DbSet<specification> specifications { get; set; }
        public virtual DbSet<specName> specNames { get; set; }
        public virtual DbSet<PrintView> PrintViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<apiKey>()
                .Property(e => e.apiKey1)
                .IsUnicode(false);

            modelBuilder.Entity<apiKey>()
                .Property(e => e.companyName)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecReqCounter>()
                .Property(e => e.apiKey)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecRequest>()
                .Property(e => e.apiKey)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecRequest>()
                .Property(e => e.priorityNotes)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecRequest>()
                .Property(e => e.make)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecRequest>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<apiSpecTracker>()
                .Property(e => e.apiKey)
                .IsUnicode(false);

            modelBuilder.Entity<equipmentClass>()
                .Property(e => e.className)
                .IsUnicode(false);

            modelBuilder.Entity<equipmentClass>()
                .Property(e => e.classURL)
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

            modelBuilder.Entity<makeAlia>()
                .Property(e => e.mfgAlias)
                .IsUnicode(false);

            modelBuilder.Entity<miss>()
                .Property(e => e.make)
                .IsUnicode(false);

            modelBuilder.Entity<miss>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.msrp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<model>()
                .Property(e => e.modelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.modelUrl)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<modelAlia>()
                .Property(e => e.aliasName)
                .IsUnicode(false);

            modelBuilder.Entity<modelAlia>()
                .Property(e => e.aliasDescription)
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
                .Property(e => e.traPicId)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.modelYear)
                .IsUnicode(false);

            modelBuilder.Entity<modelPrice>()
                .Property(e => e.DorP)
                .IsFixedLength()
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

            modelBuilder.Entity<specChangeLog>()
                .Property(e => e.specValue)
                .IsUnicode(false);

            modelBuilder.Entity<specChangeLog>()
                .Property(e => e.ipAddr)
                .IsUnicode(false);

            modelBuilder.Entity<specChangeLog>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<specClass>()
                .Property(e => e.className)
                .IsUnicode(false);

            modelBuilder.Entity<specClass>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.specValue)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<specification>()
                .Property(e => e.extendedValue)
                .IsUnicode(false);

            modelBuilder.Entity<specName>()
                .Property(e => e.specName1)
                .IsUnicode(false);

            modelBuilder.Entity<specName>()
                .Property(e => e.specMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<specName>()
                .Property(e => e.displayName)
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
        }
    }
}
