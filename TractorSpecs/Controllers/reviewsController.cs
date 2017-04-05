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
    public class reviewsController : ODataApiController<review>
    {
        public reviewsController(IService<review> reviewService)
            : base(reviewService)
        { }
    }
}