using System;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.ApiResponses
{
    public class PlayerAttributes
    {
        /// <summary>
        /// The created date.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The updated date.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// the players name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The current patch version.
        /// </summary>
        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }

        /// <summary>
        /// The region the request came from.
        /// </summary>
        [JsonProperty("shardId")]
        public PubgRegion Region { get; set; }
    }
}
