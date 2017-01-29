namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("link")]
    public partial class link
    {
        public long linkId { get; set; }

        [StringLength(200)]
        public string linkURL { get; set; }

        [StringLength(100)]
        public string linkText { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public bool? showFlag { get; set; }

        public long? modelId { get; set; }

        public virtual model model { get; set; }
    }
}
