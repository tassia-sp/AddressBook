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

        public int AddPerson(Person model)
        {
            int retval = 0;
            //get connection string for database from the web.config
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("People_Insert", sqlConn))
                {
                    //grab the SQL stroed prodedure and insert user input into the parameters declared in the sql procedure
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Favorite", model.Favorite);

                    //output the int ID identity column
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Id";
                    param.SqlDbType = System.Data.SqlDbType.Int;
                    param.Direction = System.Data.ParameterDirection.Output;

                    //open the connection and call insert the model into the database.
                    sqlConn.Open();
                    cmd.ExecuteNonQuery();

                    //the returned param is the identity column number generated in SQL.
                    retval = (int)cmd.Parameters["@Id"].Value;

                }
            }
            return retval;
        }
    }
}