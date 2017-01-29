namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("attachment")]
    public partial class attachment
    {
        public long? ModelID { get; set; }

        public long? AttachmentID { get; set; }

        [Key]
        public long thisid { get; set; }
    }
}
