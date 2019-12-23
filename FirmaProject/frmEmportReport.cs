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
    public partial class ImportReport : Form
    {
        public ImportReport()
        {
            InitializeComponent();
        }

        private void frmEmportReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Action_in' table. You can move, or remove it, as needed.
            this.Action_inTableAdapter.Fill(this.abdulGmbHDataSet.Action_in);

            this.reportViewer1.RefreshReport();
        }
    }
}
