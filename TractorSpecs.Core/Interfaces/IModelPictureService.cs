using AutoClutch.Core.Interfaces;
using System.Threading.Tasks;
using TractorSpecs.Core.Models;

namespace TractorSpecs.Core.Interfaces
{
    public interface IModelPictureService : IService<modelPicture>
    {
        Task<modelPicture> AddAsync(modelPicture entity, string loggedInUserName = null, bool lazyLoadingEnabled = true, bool proxyCreationEnabled = true, bool autoDetectChangesEnabled = true, bool dontSave = false);
    }
}