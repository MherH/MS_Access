using MS_Access.InformerForms;
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

namespace MS_Access.MSComponents
{
    public partial class OwnDataGridView : UserControl
    {
        OleDbCommand command;
        public static OwnDataGridView instanceown;
        #region
        private bool _loadOnReset;
        public bool isopenedform;
        public string formname;


        #endregion
        public OwnDataGridView()
        {
            InitializeComponent();
            _loadOnReset = true;
            instanceown = this;
            isopenedform = false;
        }

        public void FormConnection(object sender, EventArgs e)
        {
            formname = FindFormName();
            switch (formname)
            {
                case "FormAdmDiv":
                    formname = "AdmDiv";
                    break;

                default:
                    break;

                //case "Համայնք"։
                //MessageBox.Show("inchka");
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            //formname = FindFormName();
            if (FormMain._instance.Connstring == null)
            {
                return;
            }
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FormMain._instance.Connstring;
            string query = "SELECT * FROM " + "@param";
            OleDbConnection conn = new OleDbConnection(connection);
            command = new OleDbCommand(query, conn);
            command.Parameters.AddWithValue("@param", formname);
            if (connection == "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =")
            {
                MessageBox.Show("Խնդրում ենք բեռնավորել ֆայլը");
                return;
            }
            else
            {
                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                conn.Close();
                GridView.DataSource = dt.DefaultView;
            }
        }

        public string FindFormName()
        {
            var formName = FindForm().Name; return formName;
        }
    }
}
