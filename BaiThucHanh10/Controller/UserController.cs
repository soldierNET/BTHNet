using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace BaiThucHanh10.Controller
{
    public class UserController
    {
        public static string connectionString
        {
            get => ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        }

        public static bool Exist(string username)
        {
            string queryString = @"SELECT COUNT(*) FROM [dbo].[UserInfo] WHERE Username = @name";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@name", username);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count > 0)
                return true;

            return false;
        }
        
        public static User GetUser(string username)
        {
            string queryString = @"SELECT * FROM [dbo].[UserInfo] WHERE Username = @name";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@name", username);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new User(reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["Email"].ToString(),
                    (bool)reader["Gender"],
                    reader["Address"].ToString(),
                    reader["Username"].ToString(),
                    reader["Password"].ToString(),
                    reader["Avatar"].ToString()
                    );
            }
            connection.Close();
            return null;
        }

        public static DataTable GetDataTable()
        {
            string queryString = @"SELECT * FROM [dbo].[UserInfo]";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connectionString);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static int Count()
        {
            string queryString = @"SELECT COUNT(*) FROM [dbo].[UserInfo]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count;
        }


        public static bool Insert(User user)
        {
            string queryString = @"INSERT INTO [dbo].[UserInfo] 
                                    ([Id], [Username], [Password], [FirstName], [LastName], [Email], [Gender], [Address], [Avatar])
                                    VALUES (@id, @username, @password, @firstName, @lastName, @email, @gender, @address, @avatar)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", Count()+1);
            command.Parameters.AddWithValue("@username", user.username);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@firstName", user.firstName);
            command.Parameters.AddWithValue("@lastName", user.lastName);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@address", user.address);
            command.Parameters.AddWithValue("@avatar", user.avatar);

            connection.Open();
            int inserted = (int)command.ExecuteNonQuery();
            connection.Close();

            return (inserted > 0);
        }

        public static bool Update(User user)
        {
            string queryString = @"UPDATE [dbo].[UserInfo]
                                    SET Password = @password, 
                                        FirstName = @firstName, 
                                        LastName = @lastName, 
                                        Email = @email, 
                                        Gender = @gender, 
                                        Address = @address,
                                        Avatar = avatar
                                    WHERE Username = @username";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@username", user.username);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@firstName", user.firstName);
            command.Parameters.AddWithValue("@lastName", user.lastName);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@address", user.address);
            command.Parameters.AddWithValue("@avatar", user.avatar);
            connection.Open();
            int updated = (int)command.ExecuteNonQuery();
            connection.Close();

            return (updated > 0);
        }
        
        public static bool Delete(string username)
        {
            string queryString = @"DELETE FROM [dbo].[UserInfo] 
                                    WHERE Username = @username";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@username", username);

            connection.Open();
            int deleted = (int)command.ExecuteNonQuery();
            connection.Close();
            return (deleted > 0);
        }
    }
}