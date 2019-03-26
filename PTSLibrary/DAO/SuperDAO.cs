using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PTSLibrary.DAO
{
	public class SuperDAO
	{
        ///GetCustomer method
        protected Customer GetCustomer(int custId)
        {
            ///object declaration (necessary to access the database) 
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            Customer cust;

            ///statement that retrieves customer details
            sql = "SELECT * FROM Customer WHERE CustomerId = " + custId;
            ///create connection 
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                ///command returns a single row
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                dr.Read();
                ///create instance 'cust'
                cust = new Customer(dr["Name"].ToString(), (int)dr["CustomerId"]);
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting Customer", ex);
            }
            finally
            {
                cn.Close();
            }
            return cust;
        }

        ///GetListOfTasks method
        public List<Task> GetListOfTasks(Guid projectId)
        {
            ///object declaration
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List <Task> tasks;
            tasks = new List<Task>();

            sql = "SELECT * FROM Task WHERE ProjectId = '" + projectId + "'";
            ///create connection 
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                ///returns more than one row
                dr = cmd.ExecuteReader();
                while (dr.Read()) ///iterates through all returned rows
                {
                    Task t = new Task((Guid)dr["TaskId"], dr["Name"].ToString(), (Status)((int)dr["StatusId"]));
                    tasks.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting tasks list", ex);
            }
            finally
            {
                cn.Close();
            }
            return tasks;
        }
    }
}
