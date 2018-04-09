namespace PUBGTelemetryParser
{
    /// <summary>
    /// Represents a point on the map.
    /// each coordinate point is represented in cm.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The x coordinate of the location.
        /// This is in cm.
        /// </summary>
        public float X { get; set; }
        /// <summary>
        /// The y coordinate of the location
        /// </summary>
        public float Y { get; set; }
        /// <summary>
        /// The z coordinate of the location.
        /// Represents how high or low something is.
        /// </summary>
        public float Z { get; set; }

    }
}
