namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents an LOGITEMUNEQUIP event for a character.
    /// </summary>
    public class ItemUnequip : BaseTelemetryEvent
    {
        public ItemUnequip(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Item = telemetryEvent.Item;
        }

        /// <summary>
        /// The character preformed this item unquip
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The item that was unequiped
        /// </summary>
        public Item Item { get; set; }

    }
}
