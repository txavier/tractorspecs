namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specification")]
    public partial class specification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public specification()
        {
            specChangeLogs = new HashSet<specChangeLog>();
        }

        public long specificationId { get; set; }

        public long? modelId { get; set; }

        public long? specNameId { get; set; }

        [StringLength(50)]
        public string specValue { get; set; }

        [StringLength(20)]
        public string ip { get; set; }

        public DateTime? date { get; set; }

        [StringLength(100)]
        public string extendedValue { get; set; }

        public virtual model model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specChangeLog> specChangeLogs { get; set; }

        public virtual specName specName { get; set; }
    }
}
