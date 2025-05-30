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
    public partial class frmMain : Form
    {
        frmAudit auditForm = new frmAudit();
        clsDataHandler handler = new clsDataHandler();
        DateTime loginTime;

        public frmMain()
        {
            InitializeComponent();
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
            handler.RegisterTimes(tsslUser.Text, loginTime, closingTime);
            auditForm.Close();
            this.Close();
            //handler.Connection.Close();
        }
    }
}
