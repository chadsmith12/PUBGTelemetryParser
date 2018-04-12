namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGITEMPICKUP event a charcter did.
    /// </summary>
    public class ItemPickup : BaseTelemetryEvent
    {
        public ItemPickup(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Item = telemetryEvent.Item;
        }

        /// <summary>
        ///  The character who picked up this item.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The item the character picked up.
        /// </summary>
        public Item Item { get; set; }
    }
}
