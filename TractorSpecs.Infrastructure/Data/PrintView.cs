namespace TractorSpecs.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrintView")]
    public partial class PrintView
    {
        [StringLength(50)]
        public string mfgName { get; set; }

        [StringLength(50)]
        public string modelnumber { get; set; }

        [StringLength(50)]
        public string specValue { get; set; }

        [StringLength(50)]
        public string SpecMeasure { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public bool? isOption { get; set; }

        [StringLength(50)]
        public string ClassName { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(500)]
        public string mfgLogoImg { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long modelID { get; set; }

        [StringLength(50)]
        public string mfgURL { get; set; }

        [StringLength(50)]
        public string modelURL { get; set; }
    }
}
