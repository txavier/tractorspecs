using System.Collections.Generic;
using TractorSpecs.Core.Models;

namespace TractorSpecs.Core.Interfaces
{
    public interface IEfQueryModelWithEmptySpecificationsByModelId
    {
        model GetModelWithEmptySpecificationsByModelId(int modelId);
    }
}