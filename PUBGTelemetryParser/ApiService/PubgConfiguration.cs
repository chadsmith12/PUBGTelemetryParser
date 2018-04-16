using System;

namespace PUBGTelemetryParser.ApiService
{
    public static class PubgConfiguration
    {
        internal static string ApiKey { get; private set; }
        internal static bool Verbose { get; private set; }

        public static void Configure(Action<ConfigSettings> settingsConfig)
        {
            if (settingsConfig == null)
            {
                throw new ArgumentNullException(nameof(settingsConfig), "Invalid Api Configuration");
            }
            var configSetting = new ConfigSettings();
            settingsConfig(configSetting);

            ApiKey = configSetting.ApiKey;
            Verbose = configSetting.Verbose;
        }
    }
}
