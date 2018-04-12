using System.Collections.Generic;
using System.Linq;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Represents a team in match. Gives you the characters for a team.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// The id of this team.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// The ranking of where this team finished.
        /// </summary>
        public int TeamRanking => TeamMembers.First().FinalRanking;

        /// <summary>
        /// the total number of kills this team had.
        /// </summary>
        public int TotalKills
        {
            get { return TeamMembers.Select(x => x.NumberKills).Sum(); }
        }

        /// <summary>
        /// The team members for this team.
        /// </summary>
        public IEnumerable<Player> TeamMembers { get; set; }
    }
}
