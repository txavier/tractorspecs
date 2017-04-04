using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Http;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Objects;

namespace TractorSpecs.Controllers
{
    [RoutePrefix("api/clientInformation")]
    public class ClientInformationController : ApiController
    {
        public ClientInformationController(Core.Interfaces.ISettingService settingService)
        {
        }

        [Route("getClientIp")]
        [HttpGet]
        public IHttpActionResult GetClientIp()
        {
            var result = HttpContext.Current.Request.UserHostAddress;

            return Ok(result);
        }
    }
}
