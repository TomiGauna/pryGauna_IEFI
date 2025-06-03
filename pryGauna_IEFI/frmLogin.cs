using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_IEFI
{
    public partial class frmLogin : Form
    {
        clsUsersManager usersManager = new clsUsersManager();
        SqlConnection loginConn = new clsConnection().GetConnection();
        frmMain mainForm = new frmMain();
        frmSignup SignupForm;
        private Font initialFont;

        public frmLogin()
        {
            InitializeComponent();
            initialFont = lblRegisterHere.Font;
            lblRegisterHere.MouseEnter += lblRegisterHere_MouseEnter;
            lblRegisterHere.MouseLeave += lblRegisterHere_MouseLeave;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "LOGIN";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            lblSignUp.Text = "Don't you have an account yet? → ";
            lblRegisterHere.Text = "Register Here";

            btnLogin.Text = "Login";

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Both fields are required", 
                    "Login Information: Unfilled Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (usersManager.LoginValidation(txtUsername.Text, txtPassword.Text, loginConn))
                {
                    mainForm.SetLabels(txtUsername.Text, DateTime.Now.ToShortDateString());
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(
                        "User not registered or wrong password. Please enter valid credentials",
                        "Login Information: Wrong Credentials",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            SignupForm = new frmSignup(loginConn);
            SignupForm.Show();
        }

        private void lblRegisterHere_MouseEnter(object sender, EventArgs e)
        {
            lblRegisterHere.Font = new Font(lblRegisterHere.Font, FontStyle.Underline);
        }

        private void lblRegisterHere_MouseLeave(object sender, EventArgs e)
        {
            lblRegisterHere.Font = initialFont;

        }
    }
}
