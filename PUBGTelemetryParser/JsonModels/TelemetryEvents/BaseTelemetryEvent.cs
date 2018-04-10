using System;
using Newtonsoft.Json;
using PUBGTelemetryParser.Converters;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// The base telemtry event.
    /// The base events that all telemetry events will provide somehow.
    /// </summary>
    public abstract class BaseTelemetryEvent
    {
        public BaseTelemetryEvent(TelemetryEvent telemetryEvent)
        {
            Version = telemetryEvent.Version;
            EventTime = telemetryEvent.EventTime;
            EventType = telemetryEvent.EventType;
            GameStage = telemetryEvent.Common?.GameStage ?? 0;
        }

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
        /// The games stage
        /// 0.1 = before first circle, 1.0 = first white circle, 1.5 = blue circle moves, etc...
        /// </summary>
        [JsonProperty("isGame")]
        public float GameStage { get; set; }
    }
}
