using PUBGTelemetryParser.Helpers;

namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// All the time a player killed someone.
    /// </summary>
    public class PlayerKill : BaseTelemetryEvent
    {
        public PlayerKill(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            AttackId = telemetryEvent.AttackId;
            Attacker = telemetryEvent.Attacker;
            Victim = telemetryEvent.Victim;
            DamageTypeCategory = !TelemetryDictionaries.DamageTypeCategories.ContainsKey(telemetryEvent.DamageTypeCategory)
                ? telemetryEvent.DamageTypeCategory
                : TelemetryDictionaries.DamageTypeCategories[telemetryEvent.DamageTypeCategory];

            DamageAmount = telemetryEvent.Damage;
            DamageCauser = !TelemetryDictionaries.DamageCauserNames.ContainsKey(telemetryEvent.DamageCauserName)
                ? telemetryEvent.DamageCauserName
                : TelemetryDictionaries.DamageCauserNames[telemetryEvent.DamageCauserName];
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
        /// The amount of damage done.
        /// </summary>
        public float DamageAmount { get; set; }

        /// <summary>
        /// what caused the damage.
        /// </summary>
        public string DamageCauser { get; set; }

    }
}
