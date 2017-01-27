namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APIkey
    {
        [Key]
        public long thisID { get; set; }

        [Column("APIkey")]
        [StringLength(50)]
        public string APIkey1 { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public bool? AllowGetSpecs { get; set; }
    }
}
