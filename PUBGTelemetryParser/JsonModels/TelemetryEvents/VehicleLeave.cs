namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGVEHICLELEAVE event.
    /// </summary>
    public class VehicleLeave : BaseTelemetryEvent
    {
        public VehicleLeave(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
        }

        /// <summary>
        /// The character who left in the vehicle.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The vehicle the player left in.
        /// </summary>
        public Vehicle Vehicle { get; set; }
    }
}
