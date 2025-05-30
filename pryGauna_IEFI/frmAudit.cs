using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_IEFI
{
    public partial class frmAudit : Form
    {
        clsDataHandler handler = new clsDataHandler();
        public frmAudit()
        {
            InitializeComponent();
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

            btnSearch.Text = "Search";

            cboCriterion.Items.Clear();
            cboCriterion.Items.Add("All Of Them");
            cboCriterion.Items.Add("Search by User");

            cboUsers.Enabled = false;
            cboUsers.DisplayMember = "Id";
            cboUsers.ValueMember = "Id";
            cboUsers.DataSource = handler.DataSet.Tables["Users"];
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
            if (cboCriterion.SelectedIndex == -1 || cboUsers.SelectedIndex == -1)
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
                if (cboCriterion.SelectedIndex == 1)
                {
                    dgvUserInfo.Rows.Clear();

                    List<DataRow> list = handler.SearchByUser(cboUsers.SelectedIndex + 1);
                    foreach (DataRow row in list)
                    {
                        dgvUserInfo.Rows.Add(row[0], row[2], row[3]);
                    }
                }
                else
                {
                    dgvUserInfo.Rows.Clear();

                    List<DataRow> list = handler.SearchAllOfThem();
                    foreach (DataRow row in list)
                    {
                        dgvUserInfo.Rows.Add(row[0], row[2], row[3]);
                    }
                }
            }
        }
    }
}
