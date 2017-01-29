namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rssDealerID")]
    public partial class rssDealerID
    {
        [StringLength(50)]
        public string dealerid { get; set; }

        [Key]
        public int thisID { get; set; }
    }
}
