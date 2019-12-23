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
    public partial class frmBuy : Form
    {
        public frmBuy()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblBuy = new DataTable();
        int intRow = 0;
        string CustNO, ItemNo;
        private void SetCustItem()
        {
            CustNO = cbxBuyCus.SelectedValue.ToString();
            ItemNo = cbxBuyItem.SelectedValue.ToString();
        }

        private void FilltblBuy(string Selectstatment = "select *from buying")
        {
            tblBuy.Clear();
            tblBuy = db.RunReader(Selectstatment);
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

        private void frmBuy_Load(object sender, EventArgs e)
        {
            Fillcust();
            FillItem();
            cbxDate.SelectedIndex = 0;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            SetDay();
            cbxDate.SelectedIndex = DayNr;
            ClearData();
        }
        private void AutoNum()
        {
            FilltblBuy("select max(buyno) from buying");
            if (tblBuy.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNr.Text = "1";
            else
            txtActionNr.Text = (Convert.ToInt16(tblBuy.Rows[0][0].ToString()) + 1).ToString();
            //txbItemNr.Text = tblItem.Rows[0][0].ToString();
        }
        int DayNr;
        private void SetDay()
        {
            string StartOfWeek = DateTime.Now.Date.DayOfWeek.ToString();
            if (StartOfWeek == "Saturday")
                DayNr = 0;
            else if (StartOfWeek == "Suday")
                DayNr = 1;
            else if (StartOfWeek == "Monday")
                DayNr = 2;
            else if (StartOfWeek == "Tuesday")
                DayNr = 3;
            else if (StartOfWeek == "Wednesday")
                DayNr = 4;
            else if (StartOfWeek == "Thursday")
                DayNr = 5;
            else if (StartOfWeek == "Friday")
                DayNr = 6;
        }

        private void CalcTotal()
        {
            txbBuyTotal.Text = (nudBuyQuan.Value * nudPriceBuy.Value ).ToString();
        }
        private void nudPriceBuy_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void nudBuyQuan_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void ClearData()
        {
            AutoNum();
            txbBuyDesc.Clear();
            nudPriceBuy.Value = 1;
            nudBuyQuan.Value = 1;
            btnAdd.Enabled = true;
            btnDele.Enabled = false;
            btnEdit.Enabled = false;
            //cbxBuyCus.Enabled = true;
            //cbxBuyItem.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into buying values ("+txtActionNr.Text+ ","+cbxBuyCus.SelectedValue +","+cbxBuyItem.SelectedValue+",'"+
                (cbxDate.SelectedIndex+1).ToString()+"','"+dtpDate.Text+"',"+nudBuyQuan.Value +","+nudPriceBuy.Value+",'"+txbBuyDesc.Text+"')",
                "Data ist added");
            ClearData();
        }

        private void ShowData()
        {

            FilltblBuy();
            txtActionNr.Text = tblBuy.Rows[intRow][0].ToString();
            cbxBuyCus.SelectedValue = tblBuy.Rows[intRow][1].ToString();
            cbxBuyItem.SelectedValue = tblBuy.Rows[intRow][2].ToString();
            cbxDate.SelectedIndex = Convert.ToInt16(tblBuy.Rows[intRow][3]) - 1;
            dtpDate.Text = tblBuy.Rows[intRow][4].ToString();
            nudBuyQuan.Value = Convert.ToInt16(tblBuy.Rows[intRow][5]);
            nudPriceBuy.Value = Convert.ToInt16(tblBuy.Rows[intRow][6]);
            txbBuyDesc.Text = tblBuy.Rows[intRow][7].ToString();
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDele.Enabled = true;
            //cbxBuyCus.Enabled = false;
            //cbxBuyItem.Enabled = false;
            SetCustItem();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intRow += 1;
            if (intRow >= tblBuy.Rows.Count - 1)
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
            intRow = tblBuy.Rows.Count - 1;
            ShowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update buying set custno=" +CustNO+",itemno= "+ItemNo+", dayno='" + (cbxDate.SelectedIndex + 1).ToString() +
                "',buydate=" + dtpDate.Text + ",qty=" + nudBuyQuan.Value + ",price=" + nudPriceBuy.Value 
                + ",details='" + txbBuyDesc.Text +"' where custno ="+cbxBuyCus.SelectedValue+" and buyno="+
                txtActionNr.Text +"and itemno=" +cbxBuyItem.SelectedValue ,"is updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnCreateView_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view BuyAll as select buying.custno,custname, buying.itemno ,buying.dayno ,dayname,buydate,qty,price,details from buying ,customer ,days ,item where buying.custno=customer.custno and buying.itemno=item.itemno and buying.dayno=days.dayno", "ok");
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
            dgvSearch.DataSource = db.RunReader("select *from buyall where " + ColName +" like'%"+ txbSearch.Text +"%'");
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

        private void nudBuyQuan_ValueChanged_1(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from buying where custno=" + CustNO + "and itemno =" + ItemNo +
                "and buyno="+txtActionNr.Text, "is deleted");
        }
    }
}
