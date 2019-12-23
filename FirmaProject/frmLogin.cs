using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaProject
{
    public partial class frmLogin : Form
    {
        //string Password = "123";
        //string name = "abdul";
        DB db = new DB();
        public frmLogin()
        {
            InitializeComponent();
        }
        frmProg frm = new frmProg();
        DataTable dt = new DataTable();
        private void btnCustSearch2_Click(object sender, EventArgs e)
        {
            dt = db.RunReader("select *from Users ");
            int intRow = 0;

            if (txbUserName.Text == dt.Rows[intRow][1].ToString() && txnPassw.Text == dt.Rows[intRow][2].ToString())    
            {
                this.Hide();
                frm.Show();                           
            }
            else
            {                
                MessageBox.Show("Password or Username is wrong please try agin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                intRow++;
                txnPassw.Clear();
            }
        }

        private void CustSearch_Load(object sender, EventArgs e)
        {
            txbUserName.Focus();
            txbUserName.Select();
        }

        private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txnPassw.Focus();
            }
        }

        private void txnPassw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCustSearch2_Click(null, null);
            }
        }
    }
}
