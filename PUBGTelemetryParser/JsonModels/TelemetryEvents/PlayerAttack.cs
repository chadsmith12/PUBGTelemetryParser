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
        public int AttackId { get; set; }
        public Character Attacker { get; set; }
        public AttackType AttackType { get; set; }
        public Item Weapon { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
