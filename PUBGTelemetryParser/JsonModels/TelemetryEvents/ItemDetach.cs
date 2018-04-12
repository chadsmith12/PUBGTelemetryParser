namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents an LOGITEMDETACH event.
    /// </summary>
    public class ItemDetach : BaseTelemetryEvent
    {
        public ItemDetach(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            ParentItem = telemetryEvent.ParentItem;
            ChildItem = telemetryEvent.ChildItem;
        }

        /// <summary>
        /// The character that detached the time.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The item that this item was detached from.
        /// </summary>
        public Item ParentItem { get; set; }

        /// <summary>
        /// The item that was detached.
        /// </summary>
        public Item ChildItem { get; set; }
    }
}
