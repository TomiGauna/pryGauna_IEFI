using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_IEFI
{
    internal class clsDataHandler
    {
        DataSet DataSet { get; set; }

        public clsDataHandler() 
        {
            OleDbConnection connection = new OleDbConnection();
            string fileRoute = @"../../Database/Users.mdb";
            connection.ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={fileRoute}";
            connection.Open();

            DataSet = new DataSet();

            OleDbCommand command = new OleDbCommand();

            command.CommandType = CommandType.TableDirect;
            command.CommandText = "Users";
            command.Connection = connection;

            OleDbDataAdapter DA = new OleDbDataAdapter();
            DA.SelectCommand = command;
            DA.Fill(DataSet, "Users");

            DataColumn[] DC = new DataColumn[1];
            DC[0] = DataSet.Tables["Users"].Columns["Id"];
            DataSet.Tables["Users"].PrimaryKey = DC;

            OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(DA);
            connection.Close();
        }

        public bool UserValidation(string username, string password)
        {
            bool flag = false;
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
            return flag; 
        }
    }
}
