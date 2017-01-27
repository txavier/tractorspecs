namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class make
    {
        [Key]
        public long mfgID { get; set; }

        [StringLength(50)]
        public string mfgName { get; set; }

        [StringLength(50)]
        public string mfgURL { get; set; }

        [StringLength(1000)]
        public string mfgDesc { get; set; }

        [StringLength(500)]
        public string mfgLogoImg { get; set; }

        [StringLength(50)]
        public string mfgImg { get; set; }

        public decimal? mfgValueAdjust { get; set; }

        [StringLength(50)]
        public string mfgLink { get; set; }
    }
}
