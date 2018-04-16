using System;
using Newtonsoft.Json;

namespace PUBGTelemetryParser.Extensions
{
    public static class EnumSerializeExtensions
    {
        public static string Serialize(this Enum currentEnum)
        {
            return JsonConvert.SerializeObject(currentEnum);
        }
    }
}
