namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specChangeLog")]
    public partial class specChangeLog
    {
        public long? modelId { get; set; }

        public long? specificationId { get; set; }

        [StringLength(50)]
        public string specValue { get; set; }

        [StringLength(50)]
        public string ipAddr { get; set; }

        [StringLength(50)]
        public string source { get; set; }

        public long specChangeLogId { get; set; }

        public virtual model model { get; set; }

        public virtual specification specification { get; set; }
    }
}
