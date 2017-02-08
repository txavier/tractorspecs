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
    public class makesController : ODataApiController<make>
    {
        private IService<make> _makeService;

        public makesController(IService<make> makeService, ILogService<make> makeLogService)
            : base(makeService, makeLogService)
        {
            _makeService = makeService;
        }

        [EnableQuery]
        public IHttpActionResult GetMakesWithModelsCount()
        {
            var result = _makeService.Queryable().OrderByDescending(i => i.models.Count);

            return Ok(result);
        }
    }
}