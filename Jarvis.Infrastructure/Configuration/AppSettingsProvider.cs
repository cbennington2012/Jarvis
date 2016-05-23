using System;
using System.Configuration;
using Jarvis.Domain.Contracts.Configuration;

namespace Jarvis.Infrastructure.Configuration
{
    public class AppSettingsProvider : IAppSettingsProvider
    {
        public String GetValue(String key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
