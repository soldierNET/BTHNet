using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BaiThucHanh7.Controller
{
    public class UserController
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        public static bool CheckUser(string name)
        {
            string queryString = @"select count(*) from user where username = @name";
            SqlConnection connection = new SqlConnection(queryString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@name", name);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count > 0)
                return true;

            return false;
        }

        public static bool Insert(User user)
        {
            string queryString = @"insert into user() 
                values(@username, @password, @firstName, @lastName, @gender, @email, @address)";
            SqlConnection connection = new SqlConnection(queryString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@username", user.username);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@firstName", user.firstName);
            command.Parameters.AddWithValue("@lastName", user.lastName);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@address", user.address);

            connection.Open();
            int inserted = (int)command.ExecuteNonQuery();
            connection.Close();

            if (inserted > 0)
                return true;

            return false;
        }
    }
}