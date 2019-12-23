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
    public partial class frmActionStore : Form
    {
        public frmActionStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblActionOut = new DataTable();
        DataTable tblActionIn = new DataTable();
        int intRow = 0;
        string CustNo, ItemNo ,StoreNo;

        private void SetCustItemStoreOut()
        {
            CustNo = cbxCustOut.SelectedValue.ToString();
            ItemNo = cbxItemOut.SelectedValue.ToString();
            StoreNo = cbxStoreOut.SelectedValue.ToString();
        }
        private void SetCustItemStoreIn()
        {
            CustNo = cbxCustIn.SelectedValue.ToString();
            ItemNo = cbxItemIn.SelectedValue.ToString();
            StoreNo = cbxStoreOut.SelectedValue.ToString();
        }
        private void FilltblActionOut(string Selectstatment = "select *from action_out")
        {
            tblActionOut.Clear();
            tblActionOut = db.RunReader(Selectstatment);
        }
        private void FilltblActionIn(string Selectstatment = "select *from action_in")
        {
            tblActionIn.Clear();
            tblActionIn = db.RunReader(Selectstatment);
        }

        private void Fillcust()
        {
            cbxCustOut.DataSource = db.RunReader("select custno,custname from customer");
            cbxCustOut.DisplayMember = "custname";
            cbxCustOut.ValueMember = "custno";
            cbxCustIn.DataSource = db.RunReader("select custno,custname from customer");
            cbxCustIn.DisplayMember = "custname";
            cbxCustIn.ValueMember = "custno";
        }
        private void FillItem()
        {
            cbxItemOut.DataSource = db.RunReader("select itemno,itemname from item");
            cbxItemOut.DisplayMember = "itemname";
            cbxItemOut.ValueMember = "itemno";
            cbxItemIn.DataSource = db.RunReader("select itemno,itemname from item");
            cbxItemIn.DisplayMember = "itemname";
            cbxItemIn.ValueMember = "itemno";
        }
        private void FillIStore()
        {
            cbxStoreOut.DataSource = db.RunReader("select storeno,storename from store");
            cbxStoreOut.DisplayMember = "storename";
            cbxStoreOut.ValueMember = "storeno";
            cbxStoreIn.DataSource = db.RunReader("select storeno,storename from store");
            cbxStoreIn.DisplayMember = "storename";
            cbxStoreIn.ValueMember = "storeno";
        }

        private void AutoNumOut()
        {
            FilltblActionOut("select max(custno) from action_out");
            if (tblActionOut.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNrOut.Text = "1";
            else
                txtActionNrOut.Text = (Convert.ToInt16(tblActionOut.Rows[0][0].ToString()) + 1).ToString();
        }
        private void AutoNumIn()
        { 
            FilltblActionIn("select max(custno) from action_in");
            if (tblActionIn.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNrIn.Text = "1";
            else
                txtActionNrIn.Text = (Convert.ToInt16(tblActionIn.Rows[0][0].ToString()) + 1).ToString();
        }

        private void ClearData()
        {
            AutoNumOut();
            AutoNumIn();
            txtDesOut.Clear();
            txtDesIn.Clear();
            btnEditOut.Enabled = false;
            btnEditIn.Enabled = false;
            btnDeleOut.Enabled = false;
            btnDeltIn.Enabled = false;
            btnAddOut.Enabled = true;
            btnAddIn.Enabled = true;

        }

        private void ShowDataOut()
        {
            FilltblActionOut();
            if (tblActionOut.Rows.Count == 0)
            {
                MessageBox.Show("no data here");
                btnAddOut.Enabled = true;
                btnDeleOut.Enabled = false;
                btnEditOut.Enabled = false;
            }
            else
            {
                txtActionNrOut.Text = tblActionOut.Rows[intRow][0].ToString();
                cbxCustOut.SelectedValue = tblActionOut.Rows[intRow][1].ToString();
                cbxItemOut.SelectedValue = tblActionOut.Rows[intRow][2].ToString();
                cbxStoreOut.SelectedValue = tblActionOut.Rows[intRow][3].ToString();
                nudPriceOut.Value = Convert.ToInt16(tblActionOut.Rows[intRow][4]);
                nudQtyOut.Value = Convert.ToInt16(tblActionOut.Rows[intRow][5]);
                dtpDateOut.Text = tblActionOut.Rows[intRow][6].ToString();
                txtDesOut.Text = tblActionOut.Rows[intRow][6].ToString();
                btnDeleOut.Enabled = true;
                btnEditOut.Enabled = true;
                btnAddOut.Enabled = false;
            }
            

        }
        private void ShowDataIn()
        {
            FilltblActionIn();
            
            if (tblActionIn.Rows.Count == 0)
            {
                MessageBox.Show("no data here");
                btnAddIn.Enabled = true;
                btnDeltIn.Enabled = false;
                btnEditIn.Enabled = false;
            }
            else
            {
                txtActionNrIn.Text = tblActionIn.Rows[intRow][0].ToString();
                cbxCustIn.SelectedValue = tblActionIn.Rows[intRow][1].ToString();
                cbxItemIn.SelectedValue = tblActionIn.Rows[intRow][2].ToString();
                cbxStoreIn.SelectedValue = tblActionIn.Rows[intRow][3].ToString();
                nudPriceIn.Value = Convert.ToInt16(tblActionIn.Rows[intRow][4]);
                nudQtyIn.Value = Convert.ToInt16(tblActionIn.Rows[intRow][5]);
                dtpDateIn.Text = tblActionIn.Rows[intRow][6].ToString();
                txtDesIn.Text = tblActionIn.Rows[intRow][6].ToString();
                btnDeltIn.Enabled = true;
                btnEditIn.Enabled = true;
                btnAddIn.Enabled = false;
            }
           
        }
       
        private void btnFirstIn_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowDataIn();
        }

        private void btnNextIn_Click(object sender, EventArgs e)
        {
            FilltblActionIn();
            intRow += 1;
            if (intRow >= tblActionIn.Rows.Count - 1)
            {
                MessageBox.Show("this is the last");
                return;
            }
            else
            {
                ShowDataIn();
            }
        }

        private void btnPreIn_Click(object sender, EventArgs e)
        {
            FilltblActionIn();
            intRow -= 1;
            if (intRow <= 0)
            {
                MessageBox.Show("this is the First");
                return;
            }
            else
            {
                ShowDataIn();
            }
        }

        private void btnLastIn_Click(object sender, EventArgs e)
        {
            FilltblActionIn();
            intRow = tblActionIn.Rows.Count - 1;
            ShowDataIn();
        }

        private void btnLastOut_Click(object sender, EventArgs e)
        {
            FilltblActionOut();
            intRow = tblActionOut.Rows.Count - 1;
            ShowDataOut();
        }

        private void btnFirstOut_Click(object sender, EventArgs e)
        {
            FilltblActionOut();
            intRow = 0;
            ShowDataOut();
        }

        private void btnNextOut_Click(object sender, EventArgs e)
        {
            FilltblActionOut();
            intRow += 1;
            if (intRow >= tblActionOut.Rows.Count - 1)
            {
                MessageBox.Show("this is the last");
                return;
            }
            else
            {
                ShowDataOut();
            }
        }

       

        private void btnClearOut_Click(object sender, EventArgs e)
        {
            ClearData();
            btnAddOut.Enabled = true;
        }

        private void btnClearIn_Click(object sender, EventArgs e)
        {
            ClearData();
            btnAddIn.Enabled = true;
        }

        private void btnExitOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddOut_Click(object sender, EventArgs e)
        {
 
            db.RunNonQuery("insert into action_out values (" + txtActionNrOut.Text + "," + cbxCustOut.SelectedValue + "," + cbxItemOut.SelectedValue + "," + cbxStoreOut.SelectedValue +
                 "," + nudQtyOut.Value + "," + nudPriceOut.Value + ",'" + dtpDateOut.Text + "','" + txtDesOut.Text + "')", "Data ist added");
            ClearData();
        }
        private void btnAddIn_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into action_out values (" + txtActionNrIn.Text + "," + cbxCustIn.SelectedValue + "," + cbxItemIn.SelectedValue + "," + cbxStoreIn.SelectedValue +
              "," + nudQtyIn.Value + "," + nudPriceIn.Value + ",'" + dtpDateIn.Text + "','" + txtDesIn.Text + "')", "Data ist added");
            ClearData();
        }

        private void btnEditOut_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update action_out set qty=" + nudQtyOut.Value + ",price =" + nudPriceOut.Value + ",actiondate='" + dtpDateOut.Text 
                + "',Details='" + txtDesOut.Text + "' where actionno = " + txtActionNrOut.Text + " and custno= " + cbxCustOut.SelectedValue + " and storeno= " 
                + cbxStoreOut.SelectedValue + " and itemno= " + cbxItemOut.SelectedValue , "Data ist updated");
            ClearData();
        }
        private void btnEditIn_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update action_in set qty=" + nudQtyOut.Value + ",price =" + nudPriceOut.Value + ",actiondate='" + dtpDateOut.Text
               + "',Details='" + txtDesOut.Text + "' where actionno = " + txtActionNrOut.Text + " and custno= " + cbxCustOut.SelectedValue + " and storeno= "
               + cbxStoreOut.SelectedValue + " and itemno= " + cbxItemOut.SelectedValue, "Data ist updated");
            ClearData();
        }
        private void btnDeleOut_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from action_out  where actionno = " + txtActionNrOut.Text + " and custno= " + cbxCustOut.SelectedValue + " and storeno= "
               + cbxStoreOut.SelectedValue + " and itemno= " + cbxItemOut.SelectedValue, "Data ist deleted");
            ClearData();
        }

        private void btnDeltIn_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from action_in  where actionno = " + txtActionNrOut.Text + " and custno= " + cbxCustOut.SelectedValue + " and storeno= "
               + cbxStoreOut.SelectedValue + " and itemno= " + cbxItemOut.SelectedValue, "Data ist deleted");
            ClearData();
        }

        private void btnSearchOut_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            pnlSearch.Location = tabControl1.Location;
            pnlSearch.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            pnlSearch.Visible = false;
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            string ColName = "";
            if (rbtActionNr.Checked == true)
                ColName = "actionno";
            else if (rbtnCustName.Checked == true)
                ColName = "custname";
            else if (rbtnItemNa.Checked == true)
                ColName = "itemno";
             
            else if (rbtnDate.Checked == true)
                ColName = "actiondate";
            else if (rbtnQty.Checked == true)
                ColName = "qty";
            else if (rbtnPrice.Checked == true)
                ColName = "price";

            else return;
            //FilltbItem("select * from item where " + ColName + " like'%" + txbSearch.Text + "%'");

            dgvSearch.DataSource = db.RunReader("select custno , custname , itemno , itemname , storeno , storename , price , qty , actiondate ,details from actionOutAll  where " + ColName + " like'%" + txbSearch.Text + "%'");
            //dgvSearch.DataSource = db.RunReader("select *from actionbuyall where " + ColName + " like '" + txbSearch.Text + "')");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view actionOutAll as select actionno ,action_out.custno ,custname , action_out.itemno ,itemname ,action_out.storeno ,storename , action_out.qty ,action_out.price " +
                " ,action_out.details from item , action_out , customer , store where action_out.custno = customer.custno and action_out.itemno = item.itemno and action_out.storeno = store.storeno  ", "ok");
        }

        private void btnPrevOut_Click(object sender, EventArgs e)
        {
            FilltblActionOut();
            intRow -= 1;
            if (intRow <= 0)
            {
                MessageBox.Show("this is the First");
                return;
            }
            else
            {
                ShowDataOut();
            }
        }

       

        private void frmActionStore_Load(object sender, EventArgs e)
        {
            Fillcust();
            FillItem();
            FillIStore();
            ClearData();
        }
    }
}
