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
    public partial class frmMain : Form
    {
        SqlConnection conn = new clsConnection().GetConnection();
        clsAuditManager auditManager = new clsAuditManager();
        clsUsersManager userMgr = new clsUsersManager();
        frmAudit auditForm;
        frmUsersInfos infoForm;
        frmUpdate updateForm;
        frmDelete deleteForm;
        frmSignup createForm;
        DateTime loginTime;

        public frmMain()
        {
            InitializeComponent();
            conn.Open();
        }

        private void auditoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auditForm = new frmAudit(conn);
            auditForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome back to the dashboard!";
            btnLogout.Text = "Log Out";
            loginTime = DateTime.Now;

            if (RoleValidation(tsslUser.Text) == "User")
            {
                updateUserToolStripMenuItem.Enabled = false;
                deleteUserToolStripMenuItem.Enabled = false;
                createUserToolStripMenuItem.Enabled = false;
            }
            else
            {
                updateUserToolStripMenuItem.Enabled = true;
                deleteUserToolStripMenuItem.Enabled = true;
                createUserToolStripMenuItem.Enabled = true;
            }
        }

        public void SetLabels(string username, string date)
        {
            tsslUser.Text = username;
            tsslDate.Text = date + "  -";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DateTime closingTime = DateTime.Now;
            auditManager.AddAuditInfo(tsslUser.Text, loginTime, closingTime, conn);
            auditForm.Close();
            this.Close();
            conn.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoForm = new frmUsersInfos(conn);
            infoForm.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateForm = new frmUpdate(conn);
            updateForm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm = new frmDelete(conn);
            deleteForm.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createForm = new frmSignup(conn);
            createForm.Show();
        }

        public string RoleValidation(string username)
        {
            DataTable users = userMgr.GetAllUsersSystemInfo(conn);
            string role = null;

            foreach (DataRow userRow in users.Rows)
            {
                if (userRow["Username"].ToString() == username)
                {
                    role = userRow["Role"].ToString();
                    break;
                }
            }
            return role;
        }
    }
}
