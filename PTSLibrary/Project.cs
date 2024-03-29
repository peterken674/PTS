﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The project class.
    /// </summary>
    [Serializable]
	public class Project
	{
		private string name;
		private DateTime expectedStartDate;
		private DateTime expectedEndDate;
		private Customer theCustomer;
		private Guid projectId;
		private List<Task> tasks;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Project() { }
        public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public DateTime ExpectedStartDate
		{
			get { return expectedStartDate; }
			set { expectedStartDate = value; }
		}

		public DateTime ExpectedEndDate
		{
			get { return expectedEndDate; }
			set { expectedEndDate = value; }
		}

		public Customer TheCustomer
		{
			get { return theCustomer; }
			set { theCustomer = value; }
		}

		public Guid ProjectId
		{
			get { return projectId; }
		}

		public List<Task> Tasks
		{
			get { return tasks; }
			set { tasks = value; }
		}

		/// <summary>
        /// Constructor to set the tasks.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="projectId"></param>
        /// <param name="tasks"></param>
		public Project(string name, DateTime startDate, DateTime endDate, Guid projectId, List<Task> tasks)
		{
			this.name = name;
			this.expectedStartDate = startDate;
			this.expectedEndDate = endDate;
			this.projectId = projectId;
			this.tasks = tasks;
		}

        /// <summary>
        /// Constructor to set the customers.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
		public Project(string name, DateTime startDate, DateTime endDate, Guid projectId, Customer customer)
		{
			this.name = name;
			this.expectedStartDate = startDate;
			this.expectedEndDate = endDate;
			this.projectId = projectId;
			this.theCustomer = customer;
		}

	}
}
