using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoClutch.Core.Interfaces;
using AutoClutch.Controller;
using TractorSpecs.Core.Models;
using System.Web;
using System.Threading.Tasks;
using TractorSpecs.Core.Interfaces;

namespace TractorSpecs.Controllers
{
    public class modelPicturesController : ODataApiController<modelPicture>
    {
        public modelPicturesController(IModelPictureService modelPictureService)
            : base(modelPictureService, null)
        {
        }

        public override Task<IHttpActionResult> Post(modelPicture entity)
        {
            entity.filename = Guid.NewGuid().ToString().Split('-').FirstOrDefault() + "." + entity.filename.Split('.').LastOrDefault();

            return base.Post(entity);
        }
    }
}