using System;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.Converters
{
    /// <summary>
    /// Used to convert the different event types that the pubg api telemetry event object gives you into an enum.
    /// </summary>
    public class TelemetryEventTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var eventType = (TelemetryEventType) value;

            switch (eventType)
            {
                case TelemetryEventType.PlayerLogin:
                    writer.WriteValue(TelemetryEventType.PlayerLogin.ToString());
                    break;
                case TelemetryEventType.PlayerCreate:
                    writer.WriteValue(TelemetryEventType.PlayerCreate.ToString());
                    break;
                case TelemetryEventType.PlayerPosition:
                    writer.WriteValue(TelemetryEventType.PlayerPosition.ToString());
                    break;
                case TelemetryEventType.PlayerAttack:
                    writer.WriteValue(TelemetryEventType.PlayerAttack.ToString());
                    break;
                case TelemetryEventType.ItemPickup:
                    writer.WriteValue(TelemetryEventType.ItemPickup.ToString());
                    break;
                case TelemetryEventType.ItemEquip:
                    writer.WriteValue(TelemetryEventType.ItemEquip.ToString());
                    break;
                case TelemetryEventType.ItemUnequip:
                    writer.WriteValue(TelemetryEventType.ItemUnequip.ToString());
                    break;
                case TelemetryEventType.VehicleRide:
                    writer.WriteValue(TelemetryEventType.VehicleRide.ToString());
                    break;
                case TelemetryEventType.MatchDefinition:
                    writer.WriteValue(TelemetryEventType.MatchDefinition.ToString());
                    break;
                case TelemetryEventType.MatchStart:
                    writer.WriteValue(TelemetryEventType.MatchStart.ToString());
                    break;
                case TelemetryEventType.GameStatePeriodic:
                    writer.WriteValue(TelemetryEventType.GameStatePeriodic.ToString());
                    break;
                case TelemetryEventType.VehicleLeave:
                    writer.WriteValue(TelemetryEventType.VehicleLeave.ToString());
                    break;
                case TelemetryEventType.PlayerTakeDamage:
                    writer.WriteValue(TelemetryEventType.PlayerTakeDamage.ToString());
                    break;
                case TelemetryEventType.PlayerLogout:
                    writer.WriteValue(TelemetryEventType.PlayerLogout.ToString());
                    break;
                case TelemetryEventType.ItemAttach:
                    writer.WriteValue(TelemetryEventType.ItemAttach.ToString());
                    break;
                case TelemetryEventType.ItemDrop:
                    writer.WriteValue(TelemetryEventType.ItemDrop.ToString());
                    break;
                case TelemetryEventType.PlayerKill:
                    writer.WriteValue(TelemetryEventType.PlayerKill.ToString());
                    break;
                case TelemetryEventType.ItemDetach:
                    writer.WriteValue(TelemetryEventType.ItemDetach.ToString());
                    break;
                case TelemetryEventType.ItemUse:
                    writer.WriteValue(TelemetryEventType.ItemUse.ToString());
                    break;
                case TelemetryEventType.CarePackageSpawn:
                    writer.WriteValue(TelemetryEventType.CarePackageSpawn.ToString());
                    break;
                case TelemetryEventType.VehicleDestroy:
                    writer.WriteValue(TelemetryEventType.VehicleDestroy.ToString());
                    break;
                case TelemetryEventType.CarePackageLand:
                    writer.WriteValue(TelemetryEventType.CarePackageLand.ToString());
                    break;
                case TelemetryEventType.MatchEnd:
                    writer.WriteValue(TelemetryEventType.MatchEnd.ToString());
                    break;
                case TelemetryEventType.Unknown:
                    writer.WriteValue(TelemetryEventType.Unknown.ToString());
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
                case "logplayerlogin":
                    return TelemetryEventType.PlayerLogin;
                case "logplayercreate":
                    return TelemetryEventType.PlayerCreate;
                case "logplayerposition":
                    return TelemetryEventType.PlayerPosition;
                case "logplayerattack":
                    return TelemetryEventType.PlayerAttack;
                case "logitempickup":
                    return TelemetryEventType.ItemPickup;
                case "logitemequip":
                    return TelemetryEventType.ItemEquip;
                case "logitemunequip":
                    return TelemetryEventType.ItemUnequip;
                case "logvehicleride":
                    return TelemetryEventType.VehicleRide;
                case "logmatchdefinition":
                    return TelemetryEventType.MatchDefinition;
                case "logmatchstart":
                    return TelemetryEventType.MatchStart;
                case "loggamestateperiodic":
                    return TelemetryEventType.GameStatePeriodic;
                case "logvehicleleave":
                    return TelemetryEventType.VehicleLeave;
                case "logplayertakedamage":
                    return TelemetryEventType.PlayerTakeDamage;
                case "logplayerlogout":
                    return TelemetryEventType.PlayerLogout;
                case "logitemattach":
                    return TelemetryEventType.ItemAttach;
                case "logitemdrop":
                    return TelemetryEventType.ItemDrop;
                case "logplayerkill":
                    return TelemetryEventType.PlayerKill;
                case "logitemdetach":
                    return TelemetryEventType.ItemDetach;
                case "logitemuse":
                    return TelemetryEventType.ItemUse;
                case "logcarepackagespawn":
                    return TelemetryEventType.CarePackageSpawn;
                case "logvehicledestroy":
                    return TelemetryEventType.VehicleDestroy;
                case "logcarepackageland":
                    return TelemetryEventType.CarePackageLand;
                case "logmatchend":
                    return TelemetryEventType.MatchEnd;
                default:
                    // in case some other unknown event if the api changes we can easily cover it here
                    return TelemetryEventType.Unknown;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
