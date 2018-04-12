using System;
using System.Linq;
using PUBGTelemetryParser;

namespace TelemetrySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "sampleTelemetry.json";
            var matchDetails = TelemetryParser.TelemetryToMatch(fileName);
            var popularGun = matchDetails.Players.SelectMany(x => x.PlayerKills).Select(x => x.DamageCauser).GroupBy(x => x).OrderByDescending(gp => gp.Count()).Select(x => x.Key).First();

            Console.WriteLine("Map: {0}", matchDetails.MapName);
            Console.WriteLine("Match Started At: {0}", matchDetails.MatchStartTime);
            Console.WriteLine("Match Ended At: {0}", matchDetails.MatchEndTime);
            Console.WriteLine("Total Match Length: {0} minutes", matchDetails.MatchLength.TotalMinutes);
            Console.WriteLine("Most Popular Gun: {0}", popularGun);
        }
    }
}
