namespace TractorSpecs.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Model_Alias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ModelAliasID { get; set; }

        public long? ModelID { get; set; }

        [StringLength(50)]
        public string AliasName { get; set; }

        [StringLength(50)]
        public string AliasDescription { get; set; }
    }
}
