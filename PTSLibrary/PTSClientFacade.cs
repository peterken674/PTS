using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    /// <summary>   The client facade. </summary>
    ///
    /// <remarks>   Interface used by clients to access data. </remarks>
    public class PTSClientFacade : PTSSuperFacade
    {
        /// <summary>
        /// The database access object.
        /// </summary>
        private new DAO.ClientDAO dao;

        /// <summary>
        /// The default constructor which takes no arguments
        /// </summary>
        public PTSClientFacade() : base(new DAO.ClientDAO())
        {
            dao = (DAO.ClientDAO)base.dao;
        }

        /// <summary>
        /// Authenticate the customer.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public TeamLeader Authenticate(string username, string password)
        {
            ///<summary>Server side validation which ensures that the password and username are provided. </summary>
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }

        /// <summary> Gets the list of projects. </summary>
        /// 
        /// <remark>
        /// Gets the projects commissioned by the customer.
        ///             The <see cref="dao"/> returns a list which is converted to an <see cref="Array"/>.
        /// </remark>
        /// <param name="teamId"></param>
        /// <returns>The list of projects. </returns>
        public Project[] GetListOfProjects(int teamId)
        {
        return (dao.GetListOfProjects(teamId)).ToArray();
        }
    }
}
