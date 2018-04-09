using System.Collections.Generic;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// The root object of a PUBG telemetry file.
    /// Holds all the telemetry events that happened in a match.
    /// </summary>
    public class PubgTelemetry
    {
        /// <summary>
        /// List of the event objects during a match.
        /// </summary>
        public IList<TelemetryEvent> Events { get; set; }
    }
}