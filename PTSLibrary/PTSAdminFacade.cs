using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    public class PTSAdminFacade : PTSSuperFacade
    {
        private new DAO.AdminDAO dao;

        public PTSAdminFacade() : base(new DAO.AdminDAO())
        {
            dao = (DAO.AdminDAO)base.dao;
        }

        ///Authenticate method
        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }

        ///CreateProject method
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateProject(name, startDate, endDate, customerId, administratorId);
        }

        ///CreateTask method
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId,Guid projectId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTask(name, startDate, endDate, teamId, projectId);
        }

        ///GetListOfCustomers method
        public Customer[] GetListOfCustomers()
        {
            return (dao.GetListOfCustomers()).ToArray();
        }

        ///GetListOfProjects method
        public Project[] GetListOfProjects(int adminId)
        {
            return (dao.GetListOfProjects(adminId)).ToArray();
        }

        ///GetListOfTeams method
        public Team[] GetListOfTeams()
        {
            return (dao.GetListOfTeams()).ToArray();
        }

    }
}
