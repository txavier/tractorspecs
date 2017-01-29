namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("equipClassSpecClass")]
    public partial class equipClassSpecClass
    {
        public int? specClassId { get; set; }

        public int? equipmentClassId { get; set; }

        public int equipClassSpecClassId { get; set; }

        public virtual equipmentClass equipmentClass { get; set; }
    }
}
