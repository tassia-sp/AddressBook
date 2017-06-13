using MyWebApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MyWebApp.Services
{
    public class PeopleService
    {
        public List<Person> GetPeople()
        {
            List<Person> peopleList = new List<Person>();

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                ////using open and close connection without calling IDispose
                using(SqlCommand cmd = new SqlCommand("People_SelectAll", sqlConn))
                {
                    sqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    //returns a true or false
                    while (reader.Read())
                    {
                        Person p = new Person();
                        p.Id = reader.GetInt32(0);
                        p.FirstName = reader.GetString(1);
                        p.LastName = reader.GetString(2);
                        p.Email = reader.GetString(3);
                        p.Favorite = reader.GetBoolean(4);
                    }
                }
            }
            return peopleList;
        }
    }
}