using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The customer class.
    /// </summary>
    [Serializable]
	public class Customer : User ///Customer inherits from User
	{
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Customer() { }
        /// <summary>
        /// Constructor that takes the name and customer id as arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
		public Customer(string name, int id) ///constructor taking the variables declared in the User class
		{
			this.name = name;
			this.id = id;
		}
	}
}
