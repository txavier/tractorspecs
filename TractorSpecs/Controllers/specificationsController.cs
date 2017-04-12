using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoClutch.Core.Interfaces;
using AutoClutch.Controller;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Interfaces;
using System.Web.OData;

namespace TractorSpecs.Controllers
{
    public class specificationsController : ODataApiController<specification>
    {
        private IEfQueryModelWithEmptySpecificationsByModelId _efQueryModelWithEmptySpecificationsByModelId;

        public specificationsController(IService<specification> specificationService, 
            Core.Interfaces.IEfQueryModelWithEmptySpecificationsByModelId efQueryModelWithEmptySpecificationsByModelId)
            : base(specificationService)
        {
            _efQueryModelWithEmptySpecificationsByModelId = efQueryModelWithEmptySpecificationsByModelId;
        }

        [EnableQuery]
        public IHttpActionResult GetModelWithEmptySpecificationsByModelId(int modelId)
        {
            var result = _efQueryModelWithEmptySpecificationsByModelId.GetModelWithEmptySpecificationsByModelId2(modelId);

            return Ok(result);
        }
    }
}