using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The enum Status
    /// </summary>
    /// <remarks> Defines the states if tasks or subtasks. </remarks>
	public enum Status
	{
		ReadyToStart = 1,
        InProgress = 2,
        Completed = 3,
        WaitingForPredecessor = 4
	}
}
