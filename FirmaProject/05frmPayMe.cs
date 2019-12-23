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
    public partial class frmPayMe : Form
    {
        public frmPayMe()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblPayMe = new DataTable();
        int intRow = 0;
        
       

        private void FilltblPayMe(string Selectstatment = "select *from payment_me")
        {
            tblPayMe.Clear();
            tblPayMe = db.RunReader(Selectstatment);
        }

        private void Fillcust()
        {
            cbxBuyCus.DataSource = db.RunReader("select custno,custname from customer");
            cbxBuyCus.DisplayMember = "custname";
            cbxBuyCus.ValueMember = "custno";
        }
       
        private void AutoNum()
        {
            FilltblPayMe("select max(payno) from payment_me");
            if (tblPayMe.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNr.Text = "1";
            else
                txtActionNr.Text = (Convert.ToInt16(tblPayMe.Rows[0][0].ToString()) + 1).ToString();
            //txbItemNr.Text = tblItem.Rows[0][0].ToString();
        }
        private void ClearData()
        {
            AutoNum();
            txbBuyDesc.Clear();
            txbPerson.Clear();
            btnAdd.Enabled = true;
            btnDele.Enabled = false;
            btnEdit.Enabled = false;
            //cbxBuyCus.Enabled = true;
            //cbxBuyItem.Enabled = true;
        }
        private void ShowData()
        {

            FilltblPayMe();
            txtActionNr.Text = tblPayMe.Rows[intRow][0].ToString();
            cbxBuyCus.SelectedValue = tblPayMe.Rows[intRow][1].ToString();             
            nudAmount.Value = Convert.ToInt16(tblPayMe.Rows[intRow][2]);
            dtpDate.Text = tblPayMe.Rows[intRow][3].ToString();
            txbPerson.Text = tblPayMe.Rows[intRow][4].ToString();
             
            txbBuyDesc.Text = tblPayMe.Rows[intRow][5].ToString();
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDele.Enabled = true;
            //cbxBuyCus.Enabled = false;
            //cbxBuyItem.Enabled = false;
             

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intRow += 1;
            if (intRow >= tblPayMe.Rows.Count - 1)
            {
                MessageBox.Show("this is the last");
                return;
            }
            else
            {
                ShowData();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            intRow -= 1;
            if (intRow <= 0)
            {
                MessageBox.Show("this is the First");
                return;
            }
            else
            {
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intRow = tblPayMe.Rows.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into payment_me values (" + txtActionNr.Text + "," + cbxBuyCus.SelectedValue + ","  + nudAmount.Value
              + ",'" + dtpDate.Text + "','" + txbPerson.Text + "','" + txbBuyDesc.Text + "')", "Data ist added");
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update payment_me set custno = "  + cbxBuyCus.SelectedValue + "amount = " + nudAmount.Value
            + ",paydate'" + dtpDate.Text + "', person = '" + txbPerson.Text + "',datails='" + txbBuyDesc.Text + "' where actionno =" + txtActionNr.Text , "Data ist updated");
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from payment_me where payno =" + txtActionNr.Text, "Data ist deleted");
        }
        // keydown if(e.keyData.ToString().ToLower() =="numpad1") Message.Show(e.keyData.ToString()); hier um nur zahlen eingeben zu duerfen
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            string ColName = "";
            if (rbtActionNr.Checked == true)
                ColName = "payno";
            else if (rbtnCustNr.Checked == true)
                ColName = "custno";           
            else if (rbtnAmount.Checked == true)
                ColName = "amount";
            else if (rbtnPaydate.Checked == true)
                ColName = "paydate";
            else 
                ColName = "person";
           
             
            //FilltbItem("select * from item where " + ColName + " like'%" + txbSearch.Text + "%'");
            dgvSearch.DataSource = db.RunReader("select *from payment_me where " + ColName + " like'%" + txbSearch.Text + "%'");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Focus();
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlControls.Visible = true;
            pnlSearch.Visible = false;
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSearch_KeyDown(null, null);
            }
        }

        private void frmPayMe_Load(object sender, EventArgs e)
        {
            txbPerson.Focus();
            Fillcust();           
            dtpDate.Text = DateTime.Now.ToShortDateString();
             
            ClearData();
        }

        private void txbSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShowSearch_Click(null, null);
            }
        }

        private void txbPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            dtpDate.Focus();
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nudAmount.Focus();
        }

        private void nudAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txbBuyDesc.Focus();
        }
    }
}
