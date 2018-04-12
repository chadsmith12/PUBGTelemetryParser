namespace PUBGTelemetryParser
{
    public class Character
    {
        /// <summary>
        /// This characters account id.
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// The players name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The id of the team they are on.
        /// </summary>
        public int TeamId { get; set; }
        /// <summary>
        /// The current health of the caracter at a point in time.
        /// </summary>
        public float Health { get; set; }
        /// <summary>
        /// The current location of the character a point in time.
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// The ranking of the character.
        /// </summary>
        public int Ranking { get; set; }
    }
}
