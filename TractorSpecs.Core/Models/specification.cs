namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class specification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long specID { get; set; }

        public long? modelID { get; set; }

        public long? specnameID { get; set; }

        [StringLength(50)]
        public string specValue { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public DateTime? DTE { get; set; }

        [StringLength(100)]
        public string extendedValue { get; set; }
    }
}
