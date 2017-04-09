using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorSpecs.Core.Models
{
    public partial class modelPicture
    {
        [NotMapped]
        public string base64String { get; set; }
    }
}
