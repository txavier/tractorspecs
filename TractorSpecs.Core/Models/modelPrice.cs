namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class modelPrice
    {
        public long? unitid { get; set; }

        [Key]
        public long thisID { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public DateTime? date { get; set; }

        public int? condition { get; set; }

        [Column(TypeName = "text")]
        public string notes { get; set; }

        [StringLength(50)]
        public string TRApicID { get; set; }

        [StringLength(10)]
        public string modelyear { get; set; }

        [StringLength(10)]
        public string DorP { get; set; }
    }
}
