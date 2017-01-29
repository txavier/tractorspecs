namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("apiKey")]
    public partial class apiKey
    {
        public long apiKeyId { get; set; }

        [Column("apiKey")]
        [StringLength(50)]
        public string apiKey1 { get; set; }

        [StringLength(50)]
        public string companyName { get; set; }

        public bool? allowGetSpecs { get; set; }
    }
}
