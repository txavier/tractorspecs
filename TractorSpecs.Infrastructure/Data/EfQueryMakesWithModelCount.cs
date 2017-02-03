using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Objects;

namespace TractorSpecs.Infrastructure.Data
{
    public class EfQueryMakesWithModelCount : IEfQueryMakesWithModelCount
    {
        private EfDataDbContext _context;

        public EfQueryMakesWithModelCount(EfDataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<make> QueryMakesWithModelCount(int? take)
        {
            var result = _context.makes.Take(take ?? 10).AsEnumerable().OrderByDescending(i => i.modelCountCalculated);

            return result;
        }
    }
}
