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
    public partial class frmUpdate : Form
    {
        SqlConnection conn;
        clsUsersManager userMgr = new clsUsersManager();

        public frmUpdate(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Choose an username";
            lblField.Text = "Pick the field you want to change";
            lblNewData.Text = "Enter the new information";
            lblNewCountry.Text = "Choose the new country or new role";
            lblTitle.Text = "MODIFY USER INFORMATION";
            btnUpdate.Text = "Update";

            cboUsername.DisplayMember = "Username";
            cboUsername.ValueMember = "Id";
            cboUsername.DataSource = userMgr.GetAllUsersSystemInfo(conn);
            cboUsername.SelectedIndex = -1;

            cboField.Items.Clear();
            cboField.Items.Add("Last Name");
            cboField.Items.Add("First Name");
            cboField.Items.Add("Password");
            cboField.Items.Add("Username");
            cboField.Items.Add("Age");
            cboField.Items.Add("Email");
            cboField.Items.Add("Country");
            cboField.Items.Add("Phone Number");
            cboField.Items.Add("Role");
            cboField.SelectedIndex = -1;

            txtNewData.Enabled = false;
            cboNewCountry.Enabled = false;
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNewCountry.Items.Clear();

            if (cboField.Text == "Country" || cboField.Text == "Role")
            {
                cboNewCountry.Enabled = true;
                txtNewData.Enabled = false;

                if (cboField.Text == "Country")
                {
                    cboNewCountry.Items.Add("Argentina");
                    cboNewCountry.Items.Add("Brasil");
                    cboNewCountry.Items.Add("México");
                    cboNewCountry.Items.Add("Uruguay");
                    cboNewCountry.Items.Add("Paraguay");
                    cboNewCountry.Items.Add("España");
                    cboNewCountry.Items.Add("Venezuela");
                    cboNewCountry.Items.Add("Perú");
                    cboNewCountry.Items.Add("El Salvador");
                    cboNewCountry.Items.Add("Chile");
                    cboNewCountry.Items.Add("Colombia");
                    cboNewCountry.Items.Add("Ecuador");
                    cboNewCountry.Items.Add("Bolivia");
                }
                else
                {
                    cboNewCountry.Items.Add("Admin");
                    cboNewCountry.Items.Add("User");
                }
                cboNewCountry.SelectedIndex = -1;
            }
            else
            {
                cboNewCountry.Enabled = false;
                txtNewData.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboUsername.Text) || string.IsNullOrWhiteSpace(cboField.Text))
            {
                MessageBox.Show(
                    "A username and a field are required",
                    "User Update: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (cboField.Text == "Country" || cboField.Text == "Role")
                {
                    userMgr.UpdateUser(
                        cboUsername.Text,
                        cboField.Text,
                        cboNewCountry.Text,
                        conn
                        );
                }
                else
                {
                    userMgr.UpdateUser(
                        cboUsername.Text,
                        cboField.Text,
                        txtNewData.Text,
                        conn
                        );
                }
            }
        }
    }
}
