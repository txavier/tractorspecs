namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class makeAlia
    {
        [Key]
        public long makeAliasId { get; set; }

        [StringLength(50)]
        public string mfgAlias { get; set; }

        public long? makeId { get; set; }

        public virtual make make { get; set; }
    }
}
