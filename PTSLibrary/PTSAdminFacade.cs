using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>
    /// The admin facade
    /// </summary>
    public class PTSAdminFacade : PTSSuperFacade
    {
        /// <summary>
        /// The database access object.
        /// </summary>
        private new DAO.AdminDAO dao;

        /// <summary>
        /// The default constructor which takes no arguments.
        /// </summary>
        public PTSAdminFacade() : base(new DAO.AdminDAO())
        {
            dao = (DAO.AdminDAO)base.dao;
        }

        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Authenticate(string username, string password)
        {
            ///<remarks> Server-side validation to ensure that the username and password are provided. </remarks>
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="customerId"></param>
        /// <param name="administratorId"></param>
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId)
        {
            ///<remarks> Server-side validation to ensure that the details are provided. </remarks>
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateProject(name, startDate, endDate, customerId, administratorId);
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="teamId"></param>
        /// <param name="projectId"></param>
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId,Guid projectId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTask(name, startDate, endDate, teamId, projectId);
        }

        /// <summary>
        /// Gets the list of customers.
        /// </summary>
        /// <returns> The list of customers. </returns>
        public Customer[] GetListOfCustomers()
        {
            return (dao.GetListOfCustomers()).ToArray();
        }

        /// <summary>
        /// Gets the list of projects.
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns> List of projects. </returns>
        public Project[] GetListOfProjects(int adminId)
        {
            return (dao.GetListOfProjects(adminId)).ToArray();
        }

        /// <summary>
        /// Gets a list of teams.
        /// </summary>
        /// <returns> List of teams. </returns>
        public Team[] GetListOfTeams()
        {
            return (dao.GetListOfTeams()).ToArray();
        }

    }
}
