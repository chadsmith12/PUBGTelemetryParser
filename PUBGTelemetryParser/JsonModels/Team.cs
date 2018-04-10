using System.Collections.Generic;

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
        /// The team members for this team.
        /// </summary>
        public IList<Character> TeamMembers { get; set; }
    }
}
