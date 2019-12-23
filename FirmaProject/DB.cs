using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaProject
{
    class DB
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                            + Application.StartupPath + @"\abdulGmbH.accdb;Jet OLEDB:Database Password=12345");
        OleDbCommand cmd = new OleDbCommand();

        public void SetCommand(string SQLstatment)
        {
            cmd.Connection = conn;
            cmd.CommandText = SQLstatment;
        }

        public bool RunNonQuery(string SQLstatment , string Message)
        {
            try
            {
                SetCommand(SQLstatment);
                conn.Open();
                cmd.ExecuteNonQuery();
                if (Message != "")
                    MessageBox.Show(Message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { conn.Close(); }
        }

        public DataTable RunReader(string SelectStatment)
        {
            DataTable dtl = new DataTable();
            SetCommand(SelectStatment);
            conn.Open();
            dtl.Load(cmd.ExecuteReader());
            conn.Close();
            return dtl;
        }
    }
}
