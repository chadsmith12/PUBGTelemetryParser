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
    public class CategoryTests
    {
        [TestMethod]
        public void DeserializeItemCategoryTest()
        {
            var categories = GetItemCategoryMapping();
            foreach (var category in categories)
            {
                var jsonString = $"{{\"Category\" : \"{category.Key}\"}}";
                var deserializedObject = JsonConvert.DeserializeObject<TestItemCategory>(jsonString);
                Assert.AreEqual(category.Value, deserializedObject.Category);
            }
        }

        [TestMethod]
        public void DeserializeItemSubCategoryTest()
        {
            var subCategories = GetItemSubCategoryMapping();
            foreach (var subCategory in subCategories)
            {
                var jsonString = $"{{\"SubCategory\" : \"{subCategory.Key}\"}}";
                var deserializedObject = JsonConvert.DeserializeObject<TestItemSubCategory>(jsonString);
                Assert.AreEqual(subCategory.Value, deserializedObject.SubCategory);
            }
        }

        private Dictionary<string, ItemCategory> GetItemCategoryMapping()
        {
            var itemCategories = (ItemCategory[]) Enum.GetValues(typeof(ItemCategory));

            return itemCategories.ToDictionary(x => x.ToString(), x => x);
        }

        private Dictionary<string, ItemSubCategory> GetItemSubCategoryMapping()
        {
            var itemCategories = (ItemSubCategory[])Enum.GetValues(typeof(ItemSubCategory));

            return itemCategories.ToDictionary(x => x.ToString(), x => x);
        }
    }
}
