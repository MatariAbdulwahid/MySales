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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Buying' table. You can move, or remove it, as needed.
            this.buyingTableAdapter.Fill(this.abdulGmbHDataSet.Buying);
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.abdulGmbHDataSet.Customer);
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Showstat' table. You can move, or remove it, as needed.
            this.ShowstatTableAdapter.Fill(this.abdulGmbHDataSet.Showstat);

            this.rpvCust.RefreshReport();
            this.rpvCust.RefreshReport();
        }
    }
}
