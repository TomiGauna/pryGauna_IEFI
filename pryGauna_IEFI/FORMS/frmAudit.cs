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
    public partial class frmAudit : Form
    {
        clsAuditManager auditManager = new clsAuditManager();
        clsUsersManager usersManager = new clsUsersManager();
        SqlConnection conn;

        public frmAudit(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void frmAudit_Load(object sender, EventArgs e)
        {
            dgvUserInfo.Columns.Clear();
            dgvUserInfo.Columns.Add("col1", "User");
            dgvUserInfo.Columns.Add("col2", "Date");
            dgvUserInfo.Columns.Add("col3", "Usage Time");

            dgvUserInfo.Columns[1].Width = 200;

            lblSearch.Text = "Pick a search criterion";
            lblChooseUser.Text = "Choose an user";
            lblTotalTimeTitle.Text = "Total Time: ";
            lblTotalTime.Text = "";

            btnSearch.Text = "Search";

            cboCriterion.Items.Clear();
            cboCriterion.Items.Add("All Of Them");
            cboCriterion.Items.Add("Search by User");

            cboUsers.Enabled = false;
            cboUsers.DisplayMember = "Id";
            cboUsers.ValueMember = "Id";
            cboUsers.DataSource = usersManager.GetAllUsersSystemInfo(conn);
            cboUsers.SelectedIndex = -1;
        }

        private void cboCriterion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterion.SelectedIndex == 1)
            {
                cboUsers.Enabled = true;
            }
            else
            {
                cboUsers.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboCriterion.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please choose a criterion and/or an user for search",
                    "Audit Form: Incomplete fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (cboCriterion.SelectedIndex == 1 && cboUsers.SelectedIndex == -1) 
                {
                    MessageBox.Show(
                        "You must choose a user",
                        "Audit Information: Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                DataTable table = new DataTable();
                double totalTime = 0;
                if (cboCriterion.SelectedIndex == 1)
                {
                    dgvUserInfo.Rows.Clear();

                    table = auditManager.GetOneUserInfo(cboUsers.SelectedIndex + 1, conn);
                    foreach (DataRow row in table.Rows)
                    {
                        dgvUserInfo.Rows.Add(row[1], row[0], row[3]);
                        totalTime = totalTime + Math.Round(double.Parse(row[3].ToString()), 2);
                    }
                    lblTotalTime.Text = totalTime.ToString();
                }
                else
                {
                    dgvUserInfo.Rows.Clear();

                    table = auditManager.GetAllUsersAuditInfo(conn);
                    foreach (DataRow row in table.Rows)
                    {
                        dgvUserInfo.Rows.Add(row[1], row[0], row[3]);
                        totalTime = totalTime + Math.Round(double.Parse(row[3].ToString()), 2);
                    }
                    lblTotalTime.Text = totalTime.ToString();
                }
            }
        }
    }
}
