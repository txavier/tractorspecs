namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apiSpecRequest")]
    public partial class apiSpecRequest
    {
        public long apiSpecRequestId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? reqDate { get; set; }

        [StringLength(50)]
        public string apiKey { get; set; }

        [StringLength(500)]
        public string priorityNotes { get; set; }

        [StringLength(500)]
        public string make { get; set; }

        [StringLength(500)]
        public string model { get; set; }
    }
}
