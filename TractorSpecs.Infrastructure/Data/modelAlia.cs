namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class modelAlia
    {
        [Key]
        public long modelAliasId { get; set; }

        public long? modelId { get; set; }

        [StringLength(50)]
        public string aliasName { get; set; }

        [StringLength(50)]
        public string aliasDescription { get; set; }

        public virtual model model { get; set; }
    }
}
