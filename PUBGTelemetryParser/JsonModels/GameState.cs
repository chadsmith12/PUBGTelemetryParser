namespace PUBGTelemetryParser
{
    public class GameState
    {
        /// <summary>
        /// The total elapsed time of the game
        /// </summary>
        public int ElapsedTime { get; set; }
        /// <summary>
        /// Numer of teams alive
        /// </summary>
        public int NumberAliveTeams { get; set; }
        /// <summary>
        /// Number of players that started the game
        /// </summary>
        public int NumberStartPlayers { get; set; }
        /// <summary>
        /// Number of players that alive at this time
        /// </summary>
        public int NumberAlivePlayers { get; set; }
        /// <summary>
        /// the current position of the circle
        /// </summary>
        public Location SafetyZonePosition { get; set; }
        /// <summary>
        /// The radius of the circle.
        /// </summary>
        public float SafetyZoneRadius { get; set; }
        /// <summary>
        /// the position of the poison gas
        /// </summary>
        public Location PoisonGasWarningPosition { get; set; }
        /// <summary>
        /// the radius of the poison gas
        /// </summary>
        public float PoisonGasWarningRadius { get; set; }
        /// <summary>
        /// position of the red zone
        /// </summary>
        public Location RedZonePosition { get; set; }
        /// <summary>
        /// the radius of the red zone
        /// </summary>
        public float RedZoneRadius { get; set; }
    }
}
