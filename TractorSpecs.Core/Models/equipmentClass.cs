namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("equipmentClass")]
    public partial class equipmentClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipmentClass()
        {
            equipClassSpecClasses = new HashSet<equipClassSpecClass>();
            models = new HashSet<model>();
        }

        public int equipmentClassID { get; set; }

        [StringLength(50)]
        public string className { get; set; }

        [StringLength(50)]
        public string classURL { get; set; }

        public int? traType { get; set; }

        public bool? isAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipClassSpecClass> equipClassSpecClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<model> models { get; set; }
    }
}
