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
            lblAccountInfoTitle.Text = "Account Information";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            btnSignUp.Text = "Sign Up";

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
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
                conn
                );

            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPhNumber.Text = string.Empty;
            cboCountry.SelectedIndex = -1;
        }
    }
}
