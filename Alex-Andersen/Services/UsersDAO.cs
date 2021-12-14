using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alex_Andersen.Controllers;
using Alex_Andersen.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using MySqlX.XDevAPI.Relational;

namespace Alex_Andersen.Services
{


    public class UsersDAO //DAO = Data Access Object
    {
        //connection string or whatever
        private string connectionString = @"Data Source=alexandersen.db";



        //has to be ID instead of name and password
        public bool FindUserByNameAndPassword(User user) {

            bool success = false;



            //return true if found in db

            string SqlStatement = "SELECT * FROM Users WHERE UserPassword = @UserPassword AND UserName = @UserName";


            using (SqliteConnection connection = new SqliteConnection(connectionString)) 
            {

                SqliteCommand command = new SqliteCommand(SqlStatement, connection);

                command.Parameters.Add("@UserName", (SqliteType)System.Data.SqlDbType.VarChar, 15).Value = user.UserName;
                command.Parameters.Add("@UserPassword", (SqliteType)System.Data.SqlDbType.VarChar, 255).Value = user.UserPassword;


                try
                {
                    connection.Open();
                    SqliteDataReader reader = command.ExecuteReader();
                   
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); 
                }

            }

            return success;

            

        }
        
    }
}
