namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apiSpecReqCounter")]
    public partial class apiSpecReqCounter
    {
        public long apiSpecReqCounterId { get; set; }

        [StringLength(50)]
        public string apiKey { get; set; }

        public long? reqCount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? statDate { get; set; }
    }
}
