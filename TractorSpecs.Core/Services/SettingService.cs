using AutoClutch.Repo.Interfaces;
using TractorSpecs.Core.Interfaces;
using TractorSpecs.Core.Models;
using TractorSpecs.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClutch.Core;

namespace TractorSpecs.Core.Services
{
    public class SettingService : Service<setting>, ISettingService
    {
        private IEnvironmentConfigSettingsGetter _environmentConfigSettingsGetter;
        private readonly IRepository<setting> _settingRepository;

        public SettingService(IRepository<setting> settingRepository, IEnvironmentConfigSettingsGetter environmentConfigSettingsGetter)
            : base(settingRepository)
        {
            _settingRepository = settingRepository;

            _environmentConfigSettingsGetter = environmentConfigSettingsGetter;
        }

        public setting GetEnvironmentSettingBySettingKey(string settingKey)
        {
            var result = _environmentConfigSettingsGetter.GetValueByKey(settingKey);

            var newSetting = new setting { settingKey = settingKey, settingValue = result };

            return newSetting;
        }

        public setting GetSettingBySettingKey(string settingKey)
        {
            var result = base.Get(filter: i => i.settingKey == settingKey).SingleOrDefault();

            return result;
        }

        public string GetSettingValueBySettingKey(string settingKey)
        {
            //if (settingKey == "version")
            //{
            //    var version = _systemSettingsService.GetProductVersion();

            //    return version;
            //}

            var result = GetSettingBySettingKey(settingKey);

            var value = result.settingValue;

            return value;
        }

    }
}
