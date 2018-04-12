namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGGAMESTATEPERIODIC event.
    /// </summary>
    public class GameState : BaseTelemetryEvent
    {
        public GameState(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            CurrentState = telemetryEvent.GameState;
        }

        /// <summary>
        /// Details of the current state of the match.
        /// </summary>
        public PUBGTelemetryParser.GameState CurrentState { get; set; }
    }
}
