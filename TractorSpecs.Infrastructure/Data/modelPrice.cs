namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modelPrice")]
    public partial class modelPrice
    {
        public long? modelId { get; set; }

        public long modelPriceId { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public DateTime? date { get; set; }

        public int? condition { get; set; }

        [Column(TypeName = "text")]
        public string notes { get; set; }

        [StringLength(50)]
        public string traPicId { get; set; }

        [StringLength(10)]
        public string modelYear { get; set; }

        [StringLength(10)]
        public string DorP { get; set; }

        public virtual model model { get; set; }
    }
}
