using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The super facade
    /// </summary>
    /// <remarks> This is the base facade class. </remarks>
    public class PTSSuperFacade : MarshalByRefObject
    {
        /// <summary>
        /// The database access object.
        /// </summary>
        protected DAO.SuperDAO dao;

        /// <summary>
        /// A constructor
        /// </summary>
        /// <remarks> Takes the database access object as an argument</remarks>
        /// <param name="dao"></param>
        public PTSSuperFacade(DAO.SuperDAO dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Gets a list of tasks.
        /// </summary>
        /// <remarks> Gets the list of tasks.
        ///             The <see cref="dao"/> returns a list which is converted to an <see cref="Array"</remarks>
        /// <param name="projectId"></param>
        /// <returns> The list of tasks. </returns>
        public Task[] GetListOfTasks(Guid projectId)
        {
            return (dao.GetListOfTasks(projectId)).ToArray();
        }
    }
}
