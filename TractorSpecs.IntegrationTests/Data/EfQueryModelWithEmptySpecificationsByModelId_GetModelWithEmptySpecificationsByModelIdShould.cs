using Microsoft.VisualStudio.TestTools.UnitTesting;
using TractorSpecs.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorSpecs.Infrastructure.Data.Tests
{
    [TestClass()]
    public class EfQueryModelWithEmptySpecificationsByModelId_GetModelWithEmptySpecificationsByModelIdShould
    {
        [TestMethod()]
        public void GetModelWithEmptySpecificationsByModelId()
        {
            // Arrange.
            var container = TractorSpecs.DependencyResolution.IoC.Initialize();

            var efQueryModelWithEmptySpecificationByModelId = container.GetInstance<EfQueryModelWithEmptySpecificationsByModelId>();

            // Act.
            var result = efQueryModelWithEmptySpecificationByModelId.GetModelWithEmptySpecificationsByModelId(7655);

            // Assert.
            Assert.IsTrue(result.specifications.Where(i => i.specName.specClassId == 231).Count() == 4);
        }
    }
}