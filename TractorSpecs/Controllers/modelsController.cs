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
    public class modelsController : ODataApiController<model>
    {
        private IEfQueryModelWithEmptySpecificationsByModelId _efQueryModelWithEmptySpecificationsByModelId;
        private IModelService _modelService;

        public modelsController(IModelService modelService, ILogService<model> modelLogService, 
            IEfQueryModelWithEmptySpecificationsByModelId efQueryModelWithEmptySpecificationsByModelId)
            : base(modelService, modelLogService)
        {
            _efQueryModelWithEmptySpecificationsByModelId = efQueryModelWithEmptySpecificationsByModelId;

            _modelService = modelService;
        }

        //[EnableQuery]
        public IHttpActionResult GetModelWithEmptySpecificationsByModelId(int modelId)
        {
            var result = _efQueryModelWithEmptySpecificationsByModelId.GetModelWithEmptySpecificationsByModelId(modelId);

            //_modelService.LazyLoadingEnabled = false;

            //_modelService.ProxyCreationEnabled = false;

            //_modelService.ValidateOnSaveEnabled = false;

            var result1 = _modelService.Queryable().Where(i => i.modelId == modelId).ToList();

            result1.Add(result);

            //return Ok(result1);

            return Ok(result);
        }
    }
}