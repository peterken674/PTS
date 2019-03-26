using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    public class PTSSuperFacade : MarshalByRefObject
    {
        ///accessing the SuperDAO class in the subfolder DAO
        protected DAO.SuperDAO dao;

        public PTSSuperFacade(DAO.SuperDAO dao)
        {
            this.dao = dao;
        }

        ///GetListOfTasks method
        public Task[] GetListOfTasks(Guid projectId)
        {
            return (dao.GetListOfTasks(projectId)).ToArray();
        }
    }
}
