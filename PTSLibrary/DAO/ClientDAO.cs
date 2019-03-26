﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PTSLibrary.DAO
{
	class ClientDAO : SuperDAO
	{
        ///Authenticate method
        public TeamLeader Authenticate(string username, string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            TeamLeader leader = null;

            sql = String.Format("SELECT DISTINCT Person.Name, UserId, TeamId FROM Person INNER JOIN Team ON (Team.TeamLeaderId = Person.UserId) WHERE Username= '{0}' AND Password='{1}'", username, password);

            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                ///command returns a single row
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    leader = new TeamLeader(dr["Name"].ToString(), (int)dr["TeamId"], (int)dr["TeamId"]);
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
            return leader;
        }

        ///GetListOfProjects method
        public List<Project> GetListOfProjects(int teamId)
        {
            ///object declaration
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<Project> projects;
            projects = new List<Project>();

            sql = "SELECT P. * FROM Project AS P INNER JOIN Task AS T ON (P.ProjectId = T.ProjectId) WHERE T.TeamId = " + teamId;
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
                    Customer cust = GetCustomer((int)dr["CustomerId"]);
                    Project p = new Project(dr["Name"].ToString(), (DateTime)dr["ExpectedStartDate"],
                        (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectId"], cust);
                    projects.Add(p);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting list", ex);
            }
            finally
            {
                cn.Close();
            }
            return projects;
        }
    }
}
