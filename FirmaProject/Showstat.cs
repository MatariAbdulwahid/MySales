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
    public partial class Showstat : Form
    {
        public Showstat()
        {
            InitializeComponent();
        }

        private void Showstat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdulGmbHDataSet.Showstat' table. You can move, or remove it, as needed.
            this.ShowstatTableAdapter.Fill(this.abdulGmbHDataSet.Showstat);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
