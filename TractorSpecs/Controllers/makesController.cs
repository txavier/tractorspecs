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

        public IHttpActionResult GetMakesWithModelsCount()
        {
            var result = _makeService.Queryable().AsEnumerable().OrderByDescending(i => i.modelCountCalculated).Take(10);

            return Ok(result);
        }
    }
}