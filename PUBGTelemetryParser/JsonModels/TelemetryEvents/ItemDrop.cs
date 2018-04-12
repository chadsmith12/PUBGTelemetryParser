namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGITEMDROP event.
    /// </summary>
    public class ItemDrop : BaseTelemetryEvent
    {
        public ItemDrop(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Item = telemetryEvent.Item;
        }

        /// <summary>
        /// The character that dropped this item.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// the item that was dropped.
        /// </summary>
        public Item Item { get; set; }
    }
}
