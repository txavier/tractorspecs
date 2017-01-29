namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("model")]
    public partial class model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public model()
        {
            links = new HashSet<link>();
            modelAlias = new HashSet<modelAlia>();
            modelPictures = new HashSet<modelPicture>();
            modelPrices = new HashSet<modelPrice>();
            reviews = new HashSet<review>();
            specChangeLogs = new HashSet<specChangeLog>();
            specifications = new HashSet<specification>();
        }

        public long modelId { get; set; }

        public long? makeId { get; set; }

        public decimal? msrp { get; set; }

        public DateTime? lastUpdate { get; set; }

        [StringLength(50)]
        public string modelNumber { get; set; }

        [StringLength(50)]
        public string modelUrl { get; set; }

        public int? equipmentClassId { get; set; }

        [StringLength(20)]
        public string ip { get; set; }

        public DateTime? date { get; set; }

        public long? pageviews { get; set; }

        public virtual equipmentClass equipmentClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<link> links { get; set; }

        public virtual make make { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modelAlia> modelAlias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modelPicture> modelPictures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modelPrice> modelPrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> reviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specChangeLog> specChangeLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specification> specifications { get; set; }
    }
}
