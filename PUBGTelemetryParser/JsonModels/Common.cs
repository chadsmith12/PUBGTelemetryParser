using Newtonsoft.Json;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Common elements to each telemetry event. 
    /// This is only used on PC Telemtry files. Will be null on XBox.
    /// </summary>
    public class Common
    {
        /// <summary>
        /// The id of this match.
        /// </summary>
        public string MatchId { get; set; }
        /// <summary>
        /// The map name.
        /// <see cref="FriendlyMapName"/> to get the map's name that you can display.
        /// </summary>
        public string MapName { get; set; }
        /// <summary>
        /// The games stage
        /// 0.1 = before first circle, 1.0 = first white circle, 1.5 = blue circle moves, etc...
        /// </summary>
        [JsonProperty("isGame")]
        public float GameStage { get; set; }

        /// <summary>
        /// Gives you the friendly map name.
        /// If the friendly map name is not known at this time will just return <see cref="MapName"/>
        /// </summary>
        [JsonIgnore]
        public string FriendlyMapName
        {
            get
            {
                switch (MapName)
                {
                    case "Desert_Main":
                        return "Miramar";
                    case "Erangel_Main":
                        return "Erangel";
                    default:
                        return MapName;
                }
            }
        }
    }
}
