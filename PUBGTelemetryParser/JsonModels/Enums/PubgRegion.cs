using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PUBGTelemetryParser.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgRegion
    {
        [EnumMember(Value = "xbox-as")]
        XboxAsia,

        [EnumMember(Value = "xbox-eu")]
        XboxEurope,

        [EnumMember(Value = "xbox-na")]
        XboxNorthAmerica,

        [EnumMember(Value = "xbox-oc")]
        XboxOceania,

        [EnumMember(Value = "pc-as")]
        PcAsia,

        [EnumMember(Value = "pc-eu")]
        PcEurope,

        [EnumMember(Value = "pc-kakao")]
        PcKakao,

        [EnumMember(Value = "pc-krjp")]
        PcKorea,

        [EnumMember(Value = "pc-jp")]
        PcJapan,

        [EnumMember(Value = "pc-na")]
        PcNorthAmerica,

        [EnumMember(Value = "pc-oc")]
        PcOceania,

        [EnumMember(Value = "pc-sa")]
        PcSouthAndCentralAmerica,

        [EnumMember(Value = "pc-sea")]
        PcSouthEastAsia
    }
}