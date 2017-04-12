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
    public class specChangeLogsController : ODataApiController<specChangeLog>
    {
        public specChangeLogsController(IService<specChangeLog> specChangeLogService)
            : base(specChangeLogService)
        {
        }
    }
}