namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APISpecTracker")]
    public partial class APISpecTracker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ThisID { get; set; }

        [StringLength(50)]
        public string ApiKey { get; set; }

        public long? ModelID { get; set; }
    }
}
