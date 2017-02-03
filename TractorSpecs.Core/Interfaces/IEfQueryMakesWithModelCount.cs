using System.Collections.Generic;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Objects;

namespace TractorSpecs.Core.Interfaces
{
    public interface IEfQueryMakesWithModelCount
    {
        IEnumerable<make> QueryMakesWithModelCount(int? take);
    }
}