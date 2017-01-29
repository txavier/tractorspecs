namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specClass")]
    public partial class specClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public specClass()
        {
            specNames = new HashSet<specName>();
        }

        public long specClassID { get; set; }

        [StringLength(50)]
        public string className { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specName> specNames { get; set; }
    }
}
