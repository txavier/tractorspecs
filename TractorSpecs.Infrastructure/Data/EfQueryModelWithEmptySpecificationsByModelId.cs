using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorSpecs.Core.Models;
using System.Data.Entity;
using TractorSpecs.Core.Interfaces;

namespace TractorSpecs.Infrastructure.Data
{
    public class EfQueryModelWithEmptySpecificationsByModelId : IEfQueryModelWithEmptySpecificationsByModelId
    {
        private EfDataDbContext _dbContext;

        public EfQueryModelWithEmptySpecificationsByModelId(EfDataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public model GetModelWithEmptySpecificationsByModelId(int modelId)
        {
            var specifications = _dbContext.models.Where(i => i.modelId == modelId).SelectMany(i => i.specifications);

            var allPertinentSpecNames = specifications.SelectMany(i => i.specName.specClass.specNames);

            var specificationSpecNameIds = specifications.Select(j => j.specNameId.Value).ToList();

            var specNamesNotIntersecting = allPertinentSpecNames.Where(i => !specificationSpecNameIds.Contains(i.specNameId));

            var newSpecifications = specNamesNotIntersecting.AsEnumerable().Select(i => new specification
            {
                specNameId = i.specNameId,
                modelId = modelId
            });

            var model = _dbContext.models.SingleOrDefault(i => i.modelId == modelId);

            model.specifications = model.specifications.Concat(newSpecifications).ToList();

            return model;
        }
    }
}
