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
    public partial class CityProvince : Form
    {
        OleDbCommand command;
        public static CityProvince instancecity;
        public CityProvince()
        {
            InitializeComponent();
            instancecity = this;
            this.FormClosing += City_FormClosing;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            FormAddCity addCity = new FormAddCity();
            addCity.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                FormEditCity editCity = new FormEditCity();
                editCity.ShowDialog();
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Համոզվա՞ծ եք, որ ցանկանում եք հեռացնել նշված տողը", "Զգուշացում", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deletequery = "delete from City where ( id = " + "@id )";
                    command = new OleDbCommand(deletequery, FormMain._instance.oledbconstring);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(dgvCity.CurrentRow.Cells[0].Value.ToString()));
                    FormMain._instance.oledbconstring.Open();
                    command.ExecuteNonQuery();
                    FormMain._instance.oledbconstring.Close();
                    MessageBox.Show("Տվյալները հեռացված են");
                    tsbUpdateCity_Click(null, null);
                }
                else
                {
                    return;
                }
            }
        }

        public void tsbUpdateCity_Click(object sender, EventArgs e)
        {
            if (FormMain._instance.Connstring == null)
            {
                return;
            }
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FormMain._instance.Connstring;
            //FormBrowse.instance.;
            //System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "select * from City";
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
                dgvCity.DataSource = dt.DefaultView;
            }
        }

        public string GetCityName()
        {
            string cityname = dgvCity.CurrentRow.Cells[1].Value.ToString();
            return cityname;
        }

        private void City_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormMain._instance.isopenedcity = false;
            }
        }

        private void tsbSearchIcon_Click(object sender, EventArgs e)
        {
            if (tsbSearch.Text == "" || tsbSearch.Text == null)
            {
                tsbUpdateCity_Click(null, null);
            }
            else
            {
                string searchQuery = "SELECT * FROM City WHERE (City.[City] = " + "@cityname)";
                command = new OleDbCommand(searchQuery, FormMain._instance.oledbconstring);
                command.Parameters.AddWithValue("@cityname", tsbSearch.Text);
                FormMain._instance.oledbconstring.Open();
                OleDbDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                FormMain._instance.oledbconstring.Close();
                dgvCity.DataSource = dt.DefaultView;
            }
        }
    }
}
