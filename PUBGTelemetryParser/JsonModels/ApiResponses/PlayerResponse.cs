using Newtonsoft.Json;

namespace PUBGTelemetryParser.ApiResponses
{
    public class PlayerResponse
    {
        [JsonProperty("data")]
        public PlayerInfo PlayerInfo { get; set; }

        public PlayerRequestLinks Links { get; set; }

        public Meta Meta { get; set; }
    }
}
