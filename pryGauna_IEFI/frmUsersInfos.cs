using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_IEFI
{
    public partial class frmUsersInfos : Form
    {
        SqlConnection conn;
        clsUsersManager userMger = new clsUsersManager(); 

        public frmUsersInfos(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;

        }

        private void frmUsersInfos_Load(object sender, EventArgs e)
        {
            tpaSystemInfo.Text = "System Information";
            tpaPersonalInfo.Text = "Personal Information";

            DataTable personalTable = userMger.GetAllUsersPersonalInfo(conn);
            DataTable systemTable = userMger.GetAllUsersSystemInfo(conn);

            dgvPersonalInfo.DataSource = personalTable;
            dgvSystemInfo.DataSource = systemTable;

            tpaPersonalInfo.Controls.Add(dgvPersonalInfo);
            tpaSystemInfo.Controls.Add(dgvSystemInfo);
        }
    }
}
