namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents an ITEMEQUIP event.
    /// </summary>
    public class ItemEquip : BaseTelemetryEvent
    {
        public ItemEquip(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Item = telemetryEvent.Item;
        }

        /// <summary>
        /// The character that equiped this item.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The item that was equiped.
        /// </summary>
        public Item Item { get; set; }
    }
}
