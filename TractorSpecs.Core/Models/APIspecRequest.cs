namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APIspecRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long thisID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDate { get; set; }

        [StringLength(50)]
        public string API_key { get; set; }

        [StringLength(500)]
        public string PriorityNotes { get; set; }

        [StringLength(500)]
        public string Make { get; set; }

        [StringLength(500)]
        public string Model { get; set; }
    }
}
