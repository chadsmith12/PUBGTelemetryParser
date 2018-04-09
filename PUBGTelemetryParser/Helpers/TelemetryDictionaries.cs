using System.Collections.Generic;
using Newtonsoft.Json;

namespace PUBGTelemetryParser.Helpers
{
    /// <summary>
    /// Represents the different dictionaries that map to different telemetry values.
    /// Taken from https,//github.com/pubg/api-assets/tree/master/dictionaries/telemetry
    /// </summary>
    public static class TelemetryDictionaries
    {
        private static readonly string ItemIdJsonString = ResourceManifestReader.ReadText("telemetryDictionaries.itemId.json");
        private static Dictionary<string, string> _itemIds;

        public static Dictionary<string, string> ItemIds =>
            _itemIds ?? (_itemIds = JsonConvert.DeserializeObject<Dictionary<string, string>>(ItemIdJsonString));
    }
}
