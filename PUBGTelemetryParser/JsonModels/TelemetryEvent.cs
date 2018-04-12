using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PUBGTelemetryParser.Converters;
using PUBGTelemetryParser.Enums;

namespace PUBGTelemetryParser
{
    public class TelemetryEvent
    {
        [JsonProperty("_V")]
        public string Version { get; set; }

        /// <summary>
        /// The events timestamp in UTC.
        /// </summary>
        [JsonProperty("_D")]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// The telemtry event type 
        /// </summary>
        [JsonProperty("_T")]
        [JsonConverter(typeof(TelemetryEventTypeConverter))]
        public TelemetryEventType EventType { get; set; }

        /// <summary>
        /// Prives the match id, and map name.
        /// PC Only Telemetry data at this time. 
        /// </summary>
        public Common Common { get; set; }

        /// <summary>
        /// The item package/care package that is associated with care package events.
        /// </summary>
        public ItemPackage ItemPackage { get; set; }

        /// <summary>
        /// The vehicle that is associated with events that deal with Vehicles.
        /// </summary>
        public Vehicle Vehicle { get; set; }

        /// <summary>
        /// Character associated for some events.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// The attacker associated for some events.
        /// </summary>
        public Character Attacker { get; set; }

        /// <summary>
        /// The killer associated for some events.
        /// </summary>
        public Character Killer { get; set; }

        /// <summary>
        /// The victim assocaited for some events.
        /// </summary>
        public Character Victim { get; set; }

        /// <summary>
        /// The characters assocaited with an event (match start, match end)
        /// </summary>
        public IList<Character> Characters { get; set; }

        /// <summary>
        /// Current state of the game from log game state periodic
        /// </summary>
        public GameState GameState { get; set; }

        /// <summary>
        /// Result of a players login
        /// </summary>
        [JsonProperty("Result")]
        public bool PlayerLoginResult { get; set; }

        /// <summary>
        /// Error message of the player login
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The account id for this event.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the elapsed time of the game during this event.
        /// </summary>
        public float ElapsedTime { get; set; }

        /// <summary>
        /// Number of players live during this event.
        /// </summary>
        public int NumAlivePlayers { get; set; }

        /// <summary>
        /// the the of this attack
        /// </summary>
        public int AttackId { get; set; }

        /// <summary>
        /// The type of attack this was for attack events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AttackType AttackType { get; set; }

        /// <summary>
        /// Weapon used on an attack
        /// </summary>
        public Item Weapon { get; set; }

        /// <summary>
        /// An item that could be had been picked up.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// The id of this match
        /// </summary>
        public string MatchId { get; set; }

        /// <summary>
        /// The ping qualify of this match.
        /// </summary>
        public string PingQuality { get; set; }

        /// <summary>
        /// the parent item for a detach event. The item an item was detached from.
        /// </summary>
        public Item ParentItem { get; set; }

        /// <summary>
        /// The item detached.
        /// </summary>
        public Item ChildItem { get; set; }

        /// <summary>
        /// The type of damage
        /// </summary>
        public string DamageTypeCategory { get; set; }

        /// <summary>
        /// what caused the damage
        /// </summary>
        public string DamageCauserName { get; set; }

        /// <summary>
        /// the distance from from something in an event.
        /// </summary>
        public float Distance { get; set; }

        /// <summary>
        /// The reason for this damange.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DamageReason DamageReason { get; set; }

        /// <summary>
        /// how much damage was done.
        /// </summary>
        public float Damage { get; set; }
    }
}
