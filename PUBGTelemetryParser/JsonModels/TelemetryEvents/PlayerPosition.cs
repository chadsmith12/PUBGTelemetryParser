namespace PUBGTelemetryParser.TelemetryEvents
{
    public class PlayerPosition : BaseTelemetryEvent
    {
        public PlayerPosition(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            ElapsedTime = telemetryEvent.ElapsedTime;
            NumberPlayersAlive = telemetryEvent.NumAlivePlayers;
        }

        /// <summary>
        /// The character for this event
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// Total time elapsed for this position log.
        /// </summary>
        public float ElapsedTime { get; set; }

        /// <summary>
        /// Number of players alive.
        /// </summary>
        public int NumberPlayersAlive { get; set; }
    }
}
