using System;
using System.Collections.Generic;
using System.Linq;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Represents the details of a match in pubg.
    /// </summary>
    public class PubgMatch
    {
        /// <summary>
        /// The id of this match.
        /// </summary>
        public string MatchId { get; set; }
        /// <summary>
        /// Start of the match in UTC.
        /// </summary>
        public DateTime MatchStartTime { get; set; }

        /// <summary>
        /// End of the match in UTC.
        /// </summary>
        public DateTime MatchEndTime { get; set; }

        /// <summary>
        /// The length of a match.
        /// </summary>
        public TimeSpan MatchLength => MatchEndTime - MatchStartTime;

        /// <summary>
        /// The map this match took place on.
        /// </summary>
        public string MapName { get; set; }

        /// <summary>
        /// The characters in a match.
        /// </summary>
        public IEnumerable<Character> Characters { get; set; }

        /// <summary>
        /// The teams in a match.
        /// </summary>
        public IEnumerable<Team> Teams
        {
            get
            {
                return Characters.GroupBy(x => x.TeamId).Select(x => new Team{TeamId = x.Key, TeamMembers = x.Select(y => y).ToList()});
            }
        }
    }
}
