using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace pryGauna_IEFI
{
    internal class clsUsersManager
    {

        //SqlConnection connection = new clsConnection().GetConnection();
        SqlCommand command;
        SqlDataAdapter da;

        public void CreateUser(
            string lastName,
            string firstName,
            string username,
            string password,
            int age,
            string email,
            string country,
            int phNumber,
            SqlConnection connection
            )
        {
            try
            {
                string query = $"INSERT INTO Users (Id, LastName, FirstName, Username, Password, Age, Email, Country, PhoneNumber, Role) VALUES (@Id, @LastName, @FirstName, @Username, @Password, @Age, @Email, @Country, @PhoneNumber, @Role)";

                DataTable usersTable = GetAllUsersSystemInfo(connection);
                int id = usersTable.Rows.Count + 1;

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Lastname", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@PhoneNumber", phNumber);
                command.Parameters.AddWithValue("@Role", "User");
                command.ExecuteNonQuery();

                MessageBox.Show(
                    "User created succesfully",
                    "User Registration: Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Fail to register system information for user: {ex.Message}",
                    "Product Registration: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public void UpdateUser(string username, string field, string value, SqlConnection connection)
        {
            try
            {
                if (field == "Username")
                {
                    if (UserValidation(value, connection))
                    {
                        throw new Exception(
                            "Username already registered. Please choose another username"
                            );
                    }
                }
                string modifiedField = CleanWhiteSpaces(field);
                string query = $"UPDATE Users SET [{modifiedField}] = @valor WHERE Username = @username";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@valor", value);
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                MessageBox.Show(
                    "User updated successfully!",
                    "User Update: Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Fail to update user: {ex.Message}",
                    "User Update: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public void DeleteUser(string username, SqlConnection connection)
        {
            try
            {
                string query = "DELETE FROM Users WHERE Username = @username";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
                MessageBox.Show(
                    "User deleted successfully!",
                    "User Removal: Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Fail to delete user: {ex.Message}",
                    "User Removal: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public DataTable GetAllUsersSystemInfo(SqlConnection connection)
        {
            string query = "SELECT Id, Username, Password, Role FROM Users";

            command = new SqlCommand(query, connection);
            da = new SqlDataAdapter(command);
            DataTable systemInfofromAll = new DataTable();
            da.Fill(systemInfofromAll);

            return systemInfofromAll;
        }

        public DataTable GetAllUsersPersonalInfo(SqlConnection connection)
        {
            string query = "SELECT LastName, FirstName, Age, Email, Country, PhoneNumber FROM Users";

            command = new SqlCommand(query, connection);
            da = new SqlDataAdapter(command);
            DataTable personalInfofromAll = new DataTable();
            da.Fill(personalInfofromAll);

            return personalInfofromAll;
        }

        public DataTable GetUserSystemInfo(string username, SqlConnection connection)
        {
            string query = "SELECT Id, Username, Password FROM Users WHERE Username = @username";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            da = new SqlDataAdapter(command);
            DataTable userRow = new DataTable();
            da.Fill(userRow);

            return userRow;
        }

        public DataTable GetUserPersonalInfo(string username, SqlConnection connection)
        {
            string query = "SELECT LastName, FirstName, Age, Country, Email, PhoneNumber FROM Users WHERE Username = @username";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            da = new SqlDataAdapter(command);
            DataTable userInfo = new DataTable();
            da.Fill(userInfo);

            return userInfo;
        }

        public bool UserValidation(string username, SqlConnection conn)
        {
            DataTable users = GetAllUsersSystemInfo(conn);
            bool flag = false;

            foreach (DataRow userRow in users.Rows)
            {
                if (userRow["Username"].ToString() == username)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool LoginValidation(string username, string password, SqlConnection conn)
        {
            DataTable users = GetAllUsersSystemInfo(conn);
            bool flag = false;

            foreach (DataRow userRow in users.Rows)
            {
                if (
                    userRow["Username"].ToString() == username &&
                    userRow["Password"].ToString() == password
                    )
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public string CleanWhiteSpaces(string field)
        {
            return Regex.Replace(field, @"\s+", "");
        }
    }
}
