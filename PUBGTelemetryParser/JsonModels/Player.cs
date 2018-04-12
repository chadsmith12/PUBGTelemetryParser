using System.Collections.Generic;
using PUBGTelemetryParser.TelemetryEvents;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Represents a single player instance in a match.
    /// Holds the details of the player and the player specific logs attatched to this character.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The id of the account in PUBG for this character.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// The in-game name in PUBG.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the team of they were on.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Where they finished in the match.
        /// </summary>
        public int FinalRanking { get; set; }

        /// <summary>
        /// The number of kills the player got in a match (does not count knock downs)
        /// </summary>
        public int NumberKills { get; set; }

        /// <summary>
        /// The distance of the longest kill the player had.
        /// </summary>
        public float LongestKill { get; set; }

        /// <summary>
        /// The players this player killed (does not include players only knocked down)
        /// </summary>
        public IEnumerable<Player> KilledPlayers { get; set; }

        /// <summary>
        /// The players that were on this players team. 
        /// This does not include this player.
        /// </summary>
        public IEnumerable<Player> TeamMembers { get; set; }

        #region Player Event Logs
        /// <summary>
        /// all of this players attacks.
        /// </summary>
        public IEnumerable<PlayerAttack> PlayerAttacks { get; set; }

        /// <summary>
        /// All of the players login events.
        /// </summary>
        public IEnumerable<PlayerLogin> PlayerLogins { get; set; }

        /// <summary>
        /// All of the locations logged for a player.
        /// </summary>
        public IEnumerable<PlayerPosition> PlayerPositions { get; set; }

        /// <summary>
        /// All the items a player picked up.
        /// </summary>
        public IEnumerable<ItemPickup> ItemPickups { get; set; }

        /// <summary>
        /// All the items a player equiped during a match.
        /// </summary>
        public IEnumerable<ItemEquip> ItemEquips { get; set; }

        /// <summary>
        /// All the times a player unequiped an item.
        /// </summary>
        public IEnumerable<ItemUnequip> ItemUnequips { get; set; }

        /// <summary>
        /// All the logs for a vehicle ride for a player.
        /// </summary>
        public IEnumerable<VehicleRide> VehicleRides { get; set; }

        /// <summary>
        /// All the event logs for the player when they left in a vehicle.
        /// </summary>
        public IEnumerable<VehicleLeave> VehicleLeaves { get; set; }

        /// <summary>
        /// All the times the player took damage.
        /// </summary>
        public IEnumerable<PlayerTakeDamage> PlayerDamages { get; set; }

        /// <summary>
        /// All the times the player attached an item.
        /// </summary>
        public IEnumerable<ItemAttach> ItemAttaches { get; set; }

        /// <summary>
        /// All the times the player dropped an item.
        /// </summary>
        public IEnumerable<ItemDrop> ItemDrops { get; set; }

        /// <summary>
        /// All the times a player killed someone.
        /// </summary>
        public IEnumerable<PlayerKill> PlayerKills { get; set; }

        /// <summary>
        /// All the times the player detached an item.
        /// </summary>
        public IEnumerable<ItemDetach> ItemDetaches { get; set; }

        /// <summary>
        /// All the times an item was used.
        /// </summary>
        public IEnumerable<ItemUse> ItemUses { get; set; }

        /// <summary>
        /// All the times the player destroyed the vehicle.
        /// </summary>
        public IEnumerable<VehicleDestroy> VehicleDestroys { get; set; }

        /// <summary>
        /// All the times the player logged out.
        /// </summary>
        public IEnumerable<PlayerLogout> PlayerLogouts { get; set; }
        #endregion
    }
}
