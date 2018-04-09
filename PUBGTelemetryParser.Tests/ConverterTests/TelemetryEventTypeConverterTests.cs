using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.Tests.TestModels;

namespace PUBGTelemetryParser.Tests.ConverterTests
{
    [TestClass]
    public class TelemetryEventTypeConverterTest
    {
        [TestMethod]
        public void DeserializeTest()
        {
            var expectations = MapTelemetryEventTypes();

            foreach (var item in expectations)
            {
                var jsonString = $"{{\"_T\" : \"{item.Key}\"}}";
                var deserializedObject = JsonConvert.DeserializeObject<TestEvent>(jsonString);
                Assert.AreEqual(item.Value, deserializedObject.EventType);
            }
        }

        private Dictionary<string, TelemetryEventType> MapTelemetryEventTypes()
        {
            var telemetryEvents = ((TelemetryEventType[])Enum.GetValues(typeof(TelemetryEventType))).Select(x => new
            {
                Key = x.ToString().ToLower(),
                Value = x
            });

            return telemetryEvents.ToDictionary(x => $"log{x.Key}", x => x.Value);
        }
    }
}
