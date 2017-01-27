namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecChangeLog")]
    public partial class SpecChangeLog
    {
        public long? modelID { get; set; }

        public int? SpecID { get; set; }

        [StringLength(50)]
        public string SpecValue { get; set; }

        [StringLength(50)]
        public string IPaddr { get; set; }

        [StringLength(50)]
        public string source { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long thisid { get; set; }
    }
}
