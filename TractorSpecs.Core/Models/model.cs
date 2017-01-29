namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class model
    {
        public long modelID { get; set; }

        public long? mfgID { get; set; }

        public decimal? msrp { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        public string modelnumber { get; set; }

        [StringLength(50)]
        public string modelURL { get; set; }

        public int? classID { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public DateTime? dte { get; set; }

        public long? pageviews { get; set; }
    }
}
