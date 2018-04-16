using Newtonsoft.Json;

namespace PUBGTelemetryParser.ApiResponses
{
    public class PlayerInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The attributes of the player.
        /// </summary>
        public PlayerAttributes Attributes { get; set; }

        public Relationships Relationships { get; set; }
    }
}
