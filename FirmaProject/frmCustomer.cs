using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FirmaProject
{
    public partial class frmCustomer : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                             + Application.StartupPath + @"\abdulGmbH.accdb;Jet OLEDB:Database Password=123");
        OleDbCommand cmd = new OleDbCommand();
        DataTable tblCust = new DataTable();
        DataTable tblPhone = new DataTable();
        int newRow = 0;

        public frmCustomer()
        {
            InitializeComponent();
        }
       // string text = "select * from customer";
        private void FilltblCust(string text = "select* from customer")
        {

         
             // text = "select* from customer";
                tblCust.Clear();
                tblCust.Columns.Clear();
                cmd.Connection = conn;
                // cmd.CommandText = "select * from  customer";
                cmd.CommandText = text;
                conn.Open();
            tblCust.Load(cmd.ExecuteReader());
            conn.Close();            
        }
        private void ShowData()
        {
            FilltblCust();
            if (tblCust.Rows.Count == 0)
            {
                MessageBox.Show("this is no data");
            }
            txbCNr.Text = tblCust.Rows[newRow][0].ToString();
            txbCName.Text = tblCust.Rows[newRow][1].ToString();
            dtpCudate.Text = tblCust.Rows[newRow][2].ToString();
            txbCuEmail.Text = tblCust.Rows[newRow][3].ToString();
            txbCuAd.Text = tblCust.Rows[newRow][4].ToString();
            //txbCuAd.Text = tblCust.Rows[newRow][5].ToString();
            tblPhone.Clear();
            cmd.Connection = conn;
            cmd.CommandText = "select  phone , type from phone_customer where custNO=" + txbCNr.Text;
            conn.Open();
            tblPhone.Load(cmd.ExecuteReader());
            conn.Close();
            dgvPhones.Rows.Clear();
            foreach (DataRow row in tblPhone.Rows)
            {
                dgvPhones.Rows.Add(1);
                int newRowIndex = dgvPhones.Rows.Count - 2;
                dgvPhones.Rows[newRowIndex].Cells[0].Value = row[0];
                dgvPhones.Rows[newRowIndex].Cells[1].Value = row[1];
            }
            btnEdit.Enabled = true;  // um die Buttons zu schliessen
            btnDele.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string phonNr = txbPhone.Text;
            //string phonTpe = cbType.Text;
            //object[] pNr = { phonNr, phonTpe };
            //dgvPhones.Rows.Add(pNr);

            foreach (DataGridViewRow row in tblPhone.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (txbPhone.Text == row.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("This number is already added pleas enter new number");
                        return;
                    }
                }
            }
            dgvPhones.Rows.Add(1);
            int rowIndex = dgvPhones.Rows.Count - 2;
            dgvPhones.Rows[rowIndex].Cells[0].Value = txbPhone.Text;
            dgvPhones.Rows[rowIndex].Cells[1].Value = cbType.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPhones.Rows.RemoveAt(dgvPhones.CurrentCell.ColumnIndex);
               // dgvPhones.Rows.Clear();  oder mit das remove 
            }
            catch
            {
                MessageBox.Show("no ihon Nr is added");
            }
        }

        private void txbCNr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Down)
            {
                txbCName.Focus();

            }
        }

        private void txbCNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // damit akzeptiert nur zahlen also keine Buchstaben
            }
        }

        private void txbCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtpCudate.Focus();
            }
        }

        private void dtpCudate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txbCuEmail.Focus();
            }
        }

        private void txbCuEmail_KeyDown(object sender, KeyEventArgs e)
        {
             
                if (e.KeyData == Keys.Enter)
                {

                    Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\w+([-.]\w)*$");
                    if (reg.IsMatch(txbCuEmail.Text))
                    {
                        errorProvider1.Clear();
                        isEmailValid = true;
                        txbCuAd.Focus();
                    }
                    else
                    {
                        isEmailValid = false;
                        errorProvider1.SetError(this.txbCuEmail, "Pleas enter valid email");
                        return;

                    }                           
            }
            else return;
        }

        private void txbCuAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txbPhone.Focus();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEmailValid && txbCName.Text.Trim()!="" && txbCuAd.Text.Trim() != ""  )
            {
                cmd.Connection = conn;
                //Add data to database

                cmd.CommandText = "insert into customer values(" + txbCNr.Text + ",'" + txbCName.Text + "','"
                                 + dtpCudate.Text + "','" + txbCuEmail.Text + "','" + txbCuAd.Text + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                //add phones
                conn.Open();
                foreach (DataGridViewRow row in dgvPhones.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        cmd.CommandText = "insert into phone_customer values(" + txbCNr.Text + ",'" +
                        row.Cells[0].Value + "','" + row.Cells[1].Value + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data is added ");
                conn.Close();
                clearData();
            }
            else MessageBox.Show("Pleas check your data");
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
              newRow = 0;
              ShowData();
             
               
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            newRow = tblCust.Rows.Count - 1;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            newRow += 1;
            if (newRow >= tblCust.Rows.Count - 1)
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
            newRow -= 1;
            if (newRow <= 0)
            {
                MessageBox.Show("this is the First");
                return;
               
            }
            else
            {
                ShowData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             
        }
        private void AudoNumber()
        {
            FilltblCust("select max(custno) from customer");
            if (tblCust.Rows[0][0].ToString() == DBNull.Value.ToString())
                txbCNr.Text = "1";
            else
                txbCNr.Text = (Convert.ToInt16(tblCust.Rows[0][0].ToString()) + 1).ToString();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            AudoNumber();
        }
    
        private void clearData()
        {
            AudoNumber();
            txbCName.Clear();
            dtpCudate.Text = DateTime.Now.ToShortDateString();
            txbCuEmail.Clear();
            txbCuAd.Clear();
            dgvPhones.Rows.Clear();
            txbPhone.Clear();
            btnEdit.Enabled = false;  // um die Buttons zu schliessen
            btnDele.Enabled = false;
            btnAdd.Enabled = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            //Add data to database

            cmd.CommandText = "update customer set custname='" +  txbCName.Text + "', startdate='"
                             + dtpCudate.Text + "',email='" + txbCuEmail.Text + "',adress='" + txbCuAd.Text +
                             "'where custno =" + txbCNr.Text;
            conn.Open();
            cmd.ExecuteNonQuery();

            // Delet alle phone number
           
            cmd.CommandText = "delete from phone_customer where custno =" + txbCNr.Text;


            //add phones
             
            foreach (DataGridViewRow row in dgvPhones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cmd.CommandText = "insert into phone_customer values(" + txbCNr.Text + ",'" +
                    row.Cells[0].Value + "','" + row.Cells[1].Value + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            MessageBox.Show("Data is updated ");
            clearData();
           
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "delete from phone_customer where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from buying where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from selling where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from payment_to where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from payment_me where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from action_in where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from action_out where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from customer where custno =" + txbCNr.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data is deleted");
            clearData();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            string ColName = "";
            if (rbtCustNr.Checked == true)
                ColName = "custno";
            else if (rbtnCustName.Checked == true)
                ColName = "custname";
            else if (rbtnStart.Checked == true)
                ColName = "startdate";
            else if (rbtnEmail.Checked == true)
                ColName = "email";
            else if (rbtnAdd.Checked == true)
                ColName = "adress";
            else return;
            FilltblCust("select * from customer where " + ColName + " like '%" + txbSearch.Text + "%'");
            dgvSearch.DataSource = tblCust;
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
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
                btnShowSearch_Click(sender,e);
            }
        }
        private bool isEmailValid;
        private void txbCuEmail_Leave(object sender, EventArgs e)
        {
        }
    }
}
