using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoClutch.Core.Interfaces;
using AutoClutch.Controller;
using TractorSpecs.Core.Models;

namespace TractorSpecs.Controllers
{
    public class specificationsController : ODataApiController<specification>
    {
        public specificationsController(IService<specification> specificationService, ILogService<specification> specificationLogService)
            : base(specificationService, specificationLogService)
        { }
    }
}