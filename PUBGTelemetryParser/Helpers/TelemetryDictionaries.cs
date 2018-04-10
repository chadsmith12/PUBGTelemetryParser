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
        private static readonly string DamageCauserNameJsonString = ResourceManifestReader.ReadText("telemetryDictionaries.damageCauserName.json");
        private static readonly string DamageTypeCategoryJsonString = ResourceManifestReader.ReadText("telemetryDictionaries.damageTypeCategory.json");
        private static readonly string VehicleIdJsonString = ResourceManifestReader.ReadText("telemetryDictionaries.vehicleId.json");
        private static readonly string MapNameJsonString = ResourceManifestReader.ReadText("telemetryDictionaries.mapName.json");


        private static Dictionary<string, string> _itemIds;
        private static Dictionary<string, string> _damageCauserNames;
        private static Dictionary<string, string> _damageTypeCategories;
        private static Dictionary<string, string> _vehicleIds;
        private static Dictionary<string, string> _mapNames;

        /// <summary>
        /// Dictionary to convert an item id to its friendly display name.
        /// </summary>
        public static Dictionary<string, string> ItemIds =>
            _itemIds ?? (_itemIds = JsonConvert.DeserializeObject<Dictionary<string, string>>(ItemIdJsonString));

        /// <summary>
        /// Dictionary to convert a damage causer to its friendly display name.
        /// </summary>
        public static Dictionary<string, string> DamageCauserNames => 
            _damageCauserNames ?? (_damageCauserNames =JsonConvert.DeserializeObject<Dictionary<string, string>>(DamageCauserNameJsonString));

        /// <summary>
        /// Dictionary to convert the damage type categories.
        /// </summary>
        public static Dictionary<string, string> DamageTypeCategories =>
            _damageTypeCategories ?? (_damageTypeCategories = JsonConvert.DeserializeObject<Dictionary<string, string>>(DamageTypeCategoryJsonString));

        /// <summary>
        /// Dictionary to convert a vehicle it to it's friendly name.
        /// </summary>
        public static Dictionary<string, string> VehicleIds =>
            _vehicleIds ?? (_vehicleIds = JsonConvert.DeserializeObject<Dictionary<string, string>>(VehicleIdJsonString));        
        
        /// <summary>
        /// Dictionary to convert the map id to a friendly map name.
        /// </summary>
        public static Dictionary<string, string> MapNames =>
            _mapNames ?? (_mapNames = JsonConvert.DeserializeObject<Dictionary<string, string>>(MapNameJsonString));
    }
}
