namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGITEMATTACH event.
    /// </summary>
    public class ItemAttach : BaseTelemetryEvent
    {
        public ItemAttach(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            ParentItem = telemetryEvent.ParentItem;
            ChildItem = telemetryEvent.ChildItem;
        }

        /// <summary>
        /// The character that attached this item.
        /// </summary>
        public Character Character { get; set; }
        /// <summary>
        /// The item that this is being attached too.
        /// </summary>
        public Item ParentItem { get; set; }
        /// <summary>
        /// The item that is being attached.
        /// </summary>
        public Item ChildItem { get; set; }
    }
}
