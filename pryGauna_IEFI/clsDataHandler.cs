using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace pryGauna_IEFI
{
    internal class clsDataHandler
    {
        public DataSet DataSet { get; set; }
        OleDbDataAdapter UsersDA { get; set; }
        OleDbDataAdapter DatesAndTimesDA { get; set; }
        public OleDbConnection Connection { get; set; }

        public clsDataHandler() 
        {
            Connection = new OleDbConnection();
            string fileRoute = @"../../Database/Users.mdb";
            Connection.ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={fileRoute}";
            //Connection.Open();

            DataSet = new DataSet();

            /////////////////////////////////////////////////////Meant for table "Users"
            OleDbCommand usersCmd = new OleDbCommand();
            usersCmd.CommandType = CommandType.TableDirect;
            usersCmd.CommandText = "Users";
            usersCmd.Connection = Connection;

            UsersDA = new OleDbDataAdapter();
            UsersDA.SelectCommand = usersCmd;
            UsersDA.Fill(DataSet, "Users");

            DataColumn[] DC = new DataColumn[1];
            DC[0] = DataSet.Tables["Users"].Columns["Id"];
            DataSet.Tables["Users"].PrimaryKey = DC;

            /////////////////////////////////////////////////////Meant for table "Times"
            OleDbCommand timesCmd = new OleDbCommand();
            timesCmd.CommandType = CommandType.TableDirect;
            timesCmd.CommandText = "Times";
            timesCmd.Connection = Connection;

            DatesAndTimesDA = new OleDbDataAdapter();
            DatesAndTimesDA.SelectCommand = timesCmd;
            DatesAndTimesDA.Fill(DataSet, "Times");

            DataColumn[] timesDC = new DataColumn[1];
            timesDC[0] = DataSet.Tables["Times"].Columns["Id"];
            DataSet.Tables["Times"].PrimaryKey = timesDC;

            ////////////////////////////////////////////////////Command Builders for both
            OleDbCommandBuilder usersCB = new OleDbCommandBuilder(UsersDA);
            OleDbCommandBuilder timesCB = new OleDbCommandBuilder(DatesAndTimesDA);
        }

        public bool UserValidation(string username, string password)
        {
            bool flag = false;
            try
            { 
                foreach (DataRow row in DataSet.Tables["Users"].Rows)
                {
                    if (row["Username"].ToString() == username)
                    {
                        if (row["Password"].ToString() == password)
                        {
                            flag = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Error validating user: " + ex.Message,
                    "Validation Process: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return flag;
        }

        public void RegisterTimes(string user, DateTime loginTime, DateTime endLogin)
        {
            try
            {
                DataRow timesData = DataSet.Tables["Times"].NewRow();
                foreach (DataRow userr in DataSet.Tables["Users"].Rows)
                {
                    if (user == userr["Username"].ToString())
                    {
                        timesData["User"] = userr["Id"];
                        break;
                    }
                }

                timesData["Id"] = DataSet.Tables["Times"].Rows.Count + 1;
                timesData["Date"] = loginTime;
                timesData["Time"] = (endLogin - loginTime).TotalMinutes;
                DataSet.Tables["Times"].Rows.Add(timesData);
                Console.WriteLine(loginTime);
     
                DatesAndTimesDA.Update(DataSet, "Times");
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Error registering user times: " + ex.Message,
                    "Times Registration Process: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        public List<DataRow> SearchAllOfThem()
        {
            List<DataRow> rowsList = new List<DataRow>();
            try
            {
                foreach (DataRow userTimes in DataSet.Tables["Times"].Rows)
                {
                    rowsList.Add(userTimes);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Fail to search users: " + ex.Message,
                    "Searching Process: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return rowsList;
        }

        public List<DataRow> SearchByUser(int id)
        {
            List<DataRow> rowsList = new List<DataRow>();
            try
            {
                foreach (DataRow userTimes in DataSet.Tables["Times"].Rows)
                {
                    if (Convert.ToInt64(userTimes["User"]) == id)
                    {
                        rowsList.Add(userTimes);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Fail to search user: " + ex.Message,
                    "Searching Process: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return rowsList;
        }
    }
}
