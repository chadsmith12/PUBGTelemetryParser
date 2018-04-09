using Newtonsoft.Json;
using PUBGTelemetryParser.Converters;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.Tests.TestModels
{
    public class TestEvent
    {
        [JsonProperty("_T")]
        [JsonConverter(typeof(TelemetryEventTypeConverter))]
        public TelemetryEventType EventType { get; set; }
    }
}
