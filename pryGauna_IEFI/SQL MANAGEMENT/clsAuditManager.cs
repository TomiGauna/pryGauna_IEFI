using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_IEFI
{
    internal class clsAuditManager
    {        
        SqlCommand command;
        SqlDataAdapter da;
        clsUsersManager usersManager = new clsUsersManager(); 

        public void AddAuditInfo(
            string user,
            DateTime loginTime,
            DateTime logoutTime,
            SqlConnection conn
            )
        {
            try
            {
                string query = $"INSERT INTO AuditInfo (Id, [User], LoginDate, UsageTime) VALUES (@Id, @User, @LoginDate, @UsageTime)";

                DataTable table = GetAllUsersAuditInfo(conn);
                int id = table.Rows.Count + 1;

                DataTable users = usersManager.GetAllUsersSystemInfo(conn);
                int userRef = -1;

                foreach (DataRow userRow in users.Rows)
                {
                    if (usersManager.UserValidation(user, conn))
                    {
                        userRef = Convert.ToInt32(userRow["Id"]);
                        break;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Username not found",
                            "User Id Designation: Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }

                double usageTime = (logoutTime - loginTime).TotalMinutes;
                double roundedTime = Math.Round(usageTime, 2);

                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@User", userRef);
                command.Parameters.AddWithValue("@LoginDate", loginTime);
                command.Parameters.AddWithValue("@UsageTime", roundedTime);
                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Times registered succesfully",
                    "Time Registration: Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Fail to register time: {ex.Message}",
                    "Time Registration: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public DataTable GetAllUsersAuditInfo(SqlConnection conn)
        {
            string query = "SELECT * FROM AuditInfo";

            command = new SqlCommand(query, conn);

            da = new SqlDataAdapter(command);
            DataTable allRows = new DataTable();
            da.Fill(allRows);

            return allRows;
        }

        public DataTable GetOneUserInfo(int userId, SqlConnection conn)
        {
            string query = "SELECT * FROM AuditInfo WHERE [User] = @Id";

            command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Id", userId);
            da = new SqlDataAdapter(command);
            DataTable user = new DataTable();
            da.Fill(user);

            return user;
        }
    }
}
