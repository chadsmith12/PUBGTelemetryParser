using System;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.Converters
{
    public class VehicleTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var vehicleType = (VehicleType)value;

            switch (vehicleType)
            {
                case VehicleType.FloatingVehicle:
                    writer.WriteValue(VehicleType.FloatingVehicle.ToString());
                    break;
                case VehicleType.Parachute:
                    writer.WriteValue(VehicleType.Parachute.ToString());
                    break;
                case VehicleType.TransportAircraft:
                    writer.WriteValue(VehicleType.TransportAircraft.ToString());
                    break;
                case VehicleType.WheeledVehicle:
                    writer.WriteValue(VehicleType.WheeledVehicle.ToString());
                    break;
                case VehicleType.Unknown:
                    writer.WriteValue("");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var stringValue = reader.Value as string;
            stringValue = stringValue.ToLower();

            switch (stringValue)
            {
                case "FloatingVehicle":
                    return VehicleType.FloatingVehicle;
                case "Parachute":
                    return VehicleType.Parachute;
                case "TransportAircraft":
                    return VehicleType.TransportAircraft;
                case "WheeledVehicle":
                    return VehicleType.WheeledVehicle;
                default:
                    return VehicleType.Unknown;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
