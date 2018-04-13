using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.TelemetryEvents;

namespace PUBGTelemetryParser
{
    public static class TelemetryParser
    {
        public static PubgMatch ParseTelemetry(string telemetryFile)
        {
            var jsonString = File.ReadAllText(telemetryFile);
            var telemtry = JsonConvert.DeserializeObject<IList<TelemetryEvent>>(jsonString);
            var matchKills = telemtry.Where(x => x.EventType == TelemetryEventType.PlayerKill).GroupBy(x => x.Killer.AccountId).ToList();
            var players = telemtry.First(x => x.EventType == TelemetryEventType.MatchEnd).Characters.Select(x => new Player
            {
                AccountId = x.AccountId,
                Name = x.Name,
                FinalRanking = x.Ranking,
                TeamId = x.TeamId,
                PlayerLogins = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerLogin && y.Attacker.AccountId == x.AccountId).Select(y => new PlayerLogin(y)),
                PlayerAttacks = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerAttack && y.Attacker.AccountId == x.AccountId).Select(y => new PlayerAttack(y)),
                PlayerPositions = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerPosition && y.Character.AccountId == x.AccountId).Select(y => new PlayerPosition(y)),
                ItemPickups = telemtry.Where(y => y.EventType == TelemetryEventType.ItemPickup && y.Character.AccountId == x.AccountId).Select(y => new ItemPickup(y)),
                ItemEquips = telemtry.Where(y => y.EventType == TelemetryEventType.ItemEquip && y.Character.AccountId == x.AccountId).Select(y => new ItemEquip(y)),
                ItemUnequips = telemtry.Where(y => y.EventType == TelemetryEventType.ItemUnequip && y.Character.AccountId == x.AccountId).Select(y => new ItemUnequip(y)),
                VehicleRides = telemtry.Where(y => y.EventType == TelemetryEventType.VehicleRide && y.Character.AccountId == x.AccountId).Select(y => new VehicleRide(y)),
                VehicleLeaves = telemtry.Where(y => y.EventType == TelemetryEventType.VehicleLeave && y.Character.AccountId == x.AccountId).Select(y => new VehicleLeave(y)),
                PlayerDamages = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerTakeDamage && y.Victim.AccountId == x.AccountId).Select(y => new PlayerTakeDamage(y)),
                ItemAttaches = telemtry.Where(y => y.EventType == TelemetryEventType.ItemAttach && y.Character.AccountId == x.AccountId).Select(y => new ItemAttach(y)),
                ItemDrops = telemtry.Where(y => y.EventType == TelemetryEventType.ItemDrop && y.Character.AccountId == x.AccountId).Select(y => new ItemDrop(y)),
                PlayerKills = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerKill && y.Killer.AccountId == x.AccountId).Select(y => new PlayerKill(y)),
                ItemDetaches = telemtry.Where(y => y.EventType == TelemetryEventType.ItemDetach && y.Character.AccountId == x.AccountId).Select(y => new ItemDetach(y)),
                ItemUses = telemtry.Where(y => y.EventType == TelemetryEventType.ItemUse && y.Character.AccountId == x.AccountId).Select(y => new ItemUse(y)),
                VehicleDestroys = telemtry.Where(y => y.EventType == TelemetryEventType.VehicleDestroy && y.Attacker.AccountId == x.AccountId).Select(y => new VehicleDestroy(y)),
                PlayerLogouts = telemtry.Where(y => y.EventType == TelemetryEventType.PlayerLogout && y.Attacker.AccountId == x.AccountId).Select(y => new PlayerLogout(y))
            }).ToList();

            foreach (var item in players)
            {
                var playersKilled = matchKills.FirstOrDefault(x => x.Key == item.AccountId)?.Select(x => x.Victim.AccountId);
                if (playersKilled != null)
                {
                    item.KilledPlayers = players.Where(x => playersKilled.Contains(x.AccountId));
                    item.NumberKills = item.KilledPlayers.Count();
                    item.LongestKill = matchKills.Where(x => x.Key == item.AccountId).SelectMany(x => x).Max(x => x.Distance);
                }
                // all players team members, except you
                item.TeamMembers = players.Where(x => x.TeamId == item.TeamId && x.AccountId != item.AccountId);
            }
            var matchDetails = new PubgMatch
            {
                MatchId = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).Common.MatchId,
                MapName = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).Common.FriendlyMapName,
                MatchStartTime = telemtry.First(x => x.EventType == TelemetryEventType.MatchStart).EventTime,
                MatchEndTime = telemtry.First(x => x.EventType == TelemetryEventType.MatchEnd).EventTime,
                Players = players,
                GameStates = telemtry.Where(x => x.EventType == TelemetryEventType.GameStatePeriodic).Select(x => new TelemetryEvents.GameState(x)),
                VehicleDestroys = telemtry.Where(x => x.EventType == TelemetryEventType.VehicleDestroy).Select(x => new VehicleDestroy(x)),
                CarePackages = telemtry.Where(x => x.EventType == TelemetryEventType.CarePackageLand).Select(x => x.ItemPackage),
                ItemPackagesSpawns = telemtry.Where(x => x.EventType == TelemetryEventType.CarePackageSpawn).Select(x => x.ItemPackage),
                ItemPackagesLands = telemtry.Where(x => x.EventType == TelemetryEventType.CarePackageSpawn).Select(x => x.ItemPackage)
            };

            return matchDetails;
        }
    }
}
