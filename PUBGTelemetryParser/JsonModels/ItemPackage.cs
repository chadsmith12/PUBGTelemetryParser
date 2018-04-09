using System.Collections.Generic;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Represents a carepackage/drop
    /// </summary>
    public class ItemPackage
    {
        /// <summary>
        /// the ID of this package.
        /// </summary>
        public string ItemPackageId { get; set; }
        /// <summary>
        /// The current location of this package.
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// The items that are inside of a package.
        /// </summary>
        public IList<Item> Items { get; set; }
    }
}
