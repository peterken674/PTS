using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    [Serializable]
	public class TeamLeader : User
	{
        public TeamLeader() { }

        private int teamId; ///new field

		public int TeamId ///property to provide access to teamId
		{
			get { return teamId; }
			set { teamId = value; }
		}

		public TeamLeader(string name, int id, int teamid) ///constructor
		{
			this.name = name;
			this.id = id;
#pragma warning disable CS1717 // Assignment made to same variable
            this.teamId = teamId;
#pragma warning restore CS1717 // Assignment made to same variable
        }
	}
}
