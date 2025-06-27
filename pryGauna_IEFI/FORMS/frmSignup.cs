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
    public partial class frmSignup : Form
    {
        clsUsersManager userManager = new clsUsersManager();
        SqlConnection conn;

        public frmSignup(SqlConnection connectionFromLogin)
        {
            InitializeComponent();
            conn = connectionFromLogin;
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "CREATE AN ACCOUNT";
            lblPersInfoTitle.Text = "Personal Information";
            lblFirstName.Text = "First Name";
            lblLastName.Text = "Last Name";
            lblEmail.Text = "E-mail";
            lblPhoneNumber.Text = "Phone Number";
            lblAge.Text = "Age";
            lblCountry.Text = "Country";
            lblRole.Text = "Role";
            lblAccountInfoTitle.Text = "Account Information";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            btnSignUp.Text = "Sign Up";

            txtPassword.UseSystemPasswordChar = true;

            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("User");

            cboCountry.Items.Clear();
            cboCountry.Items.Add("Argentina");
            cboCountry.Items.Add("México");
            cboCountry.Items.Add("Bolivia");
            cboCountry.Items.Add("Perú");
            cboCountry.Items.Add("Paraguay");
            cboCountry.Items.Add("Uruguay");
            cboCountry.Items.Add("Brasil");
            cboCountry.Items.Add("Colombia");
            cboCountry.Items.Add("El Salvador");
            cboCountry.Items.Add("Venezuela");
            cboCountry.Items.Add("Chile");
            cboCountry.Items.Add("Ecuador");
            cboCountry.Items.Add("España");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtEmail.Text == "" ||
                txtPhNumber.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtAge.Text == "" ||
                cboCountry.SelectedIndex == -1
                )
            {
                MessageBox.Show(
                    "All fields are required",
                    "Sign Up Information: Empty Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (userManager.UserValidation(txtUsername.Text, conn))
                {
                    MessageBox.Show(
                    "Username already registered. Please choose another username",
                    "Sign Up Information: Existent User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
                else
                {
                    userManager.CreateUser(
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtUsername.Text,
                    txtPassword.Text,
                    int.Parse(txtAge.Text),
                    txtEmail.Text,
                    cboCountry.Text,
                    int.Parse(txtPhNumber.Text),
                    cboRole.Text,
                    conn
                    );
                }
                
            }        

            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPhNumber.Text = string.Empty;
            cboCountry.SelectedIndex = -1;
            cboRole.SelectedIndex = -1;
        }
    }
}
