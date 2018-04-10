using Newtonsoft.Json;
using PUBGTelemetryParser.Converters;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser
{
    public class Vehicle
    {
        [JsonConverter(typeof(VehicleTypeConverter))]
        public VehicleType VehicleType { get; set; }
        public string VehicleId { get; set; }
        public float HealthPercent { get; set; }
        public float FeulPercent { get; set; }
    }
}
