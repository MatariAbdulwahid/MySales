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
    public partial class frmPhons : Form
    {
        public frmPhons()
        {
            InitializeComponent();
        }

        private void frmPhons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Phone_Customer' table. You can move, or remove it, as needed.
            this.Phone_CustomerTableAdapter.Fill(this.abdulGmbHDataSet.Phone_Customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
