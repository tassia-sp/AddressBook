using MyWebApp.Models.ViewModels;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyWebApp.Services
{
    public class PeopleService
    {
        public List<Person> GetPeople()
        {
            List<Person> peopleList = new List<Person>();

            //grab connction string from the Web.Config
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                //using opens and closes connection without calling IDispose. Prevents memory leaks
                using(SqlCommand cmd = new SqlCommand("People_SelectAll", sqlConn))
                {
                    sqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    //returns a true or false
                    while (reader.Read())
                    {
                        //instantiate the Person Model
                        Person p = new Person();
                        //grab data from the server and place into properties of the model. 
                        //Loops through table rows
                        p.Id = reader.GetInt32(0);
                        p.FirstName = reader.GetString(1);
                        p.LastName = reader.GetString(2);
                        p.Email = reader.GetString(3);
                        p.Favorite = reader.GetBoolean(4);

                        //Add to the new Person p object
                        peopleList.Add(p);
                    }
                }
            }
            //return to Api Controller
            return peopleList;
        }
    }
}