using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.Helpers;

namespace PUBGTelemetryParser
{
    public class Item
    {
        /// <summary>
        /// The id of this item.
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// Number items stacked.
        /// <example>30 rounds of .556 ammo.</example>
        /// </summary>
        public int StackCount { get; set; }
        /// <summary>
        /// The category this item belongs too.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemCategory Category { get; set; }
        /// <summary>
        /// The subcategory this item belongs too.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemSubCategory SubCategory { get; set; }
        /// <summary>
        /// The items that are attached to this item.
        /// </summary>
        public List<Item> AttachedItems { get; set; }
        /// <summary>
        /// The item's name.
        /// This is gotten from the item dictionary for this items id.
        /// Just uses the items id if it is not found in the item ids dictionary.
        /// </summary>
        public string ItemName => !TelemetryDictionaries.ItemIds.ContainsKey(ItemId) ? ItemId : TelemetryDictionaries.ItemIds[ItemId];
    }
}
