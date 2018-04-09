using System;
using Newtonsoft.Json;
using PUBGTelemetryParser.Converters;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser
{
    public class TelemetryEvent
    {
        [JsonProperty("_V")]
        public string Version { get; set; }

        /// <summary>
        /// The events timestamp in UTC.
        /// </summary>
        [JsonProperty("_D")]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// The telemtry event type 
        /// </summary>
        [JsonProperty("_T")]
        [JsonConverter(typeof(TelemetryEventTypeConverter))]
        public TelemetryEventType EventType { get; set; }

        /// <summary>
        /// Prives the match id, and map name.
        /// PC Only Telemetry data at this time. 
        /// </summary>
        public Common Common { get; set; }

        /// <summary>
        /// The item package/care package that is associated with care package events.
        /// </summary>
        public ItemPackage ItemPackage { get; set; }
    }
}
