namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents the LOGVEHICLERIDE event.
    /// </summary>
    public class VehicleRide : BaseTelemetryEvent
    {
        public VehicleRide(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            Character = telemetryEvent.Character;
            Vehicle = telemetryEvent.Vehicle;
        }

        /// <summary>
        /// The character who got in a vehicle.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The vehicle the character got in.
        /// </summary>
        public Vehicle Vehicle { get; set; }
    }
}
