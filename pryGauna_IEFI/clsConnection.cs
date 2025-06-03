using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace pryGauna_IEFI
{
    internal class clsConnection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = "Server=localhost;Database=Lab3IEFI;Trusted_Connection=True;";
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect to DB: " + ex.Message, "Connection Information: DB Plug-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
