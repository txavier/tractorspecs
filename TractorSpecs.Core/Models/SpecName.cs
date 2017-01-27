namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SpecName
    {
        public long SpecNameID { get; set; }

        [Column("SpecName")]
        [StringLength(50)]
        public string SpecName1 { get; set; }

        public long? SpecClass { get; set; }

        [StringLength(50)]
        public string SpecMeasure { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public bool? isOption { get; set; }
    }
}
