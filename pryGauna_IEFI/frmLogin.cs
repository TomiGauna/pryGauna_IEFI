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
        clsDataHandler handler = new clsDataHandler();
        frmMain mainForm = new frmMain();

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
                    "Both fields are required", 
                    "Login Information: Unfilled Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (handler.UserValidation(txtUsername.Text, txtPassword.Text))
                {
                    handler.Connection.Open();
                    mainForm.SetLabels(txtUsername.Text, DateTime.Now.ToShortDateString());
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Incorrect username or password. Please enter a valid username or password",
                        "Login Information: Wrong Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

    }
}
