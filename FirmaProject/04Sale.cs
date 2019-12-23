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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblsell = new DataTable();
        int intRow = 0;
        string CustNO, ItemNo;

       

        private void SetCustItem()
        {
            CustNO = cbxBuyCus.SelectedValue.ToString();
            ItemNo = cbxBuyItem.SelectedValue.ToString();
        }

        private void FilltblBuy(string Selectstatment = "select *from selling")
        {
            tblsell.Clear();
            tblsell = db.RunReader(Selectstatment);
        }

        private void Fillcust()
        {
            cbxBuyCus.DataSource = db.RunReader("select custno,custname from customer");
            cbxBuyCus.DisplayMember = "custname";
            cbxBuyCus.ValueMember = "custno";
        }
        private void FillItem()
        {
            cbxBuyItem.DataSource = db.RunReader("select itemno,itemname from item");
            cbxBuyItem.DisplayMember = "itemname";
            cbxBuyItem.ValueMember = "itemno";
        }
        private void AutoNum()
        {
            FilltblBuy("select max(saleno) from selling");
            if (tblsell.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNr.Text = "1";
            else
                txtActionNr.Text = (Convert.ToInt16(tblsell.Rows[0][0].ToString()) + 1).ToString();
            //txbItemNr.Text = tblItem.Rows[0][0].ToString();
        }
        private void ClearData()
        {
            AutoNum();
            txbBuyDesc.Clear();
            nudPriceBuy.Value = 1;
            nudSellQuan.Value = 1;
            btnAdd.Enabled = true;
            btnDele.Enabled = false;
            btnEdit.Enabled = false;
            
        }
        private void ShowData()
        {

            FilltblBuy();
            if (tblsell.Rows.Count == 0)
            {
                MessageBox.Show("no data here");
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDele.Enabled = false;
            }
            else
            {
                txtActionNr.Text = tblsell.Rows[intRow][0].ToString();
                cbxBuyCus.SelectedValue = tblsell.Rows[intRow][1].ToString();
                cbxBuyItem.SelectedValue = tblsell.Rows[intRow][2].ToString();
                cbxDate.SelectedIndex = Convert.ToInt16(tblsell.Rows[intRow][3]) - 1;
                dtpDate.Text = tblsell.Rows[intRow][4].ToString();
                nudSellQuan.Value = Convert.ToInt16(tblsell.Rows[intRow][5]);
                nudPriceBuy.Value = Convert.ToInt16(tblsell.Rows[intRow][6]);
                txbBuyDesc.Text = tblsell.Rows[intRow][7].ToString();
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDele.Enabled = true;
            }
            //cbxBuyCus.Enabled = false;
            //cbxBuyItem.Enabled = false;
            SetCustItem();

        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            Fillcust();
            FillItem();
            cbxDate.SelectedIndex = 0;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            //SetDay();
            cbxDate.SelectedIndex = 0;
            ClearData();
        }
        private void CalcTotal()
        {
            txbSellTotal.Text = (nudSellQuan.Value * nudPriceBuy.Value).ToString();
        }

        private void nudSellQuan_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into selling values (" + txtActionNr.Text + "," + cbxBuyCus.SelectedValue + "," + cbxBuyItem.SelectedValue + ",'" +
              (cbxDate.SelectedIndex + 1).ToString() + "','" + dtpDate.Text + "'," + nudSellQuan.Value + "," + nudPriceBuy.Value + ",'" + txbBuyDesc.Text + "')",
              "Data ist added");
            ClearData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intRow += 1;
            if (intRow >= tblsell.Rows.Count - 1)
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

            intRow = tblsell.Rows.Count - 1;
            ShowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update selling set custno=" + CustNO + ",itemno= " + ItemNo + ", dayno='" + (cbxDate.SelectedIndex + 1).ToString() +
                "',buydate=" + dtpDate.Text + ",qty=" + nudSellQuan.Value + ",price=" + nudPriceBuy.Value
                + ",details='" + txbBuyDesc.Text + "' where custno =" + cbxBuyCus.SelectedValue + " and saleno=" +
                txtActionNr.Text + "and itemno=" + cbxBuyItem.SelectedValue, "is updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            string ColName = "";
            if (rbtCustNr.Checked == true)
                ColName = "custno";
            else if (rbtnCustName.Checked == true)
                ColName = "custname";
            else if (rbtItemNr.Checked == true)
                ColName = "itemno";
            else if (rbtnItemNa.Checked == true)
                ColName = "itemname";
            else if (rbtnStart.Checked == true)
                ColName = "dayno";
            else if (rbtnQty.Checked == true)
                ColName = "qty";
            else if (rbtnPrice.Checked == true)
                ColName = "pricet";

            else return;
            //FilltbItem("select * from item where " + ColName + " like'%" + txbSearch.Text + "%'");
            dgvSearch.DataSource = db.RunReader("select *from buyall where " + ColName + " like'%" + txbSearch.Text + "%'");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlControls.Visible = true;
            pnlSearch.Visible = false;
            //this.Close();
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShowSearch_Click(null, null);
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from selling where custno=" + CustNO + "and itemno =" + ItemNo +
                "and saleno=" + txtActionNr.Text, "is deleted");
        }

        private void txbSellTotal_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void nudPriceBuy_ValueChanged_1(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void nudPriceBuy_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

    }
}
