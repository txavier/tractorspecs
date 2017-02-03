using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorSpecs.Core.Models
{
    public partial class make
    {
        [NotMapped]
        public int? modelCountCalculated
        {
            get { return GetModelCount(this.models); }
        }

        private int? GetModelCount(ICollection<model> models)
        {
            if(models == null)
            {
                return null;
            }

            return models.Count;
        }

    }
}
