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
    public partial class ExportReport : Form
    {
        public ExportReport()
        {
            InitializeComponent();
        }

        private void ExportReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Action_Out' table. You can move, or remove it, as needed.
            this.Action_OutTableAdapter.Fill(this.abdulGmbHDataSet.Action_Out);

            this.reportViewer1.RefreshReport();
        }
    }
}
