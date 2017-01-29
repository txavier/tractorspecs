namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("equipmentClass")]
    public partial class equipmentClass
    {
        [Key]
        public int classID { get; set; }

        [StringLength(50)]
        public string ClassName { get; set; }

        [StringLength(50)]
        public string ClassURL { get; set; }

        public int? TRAtype { get; set; }

        public bool? isAttachment { get; set; }
    }
}
