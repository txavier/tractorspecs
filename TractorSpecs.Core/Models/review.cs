namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class review
    {
        public long reviewID { get; set; }

        [StringLength(8000)]
        public string reviewText { get; set; }

        public int? reviewScore { get; set; }

        public DateTime? reviewDate { get; set; }

        [StringLength(50)]
        public string reviewName { get; set; }

        [StringLength(20)]
        public string ip { get; set; }

        public long? unitid { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}