namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specName")]
    public partial class specName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public specName()
        {
            specifications = new HashSet<specification>();
        }

        public long specNameId { get; set; }

        [Column("specName")]
        [StringLength(50)]
        public string specName1 { get; set; }

        public long? specClassId { get; set; }

        [StringLength(50)]
        public string specMeasure { get; set; }

        [StringLength(50)]
        public string displayName { get; set; }

        public bool? isOption { get; set; }

        public virtual specClass specClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specification> specifications { get; set; }
    }
}
