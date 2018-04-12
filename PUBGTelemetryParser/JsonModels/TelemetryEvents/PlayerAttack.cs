using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser.TelemetryEvents
{
    /// <summary>
    /// Presents a LOGPLAYERATTACK Event.
    /// </summary>
    public class PlayerAttack : BaseTelemetryEvent
    {
        public PlayerAttack(TelemetryEvent telemetryEvent) : base(telemetryEvent)
        {
            AttackId = telemetryEvent.AttackId;
            Attacker = telemetryEvent.Attacker;
            AttackType = telemetryEvent.AttackType;
            Weapon = telemetryEvent.Weapon;
            Vehicle = telemetryEvent.Vehicle;
        }

        /// <summary>
        /// The attack id.
        /// </summary>
        public int AttackId { get; set; }

        /// <summary>
        /// The character that did the attack.
        /// </summary>
        public Character Attacker { get; set; }

        /// <summary>
        /// The type of attack this was.
        /// </summary>
        public AttackType AttackType { get; set; }

        /// <summary>
        /// The weapon that did this attack.
        /// </summary>
        public Item Weapon { get; set; }

        /// <summary>
        /// The vehicle in the attack.
        /// </summary>
        public Vehicle Vehicle { get; set; }
    }
}
