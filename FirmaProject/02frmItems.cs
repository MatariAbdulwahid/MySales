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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        DB db = new DB();   //Object from class DB
        DataTable tblItem = new DataTable();
        int intRow = 0;
       
        private void FilltbItem(string SelectStatment = "select * from Item")
        {
            tblItem.Clear();
            tblItem = db.RunReader(SelectStatment);
        }
        private void AutoNum()
        {
            FilltbItem("select max(itemno) from Item");
            if (tblItem.Rows[0][0].ToString() == DBNull.Value.ToString())
                txbItemNr.Text = "1";
            else
                txbItemNr.Text = (Convert.ToInt16(tblItem.Rows[0][0].ToString()) + 1).ToString();
            //txbItemNr.Text = tblItem.Rows[0][0].ToString();
        }
        private void ClearData()
        {
            AutoNum();
            txbItemName.Clear();
            txbItSym.Clear();
            nUdItemPrice.Value = 1;
            
            btnItemAdd.Enabled = true;
            btnItemEdit.Enabled = false;
            btnItemDele.Enabled = false;
        }

        private void ShowData()
        {
            FilltbItem();
            if (tblItem.Rows.Count == 0)
            {
                MessageBox.Show("no data here");
                btnItemAdd.Enabled = true;
                btnItemEdit.Enabled = false;
                btnItemDele.Enabled = false;
            }
            else
            {
                txbItemNr.Text = tblItem.Rows[intRow][0].ToString();
                txbItemName.Text = tblItem.Rows[intRow][1].ToString();
                txbItSym.Text = tblItem.Rows[intRow][2].ToString();
                nUdItemPrice.Value = Convert.ToInt64(tblItem.Rows[intRow][3]);
                btnItemAdd.Enabled = false;
                btnItemEdit.Enabled = true;
                btnItemDele.Enabled = true;
            }
        }

        
        private void txbItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txbItSym.Focus();
            }
        }
        private void txbItSym_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                nUdItemPrice.Focus();
            }
             
        }


        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into Item values(" + txbItemNr.Text + ",'" + txbItemName.Text + "','"
             + txbItSym.Text + "'," + nUdItemPrice.Value + ")", " Data is added");
            ClearData();
        }


        private void frmItems_Load(object sender, EventArgs e)
        {
            AutoNum();
            btnItemDele.Enabled = false;
            btnItemEdit.Enabled = false;
        }


        private void btnItemClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }


        private void btnItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            intRow += 1;
            if (intRow >= tblItem.Rows.Count - 1)
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
             intRow=tblItem.Rows.Count - 1;
            ShowData();
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update Item set itemname='"  + txbItemName.Text + "', symbol='"
             + txbItSym.Text + "',pricet=" +  nUdItemPrice.Value + " where itemno="+ txbItemNr.Text , " Data is udpdated");
            ClearData();
        }

        private void btnItemDele_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from buying where itemno=" + txbItemNr.Text, "");
            db.RunNonQuery("delete from selling where itemno=" + txbItemNr.Text, "");
            db.RunNonQuery("delete from action_out where itemno=" + txbItemNr.Text, "");
            db.RunNonQuery("delete from action_in where itemno=" + txbItemNr.Text, "");
            db.RunNonQuery("delete from Item where itemno=" + txbItemNr.Text, " Data is deleted");
            ClearData();
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            string ColName = "";
            if (rbtItemNr.Checked == true)
                ColName = "itemno";
            else if (rbtnItemNa.Checked == true)
                ColName = "itemname";
            else if (rbtnSym.Checked == true)
                ColName = "symbol";
            else if (rbtnPrice.Checked == true)
                ColName = "pricet";
             
            else return;
            FilltbItem("select * from item where " + ColName + " like'%" + txbSearch.Text + "%'");
            dgvSearch.DataSource = tblItem;

        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;
            pnlSearch.Visible = false;
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {
                btnShowSearch_Click(sender, e);
            }
        }

        private void txbItemNr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txbItemName.Focus();
            }
        }

        private void nUdItemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (nUdItemPrice.Value > 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnItemAdd_Click(null, null);
                }
            }
            else return;
        }
    }
}
