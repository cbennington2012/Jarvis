using System;

namespace Jarvis.Domain.Contracts.Configuration
{
    public interface IAppSettingsProvider
    {
        String GetValue(String key);
    }
}
