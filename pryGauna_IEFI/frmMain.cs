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

        public frmMain()
        {
            InitializeComponent();
        }

        private void auditoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auditForm.Show();
        }
    }
}
