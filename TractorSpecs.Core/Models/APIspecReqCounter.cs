namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APIspecReqCounter")]
    public partial class APIspecReqCounter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long thisid { get; set; }

        [StringLength(50)]
        public string API_key { get; set; }

        public long? ReqCount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StatDate { get; set; }
    }
}
