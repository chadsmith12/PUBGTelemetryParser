namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGITEMUSE event.
    /// </summary>
    public class ItemUse : BaseTelemetryEvent
    {
        public ItemUse(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Item = telemetryEvent.Item;
        }

        /// <summary>
        /// The character that used this item.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The Item that was used.
        /// </summary>
        public Item Item { get; set; }
    }
}
