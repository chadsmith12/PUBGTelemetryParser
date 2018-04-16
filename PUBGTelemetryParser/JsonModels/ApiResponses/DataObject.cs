using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.ApiResponses
{
    public class DataObject
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        public string Id { get; set; }
    }
}
