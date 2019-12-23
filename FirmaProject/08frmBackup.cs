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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnSetBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // back up fuer database
            fbd.Description = "Select Forder where to save Backup file";
            fbd.ShowDialog();
            try
            {
                System.IO.File.Copy(Application.StartupPath + "\\abdulGmbH.accdb", fbd.SelectedPath + "AbdulGmbH.backup");
                MessageBox.Show("Back up is succeded saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message ,"Message" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // back up fuer database
            fbd.Description = "Select Forder where to restore backup file";
            fbd.ShowDialog();
            try
            {
                System.IO.File.Delete(Application.StartupPath + "\\abdulGmbH.accdb");
                System.IO.File.Copy(Application.StartupPath + "\\AbdulGmbH.backup", fbd.SelectedPath + "abdulGmbH.accdb");
                MessageBox.Show("Back up is succeded retorted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
