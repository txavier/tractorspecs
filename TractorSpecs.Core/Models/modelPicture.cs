namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modelPicture")]
    public partial class modelPicture
    {
        public int modelPictureId { get; set; }

        [StringLength(50)]
        public string filename { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public long? modelId { get; set; }

        public virtual model model { get; set; }
    }
}
