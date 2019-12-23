using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaProject
{
    public partial class frmProg : Form
    {
        public frmProg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // frmHome home = new frmHome();
            //home.MdiParent = this;
            // home.Show();
            //CustSearch frmcs = new CustSearch();
            //frmcs.Show();

        }

        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnCust_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnItem_Click(object sender, EventArgs e)
        {
            frmItems frm = new frmItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnBuy_Click(object sender, EventArgs e)
        {
            frmBuy frm = new frmBuy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnSale_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnStore_Click(object sender, EventArgs e)
        {
            frmStore frm = new frmStore();
            frm.MdiParent = this;
            frm.Show();

        }

        private void tsbtnActionStore_Click(object sender, EventArgs e)
        {
            frmActionStore frm = new frmActionStore();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnStat_Click(object sender, EventArgs e)
        {
            frmStatistics frm = new frmStatistics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnBackup_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnpayment_me_Click(object sender, EventArgs e)
        {
            frmPayMe frm = new frmPayMe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnPayment_to_Click(object sender, EventArgs e)
        {
            frmPayTo frm = new frmPayTo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("calc").Count() == 1) 
                MessageBox.Show("Calc is already open");
            else
            System.Diagnostics.Process.Start("calc"); //Rechner aufmachen
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showstat frm = new Showstat();
            frm.ShowDialog();


        }

        private void suplaierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReport frm = new CustomerReport();
            frm.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(null, null);
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItemsReport frm = new frmItemsReport();
            frm.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportReport frm = new ExportReport();
            frm.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportReport frm = new ImportReport();
            frm.ShowDialog();
        }

        private void phonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhons frm = new frmPhons();
            frm.ShowDialog();
        }

        private void bigBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmProg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //close all programm
        }
    }
}
