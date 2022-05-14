using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementDAL
{
    public class AccountDAL : IAccountDAL
    {
        private static SqlConnection sqlConnection;

        private void Connection()
        {
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=CodingChallenge6;Integrated Security=true");
        }
        public string Access(string UserName, string Password)
        {
            try
            {
                Connection();
                sqlConnection.Open();
                string role=null;

                string query = "Select roleassign from access where userName='" + UserName + "' and pass ='" + Password + "';";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    role = sqlDataReader[0].ToString();


                }
                sqlConnection.Close();
                return role;

            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
                //return null;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
                //return null;
            }
        }
    }
}
