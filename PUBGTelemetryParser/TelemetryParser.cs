using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser
{
    public static class TelemetryParser
    {
        public static PubgMatch TelemetryToMatch(string telemetryFile)
        {
            var jsonString = File.ReadAllText(telemetryFile);
            var telemtry = JsonConvert.DeserializeObject<IList<TelemetryEvent>>(jsonString);
            var matchDetails = new PubgMatch
            {
                MatchId = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).Common.MatchId,
                MapName = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).Common.FriendlyMapName,
                MatchStartTime = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).EventTime,
                MatchEndTime = telemtry.First(x => x.EventType == TelemetryEventType.MatchEnd).EventTime,
                Characters = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).Characters.Select(x => new Character(x, telemtry))
            };

            return matchDetails;
        }
    }
}
