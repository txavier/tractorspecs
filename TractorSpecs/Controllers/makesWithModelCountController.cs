using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoClutch.Core.Interfaces;
using AutoClutch.Controller;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Objects;

namespace TractorSpecs.Controllers
{
    public class makesWithModelCountController : ODataApiController<makesWithModelCount>
    {
        public makesWithModelCountController(IService<makesWithModelCount> makesWithModelCountService, 
            ILogService<makesWithModelCount> makesWithModelCountLogService)
            : base(makesWithModelCountService, makesWithModelCountLogService)
        { }
    }
}