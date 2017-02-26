using Microsoft.VisualStudio.TestTools.UnitTesting;
using TractorSpecs.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorSpecs.Core.Interfaces;

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

            var efQueryModelWithEmptySpecificationByModelId = container.GetInstance<IEfQueryModelWithEmptySpecificationsByModelId>();

            // Act.
            var result = efQueryModelWithEmptySpecificationByModelId.GetModelWithEmptySpecificationsByModelId2(7655);

            // Assert.
            Assert.IsTrue(result.Count() == 231);
        }

        [TestMethod()]
        public void HaveUniqueSpecifications()
        {
            // Arrange.
            var container = TractorSpecs.DependencyResolution.IoC.Initialize();

            var efQueryModelWithEmptySpecificationByModelId = container.GetInstance<IEfQueryModelWithEmptySpecificationsByModelId>();

            // Act.
            var result = efQueryModelWithEmptySpecificationByModelId.GetModelWithEmptySpecificationsByModelId2(7655);

            // Assert.
            Assert.IsTrue(result.Count() == result.Distinct().Count());

            var result2 = result.Where(i => i.specName.displayName == "Cold-cranking amps");

            Assert.IsTrue(result2.Count() == 1);
        }
    }
}