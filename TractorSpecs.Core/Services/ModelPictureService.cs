using AutoClutch.Core;
using AutoClutch.Core.Interfaces;
using AutoClutch.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Models;

namespace TractorSpecs.Core.Services
{
    public class ModelPictureService : Service<modelPicture>, IModelPictureService
    {
        private IFileSaver _fileSaver;

        public ModelPictureService(IRepository<modelPicture> modelPictureRepository, IFileSaver fileSaver)
            : base(modelPictureRepository)
        {
            _fileSaver = fileSaver;
        }

        public override Task<modelPicture> AddAsync(modelPicture entity, string loggedInUserName = null, bool lazyLoadingEnabled = true, bool proxyCreationEnabled = true, bool autoDetectChangesEnabled = true, bool dontSave = false)
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath("~/equimages/");

            if (!string.IsNullOrEmpty(entity.filename))
            {
                _fileSaver.SaveFile(entity.base64String, path + entity.filename);

                if (_fileSaver.Errors.Any())
                {
                    Errors.Concat(_fileSaver.Errors);

                    return null;
                }
            }

            return base.AddAsync(entity, loggedInUserName, lazyLoadingEnabled, proxyCreationEnabled, autoDetectChangesEnabled, dontSave);
        }
    }
}
