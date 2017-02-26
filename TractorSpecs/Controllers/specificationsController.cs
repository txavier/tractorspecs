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

        public specificationsController(IService<specification> specificationService, ILogService<specification> specificationLogService,
            Core.Interfaces.IEfQueryModelWithEmptySpecificationsByModelId efQueryModelWithEmptySpecificationsByModelId)
            : base(specificationService, specificationLogService)
        {
            _efQueryModelWithEmptySpecificationsByModelId = efQueryModelWithEmptySpecificationsByModelId;
        }

        [EnableQuery]
        public IHttpActionResult GetModelWithEmptySpecificationsByModelId(int modelId)
        {
            var result = _efQueryModelWithEmptySpecificationsByModelId.GetModelWithEmptySpecificationsByModelId2(modelId);

            //_modelService.LazyLoadingEnabled = false;

            //_modelService.ProxyCreationEnabled = false;

            //_modelService.ValidateOnSaveEnabled = false;

            //var result1 = _modelService.Queryable().Where(i => i.modelId == modelId).ToList();

            //result1.Add(result);

            //return Ok(result1);

            return Ok(result);
        }
    }
}