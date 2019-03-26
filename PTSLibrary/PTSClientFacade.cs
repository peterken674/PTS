using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    public class PTSClientFacade : PTSSuperFacade
    {
        private new DAO.ClientDAO dao;

        public PTSClientFacade() : base(new DAO.ClientDAO())
        {
            dao = (DAO.ClientDAO)base.dao;
        }

        ///Authenticate method
        public TeamLeader Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }

        ///GetListOfProjects method
        public Project[] GetListOfProjects(int teamId)
        {
        return (dao.GetListOfProjects(teamId)).ToArray();
        }
    }
}
