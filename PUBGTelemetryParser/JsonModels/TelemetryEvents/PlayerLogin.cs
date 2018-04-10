namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGPLAYERLOGIN Event
    /// </summary>
    public class PlayerLogin : BaseTelemetryEvent
    {
        public PlayerLogin(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Result = telemetryEvent.PlayerLoginResult;
            ErrorMessage = telemetryEvent.ErrorMessage;
            AccountId = telemetryEvent.AccountId;
        }
        /// <summary>
        /// Result of this login.
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// The error message of this login if there was an error.
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// The account id of who attempted to login.
        /// </summary>
        public string AccountId { get; set; }
    }
}
