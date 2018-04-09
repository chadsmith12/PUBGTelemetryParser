using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PUBGTelemetryParser;
using PUBGTelemetryParser.Enums;

namespace TelemetrySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "sampleTelemetry.json";
            var jsonString = File.ReadAllText(fileName);
            var telemtry = JsonConvert.DeserializeObject<IList<TelemetryEvent>>(jsonString);
            var carePackages = telemtry.Where(x => x.EventType == TelemetryEventType.CarePackageSpawn).Select(x => x.ItemPackage);
        }
    }
}
