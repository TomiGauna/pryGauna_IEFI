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
    public partial class frmDelete : Form
    {
        SqlConnection conn;
        clsUsersManager userMgr = new clsUsersManager();

        public frmDelete(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "DELETE USER INFORMATION";
            lblUsername.Text = "Choose a user";
            btnDelete.Text = "Delete";
            btnDelete.Enabled = false;

            cboUsername.DisplayMember = "Username";
            cboUsername.ValueMember = "Id";
            cboUsername.DataSource = userMgr.GetAllUsersSystemInfo(conn);
            cboUsername.SelectedIndex = -1;
        }

        private void cboUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsername.SelectedIndex == -1)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboUsername.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "A username is required. Please pick a username",
                    "User Removal Information: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                btnDelete.Enabled = false;
            }
            else
            {
                userMgr.DeleteUser(cboUsername.Text, conn);
            }
            cboUsername.SelectedIndex = -1;
        }
    }
}
