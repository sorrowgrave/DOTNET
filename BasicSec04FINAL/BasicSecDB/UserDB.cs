using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BasicSec04
{
    public static class UserDB
    {
        public static User GetUser(string userEmail)
        {
            User user = new User();
            SqlConnection connection = BasicSecDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand(null, connection);

            selectCommand.CommandText =
                "SELECT Id, Name, Surname, Email, Password, PublicKey " +
                "FROM [User] " +
                "WHERE Email = @userEmail";

            selectCommand.Prepare();

            selectCommand.Parameters.AddWithValue("@userEmail", userEmail);

            try
            {
                connection.Open();
                selectCommand.ExecuteNonQuery();

                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.Surname = reader["Surname"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.PublicKey = reader["PublicKey"].ToString();
                }
                else
                {
                    user = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return user;
        }

        public static List<User> getUserNames()
        {
            List<User> userList = new List<User>();
            

            SqlConnection connection = BasicSecDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand(null, connection);

            selectCommand.CommandText =
            "SELECT Id, Name, Email FROM [User]";

            selectCommand.Prepare();

            try
            {
                connection.Open();
                selectCommand.ExecuteNonQuery();

                SqlDataReader reader =
                    selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    userList.Add(user);
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return userList;
        }

        public static bool addUserPublicKey(string email, byte[] publicKey)
        {
            SqlConnection connection = BasicSecDB.GetConnection();
            SqlCommand updateCommand = new SqlCommand(null, connection);

            updateCommand.CommandText =
                "UPDATE [User] SET PublicKey = @PublicKey WHERE Email = @Email";

            updateCommand.Prepare();

            updateCommand.Parameters.AddWithValue("@PublicKey", publicKey);
            updateCommand.Parameters.AddWithValue("@Email", email);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();

                if (count > 0)
                    return true;
                else
                    return false;


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static byte[] GetPublicKey(int Id)
        {
            byte[] publicKey;

            SqlConnection connection = BasicSecDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand(null, connection);

            selectCommand.CommandText =
                "SELECT PublicKey " +
                "FROM [User] " +
                "WHERE Id = @Id";

            selectCommand.Prepare();

            selectCommand.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                selectCommand.ExecuteNonQuery();

                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    publicKey = (byte[])reader["PublicKey"];
                }
                else
                {
                    publicKey = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            
            return publicKey;
        }
    }
}
