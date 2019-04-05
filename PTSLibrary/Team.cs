using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The Team class.
    /// </summary>
    /// <remarks> 
    /// Team represents an internal or external team working for Out of Bounds Ltd. 
    /// It is linked to TeamLeader through association. 
    /// </remarks>
    [Serializable]
	public class Team
	{
		private int id;
		private string location;
		private string name;
		private TeamLeader leader;
        /// <summary>
        /// Default constructor for Team class.
        /// </summary>
        public Team() { }

        public int TeamId
		{
			get { return id; }
			set { id = value; }
		}

		public TeamLeader Leader
		{
			get { return leader; }
			set { leader = value; }
		}

		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        /// <summary>
        /// Constructor to set the team.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="name"></param>
        /// <param name="leader"></param>
		public Team(int id, string location, string name, TeamLeader leader)
		{
			this.id = id;
			this.location = location;
			this.name = name;
			this.leader = leader;
		}
	}
}
