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
        }
    }
}
