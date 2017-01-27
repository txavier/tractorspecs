namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class modelPicture
    {
        [Key]
        public long picID { get; set; }

        [StringLength(50)]
        public string filename { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public long? UntiID { get; set; }
    }
}
