namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class b
    {
        [Key]
        public int i { get; set; }

        [StringLength(300)]
        public string s { get; set; }
    }
}
