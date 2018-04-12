namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a a LOGPLAYERLOGOUT
    /// </summary>
    public class PlayerLogout : BaseTelemetryEvent
    {
        public PlayerLogout(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            AccountId = telemetryEvent.AccountId;
        }

        /// <summary>
        /// The id of the account that signed out.
        /// </summary>
        public string AccountId { get; set; }
    }
}
