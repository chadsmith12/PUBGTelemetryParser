using System.Collections.Generic;
using System.Linq;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.TelemetryEvents;

namespace PUBGTelemetryParser
{
    public class Character
    {
        public Character()
        {
            
        }

        public Character(Character character, IList<TelemetryEvent> telemtryEvents)
        {
            AccountId = character.AccountId;
            Name = character.Name;
            TeamId = character.TeamId;
            Health = character.Health;
            Location = character.Location;
            Ranking = character.Ranking;
            PlayerLogins = telemtryEvents.Where(x => x.EventType == TelemetryEventType.PlayerLogin && x.AccountId == character.AccountId).Select(x => new PlayerLogin(x));
            PlayerPositions = telemtryEvents.Where(x => x.EventType == TelemetryEventType.PlayerPosition && x.Character.AccountId == character.AccountId).Select(x => new PlayerPosition(x));
            PlayerAttacks = telemtryEvents.Where(x => x.EventType == TelemetryEventType.PlayerAttack && x.Attacker.AccountId == character.AccountId).Select(x => new PlayerAttack(x));
        }
        /// <summary>
        /// This characters account id.
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// The players name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The id of the team they are on.
        /// </summary>
        public int TeamId { get; set; }
        /// <summary>
        /// The current health of the caracter at a point in time.
        /// </summary>
        public float Health { get; set; }
        /// <summary>
        /// The current location of the character a point in time.
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// The ranking of the character.
        /// </summary>
        public int Ranking { get; set; }

        /// <summary>
        /// All the login events for this character.
        /// </summary>
        public IEnumerable<PlayerLogin> PlayerLogins { get; set; }

        /// <summary>
        /// All the player position events for this character.
        /// </summary>
        public IEnumerable<PlayerPosition> PlayerPositions { get; set; }

        /// <summary>
        /// All the player attack events for this character.
        /// </summary>
        public IEnumerable<PlayerAttack> PlayerAttacks { get; set; }
    }
}
