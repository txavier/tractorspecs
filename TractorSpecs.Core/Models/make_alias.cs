namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class make_alias
    {
        [Key]
        public long ThisID { get; set; }

        [StringLength(50)]
        public string MfgAlias { get; set; }

        public long? MfgID { get; set; }
    }
}
