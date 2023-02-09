using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Access.InformerForms
{
    public partial class FormPositions : Form
    {
        public FormPositions()
        {
            InitializeComponent();
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            if (FormMain._instance.Connstring == null)
            {
                return;
            }
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FormMain._instance.Connstring;
            //FormBrowse.instance.;
            //System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "select * from positions";
            OleDbConnection conn = new OleDbConnection(connection);
            OleDbCommand command = new OleDbCommand(query, conn);
            if (connection == "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =")
            {
                MessageBox.Show("Խնդրում ենք բեռնավորել ֆայլը");
                this.Close();
            }
            else
            {
                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvPosts.DataSource = dt.DefaultView;
            }
        }


    }
}
