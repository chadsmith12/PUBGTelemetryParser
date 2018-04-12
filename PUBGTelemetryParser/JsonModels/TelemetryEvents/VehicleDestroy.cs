using PUBGTelemetryParser.Helpers;

namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Represents a LOGVEHICLEDESTROY event.
    /// </summary>
    public class VehicleDestroy : BaseTelemetryEvent
    {
        public VehicleDestroy(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            AttackId = telemetryEvent.AttackId;
            Attacker = telemetryEvent.Attacker;
            Victim = telemetryEvent.Victim;
            DamageTypeCategory = !TelemetryDictionaries.DamageTypeCategories.ContainsKey(telemetryEvent.DamageTypeCategory)
                ? telemetryEvent.DamageTypeCategory
                : TelemetryDictionaries.DamageTypeCategories[telemetryEvent.DamageTypeCategory];

            DamageCauser = !TelemetryDictionaries.DamageCauserNames.ContainsKey(telemetryEvent.DamageCauserName)
                ? telemetryEvent.DamageCauserName
                : TelemetryDictionaries.DamageCauserNames[telemetryEvent.DamageCauserName];

            Distance = telemetryEvent.Distance;
        }

        /// <summary>
        /// The id of the attack.
        /// </summary>
        public int AttackId { get; set; }

        /// <summary>
        /// Who attacked the player.
        /// </summary>
        public Character Attacker { get; set; }

        /// <summary>
        /// The victim of this attack.
        /// </summary>
        public Character Victim { get; set; }

        /// <summary>
        /// The damage type of the damage doing to the player.
        /// </summary>
        public string DamageTypeCategory { get; set; }

        /// <summary>
        /// what caused the damage.
        /// </summary>
        public string DamageCauser { get; set; }

        /// <summary>
        /// The distance the character was from the vehicle.
        /// </summary>
        public float Distance { get; set; }
    }
}
