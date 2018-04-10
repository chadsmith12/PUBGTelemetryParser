using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.Tests.TestModels;

namespace PUBGTelemetryParser.Tests.ConverterTests
{
    [TestClass]
    public class VehicleTypeConverterTests
    {
        [TestMethod]
        public void DeserializeVehicleTypeTest()
        {
            var vehicleTypes = GetVehicleTypeMapping();
            foreach (var category in vehicleTypes)
            {
                var jsonString = $"{{\"VehicleType\" : \"{category.Key}\"}}";
                var deserializedObject = JsonConvert.DeserializeObject<TestVehicleType>(jsonString);
                Assert.AreEqual(category.Value, deserializedObject.VehicleType);
            }
        }

        private Dictionary<string, VehicleType> GetVehicleTypeMapping()
        {
            var vehicleTypes = (VehicleType[])Enum.GetValues(typeof(VehicleType));

            return vehicleTypes.ToDictionary(x => x.ToString(), x => x);
        }
    }
}
