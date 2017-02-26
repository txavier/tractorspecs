using AutoClutch.Core.Interfaces;
using AutoClutch.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Interfaces;
using AutoClutch.Core;

namespace TractorSpecs.Core.Services
{
    public class ModelService : Service<model>, IModelService
    {
        private IEfQueryModelWithEmptySpecificationsByModelId _efQueryModelWithEmptySpecificationsByModelId;

        public ModelService(IRepository<model> modelRepository,
            Interfaces.IEfQueryModelWithEmptySpecificationsByModelId efQueryModelWithEmptySpecificationsByModelId)
            : base(modelRepository)
        {
            _efQueryModelWithEmptySpecificationsByModelId = efQueryModelWithEmptySpecificationsByModelId;
        }

        public model efQueryModelWithEmptySpecificationsByModelId(int modelId)
        {
            var result = _efQueryModelWithEmptySpecificationsByModelId.GetModelWithEmptySpecificationsByModelId(modelId);

            return result;
        }
    }
}
