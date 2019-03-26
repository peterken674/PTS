using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    [Serializable]
	public class Customer : User ///Customer inherits from User
	{
        public Customer() { }
		public Customer(string name, int id) ///constructor taking the variables declared in the User class
		{
			this.name = name;
			this.id = id;
		}
	}
}
