using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    public class PTSCustomerFacade : PTSSuperFacade
    {
        private new DAO.CustomerDAO dao;

        ///constructor that makes a call to the constructor of the superclass
        public PTSCustomerFacade() : base(new DAO.CustomerDAO())
        {
            dao = (DAO.CustomerDAO)base.dao;
        }

        ///GetListOfProjects method
        public Project[] GetListOfProjects(int customerId)
        {
            return (dao.GetListOfProjects(customerId)).ToArray();
        }

        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }
    }
}
