namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipClassSpecClass")]
    public partial class EquipClassSpecClass
    {
        public int? SpecClass { get; set; }

        public int? EquClass { get; set; }

        [Key]
        public int thisID { get; set; }
    }
}