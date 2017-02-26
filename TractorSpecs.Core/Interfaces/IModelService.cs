using AutoClutch.Core.Interfaces;
using TractorSpecs.Core.Models;

namespace TractorSpecs.Core.Interfaces
{
    public interface IModelService : IService<model>
    {
        model efQueryModelWithEmptySpecificationsByModelId(int modelId);
    }
}