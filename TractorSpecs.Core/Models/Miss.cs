namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class miss
    {
        public long missId { get; set; }

        [StringLength(50)]
        public string make { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        public int? misses { get; set; }
    }
}
