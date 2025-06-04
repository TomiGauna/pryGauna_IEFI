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
        frmAudit auditForm;
        frmUsersInfos infoForm;
        frmUpdate updateForm;
        frmDelete deleteForm;
        DateTime loginTime;

        public frmMain()
        {
            InitializeComponent();
            conn.Open();
            auditForm = new frmAudit(conn);
            infoForm = new frmUsersInfos(conn);
            updateForm = new frmUpdate(conn);
            deleteForm = new frmDelete(conn);
        }

        private void auditoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auditForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnLogout.Text = "Log Out";
            loginTime = DateTime.Now;
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
            infoForm.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateForm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm.Show();
        }
    }
}
