namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Miss
    {
        [Key]
        public long thisID { get; set; }

        [StringLength(50)]
        public string make { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        public int? misses { get; set; }
    }
}
