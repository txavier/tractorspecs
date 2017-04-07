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
    public class modelPricesController : ODataApiController<modelPrice>
    {
        public modelPricesController(IService<modelPrice> modelPriceService)
            : base(modelPriceService, null)
        { }
    }
}