using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The TeamLeader class.
    /// </summary>
    /// <remarks>
    /// Represents a leader of an internal or external team. 
    /// It inherits from the User class.
    /// </remarks>
    [Serializable]
	public class TeamLeader : User
	{
        /// <summary>
        /// Default constructor for the TeamLeader class.
        /// </summary>
        public TeamLeader() { }

        private int teamId; 

		public int TeamId
		{
			get { return teamId; }
			set { teamId = value; }
		}
        /// <summary>
        /// Constructor to set the team leader for a team.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="teamid"></param>
		public TeamLeader(string name, int id, int teamid)
		{
			this.name = name;
			this.id = id;
#pragma warning disable CS1717 // Assignment made to same variable.
            this.teamId = teamId;
#pragma warning restore CS1717 // Assignment made to same variable.
        }
	}
}
