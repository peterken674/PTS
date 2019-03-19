﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PTSLibrary.DAO
{
    class CustomerDAO : SuperDAO
    {
        public int Authenticate(string username, string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            sql = String.Format("SELECT CustomerId FROM Customer WHERE Username = '{0}' AND Password = '{1}'", username, password);

            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);
            int id = 0;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["CustomerId"];
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Accessing Database", ex);
            }
            finally
            {
                cn.Close();
            }
            return id;
        }

        public List<Project> GetListOfProjects(int customerId)
        {
            string sql;
            SqlConnection cn, cn2;
            SqlCommand cmd, cmd2;
            SqlDataReader dr, dr2;
            List<Project> projects = new List<Project>();

            sql = "SELECT * FROM Customer WHERE projectId = " + customerId;
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<Task> tasks = new List<Task>();
                    sql = "SELECT * FROM Task WHERE ProjectId = '" + dr["ProjectId"].ToString() + "'";
                    cn2 = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    cmd2 = new SqlCommand(sql, cn2);
                    cn2.Open();
                    dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        Task t = new Task((Guid)dr2["TAskId"], dr2["Name"].ToString(), (Status)dr2["StatusId"]);
                        tasks.Add(t);
                    }
                    dr2.Close();
                    Project p = new Project (dr["Name"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["projectId"], tasks);
                    projects.Add(p);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting List", ex);
            }
            finally
            {
                cn.Close();
            }
            return projects;
        }
    }
}
