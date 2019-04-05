using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The Task class.
    /// </summary>
    /// <remarks> Represents a task within a
    ///project, which is assigned to a
    ///team and can be broken into
    ///subtasks. Linked to Status through association. </remarks>
    
    [Serializable]
	public class Task
	{
        /// <summary>
        /// Default constructor for class Task.
        /// </summary>
        public Task() { }

        private Guid taskId;
		private string name;
		private Status status;

		public Guid TaskId
		{
			get { return taskId; }
			set { taskId = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Status theStatus
		{
			get { return status; }
			set { status = value; }
		}

		public Task(Guid id, string name, Status status)
		{
			this.taskId = id;
			this.name = name;
			this.status = status;
		}

        public string NameAndStatus
        {
            get { return name + " - " + status; }
        }
	}
}
