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
using BinBLL;

namespace UItoDB
{
    public partial class frmMain : Form
    {
        bllTest bllTest;
        public frmMain()
        {
            InitializeComponent();
            bllTest = new bllTest();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from Users";
            //MessageBox.Show(SqlHelper.sqlHelper.ExecuteScalar(sql).ToString());
            MessageBox.Show(bllTest.GetValueFromDB(sql).ToString());

        }

        private void 新增合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContract frmContract = new frmContract();
            frmContract.Show();
        }
    }
}
