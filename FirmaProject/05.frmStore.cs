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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblStore = new DataTable();
        int intRow = 0;

        private void FilltblStore(string SelectStatment = "select * from Store")
        {
            tblStore.Clear();
           // tblStore.Columns.Clear();
            tblStore=  db.RunReader(SelectStatment);
        }
        private void AutoNum()
        {
            
                
            FilltblStore("select max(storeno) from store");
            if(tblStore.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txbStNr.Text = "1";
            }
            else
            {
                txbStNr.Text = (Convert.ToInt16(tblStore.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        private void ClearData()
        {
            AutoNum();
            txbStName.Clear();
            txbStAdr.Clear();  
            txbStorPhon.Clear();
            btnAdd.Enabled = true;
            btnDele.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void ShowData()
        {
            FilltblStore();
            if (tblStore.Rows.Count == 0)
            {
                MessageBox.Show("No data here");
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDele.Enabled = false;
            }
            else
            {
                txbStNr.Text = tblStore.Rows[intRow][0].ToString();
                txbStName.Text = tblStore.Rows[intRow][1].ToString();
                txbStAdr.Text = tblStore.Rows[intRow][2].ToString();
                txbStorPhon.Text = tblStore.Rows[intRow][3].ToString();

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDele.Enabled = true;
            }
        }
      

    

        private void txbStName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txbStAdr.Focus();
            }
        }

        private void txbStAdr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txbStorPhon.Focus();
            }
        }
        private void txbStorPhon_KeyDown(object sender, KeyEventArgs e)
        {
            if (txbStorPhon.Text.Trim() != "")  //store wird eingefuegt sowohl enter gedruckt wird
                btnAdd_Click(null, null);
            else return;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {

            AutoNum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into store values ("+txbStNr.Text +",'"+ txbStName.Text +"','"+txbStAdr.Text+
                "','"+txbStorPhon.Text+"')" ,"Data ist added");
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update store set values ('" + txbStName.Text + "','" + txbStAdr.Text + "','" + txbStorPhon.Text 
                +"' where storeno="+ txbStNr.Text  , "data is updeted");
            ClearData();
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from action_out where storeno =" + txbStNr.Text, "");
            db.RunNonQuery("delete from action_in where storeno =" + txbStNr.Text, "");
            db.RunNonQuery("delete from store where storeno =" + txbStNr.Text , "data is deleted");
            ClearData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
            if (intRow >= tblStore.Rows.Count - 1)
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

            intRow = tblStore.Rows.Count - 1;
            ShowData();
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
            if (rbtStoreNr.Checked == true)
                ColName = "storeno";
            else if (rbtnStoreName.Checked == true)
                ColName = "storename";
            else if (rbtnAdd.Checked == true)
                ColName = "address";
            else if (rbtnStorePhons.Checked == true)
                ColName = "phone";
            dgvSearch.DataSource = db.RunReader("select *from store where " + ColName + " like'%" + txbSearch.Text + "%'");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
