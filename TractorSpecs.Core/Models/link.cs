namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class link
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long linkID { get; set; }

        [StringLength(200)]
        public string linkURL { get; set; }

        [StringLength(100)]
        public string linkText { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public bool? showFlag { get; set; }

        public long? modelID { get; set; }
    }
}
