using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The User class.
    /// </summary>
    [Serializable]
	public class User
	{///variables
		protected string name;
		protected int id;

		public string Name
		{
			get { return name; }
		}

		public int Id
		{
			get { return id; }
		}
	}
}
