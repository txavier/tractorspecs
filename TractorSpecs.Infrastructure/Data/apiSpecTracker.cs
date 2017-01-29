namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apiSpecTracker")]
    public partial class apiSpecTracker
    {
        public long apiSpecTrackerId { get; set; }

        [StringLength(50)]
        public string apiKey { get; set; }

        public long? modelId { get; set; }
    }
}
