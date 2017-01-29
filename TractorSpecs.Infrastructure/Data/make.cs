namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("make")]
    public partial class make
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public make()
        {
            makeAlias = new HashSet<makeAlia>();
            models = new HashSet<model>();
        }

        public long makeId { get; set; }

        [StringLength(50)]
        public string mfgName { get; set; }

        [StringLength(50)]
        public string mfgURL { get; set; }

        [StringLength(1000)]
        public string mfgDesc { get; set; }

        [StringLength(500)]
        public string mfgLogoImg { get; set; }

        [StringLength(50)]
        public string mfgImg { get; set; }

        public decimal? mfgValueAdjust { get; set; }

        [StringLength(50)]
        public string mfgLink { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<makeAlia> makeAlias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<model> models { get; set; }
    }
}
