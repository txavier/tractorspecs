using AutoClutch.Core.Interfaces;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClutch.Core.Interfaces;

namespace TractorSpecs.Core.Services
{
    /// <summary>
    /// http://jonsamwell.com/url-route-authorization-and-security-in-angular/#interception
    /// </summary>
    public class AuthorizeService : IAuthorizeService
    {
        private IService<user> _engineerService;

        public AuthorizeService(IService<user> engineerService)
        {
            _engineerService = engineerService;
        }

        public string IsAuthorized(string userName, bool? loginRequired, string permissionCheckType, string requiredPermissions, string uri,
            List<KeyValuePair<string, string>> parameters)
        {
            var isAuthorized = "notAuthorized";

            isAuthorized = "authorized";

            //isAuthorized = "readOnly";

            return isAuthorized;
        }

    }
}
