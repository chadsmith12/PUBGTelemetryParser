using System.Collections.Generic;
using Newtonsoft.Json;

namespace PUBGTelemetryParser.ApiResponses
{
    public class FindPlayersResponse
    {
        [JsonProperty("data")]
        public List<PlayerInfo> PlayerInfo { get; set; }

        public PlayerRequestLinks Links { get; set; }

        public Meta Meta { get; set; }
    }
}
