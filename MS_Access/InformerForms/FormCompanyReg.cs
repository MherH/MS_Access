using MS_Access.BtnForms;
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
    public partial class FormCompanyReg : Form
    {
        OleDbCommand cmd;
        public static FormCompanyReg instancecompany;
        public FormCompanyReg()
        {
            InitializeComponent();
            instancecompany = this;
            this.FormClosing += Company_FormClosing;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            FormAddCompany addCompany = new FormAddCompany();
            addCompany.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvCompany.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                FormEditCompany editCompany = new FormEditCompany();
                editCompany.ShowDialog();
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (dgvCompany.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Համոզվա՞ծ եք, որ ցանկանում եք հեռացնել նշված տողը", "Զգուշացում", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deletequery = "delete from CompanyReg where ( id = " + "@id )";
                    cmd = new OleDbCommand(deletequery, FormMain._instance.oledbconstring);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvCompany.CurrentRow.Cells[0].Value.ToString()));
                    FormMain._instance.oledbconstring.Open();
                    cmd.ExecuteNonQuery();
                    FormMain._instance.oledbconstring.Close();
                    MessageBox.Show("Տվյալները հեռացված են");
                    tsbUpdateCompany_Click(null, null);
                }
                else
                {
                    return;
                }
            }
        }

        public void tsbUpdateCompany_Click(object sender, EventArgs e)
        {
            if (FormMain._instance.Connstring == null)
            {
                return;
            }
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FormMain._instance.Connstring;
            //FormBrowse.instance.;
            //System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "select * from CompanyReg";
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
                dgvCompany.DataSource = dt.DefaultView;
            }
        }

        public string GetCompanyName()
        {
            string companyname = dgvCompany.CurrentRow.Cells[1].Value.ToString();
            return companyname;
        }

        private void Company_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormMain._instance.isopenedcompanyform = false;
            }
        }

        private void tsbSearchIcon_Click(object sender, EventArgs e)
        {
            if (tsbSearch.Text == "" || tsbSearch.Text == null)
            {
                tsbUpdateCompany_Click(null, null);
            }
            else
            {
                string searchQuery = "SELECT * FROM CompanyReg WHERE (Companyreg.[Company] = " + "@companyname)";
                cmd = new OleDbCommand(searchQuery, FormMain._instance.oledbconstring);
                cmd.Parameters.AddWithValue("@companyname", tsbSearch.Text);
                FormMain._instance.oledbconstring.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                FormMain._instance.oledbconstring.Close();
                dgvCompany.DataSource = dt.DefaultView;
            }
        }
    }
}
