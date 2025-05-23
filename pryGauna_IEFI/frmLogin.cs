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
    public partial class frmLogin : Form
    {
        frmMain mainForm = new frmMain();
        clsDataHandler handler = new clsDataHandler();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "LOGIN";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";

            btnLogin.Text = "Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter data correctly", 
                    "Login Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (handler.UserValidation(txtUsername.Text, txtPassword.Text))
                {
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Please enter a username or password registered",
                        "Login Information: Wrong Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

    }
}
