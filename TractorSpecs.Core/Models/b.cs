namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class b
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int i { get; set; }

        [StringLength(300)]
        public string s { get; set; }
    }
}
