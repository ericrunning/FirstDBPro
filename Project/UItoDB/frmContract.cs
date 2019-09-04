using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UItoDB
{
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
        }

        private void 新增合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupAdd.Visible = true;
        }
    }
}
