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
    public partial class FormPositions : Form
    {
        OleDbCommand cmd;
        public static FormPositions instanceposition;
        public FormPositions()
        {
            InitializeComponent();
            instanceposition = this;
            this.FormClosing += Positions_FormClosing;

        }

        public void tsbUpdatePositions_Click(object sender, EventArgs e)
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
                dgvPostitions.DataSource = dt.DefaultView;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
                FormAddPositions addPositions = new FormAddPositions();
            addPositions.ShowDialog();
        }

        private void tsbSearchIcon_Click(object sender, EventArgs e)
        {
            if (tsbSearch.Text == "" || tsbSearch.Text == null)
            {
                tsbUpdatePositions_Click(null, null);
            }
            else
            {
                string searchQuery = "SELECT * FROM Positions WHERE (Positions.[PositionName] = " + "@positionname)";
                cmd = new OleDbCommand(searchQuery, FormMain._instance.oledbconstring);
                cmd.Parameters.AddWithValue("@positionname", tsbSearch.Text);
                FormMain._instance.oledbconstring.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                FormMain._instance.oledbconstring.Close();
                dgvPostitions.DataSource = dt.DefaultView;
            }
        }

        public string GetPositionName()
        {
            string positionname = dgvPostitions.CurrentRow.Cells[1].Value.ToString();
            return positionname;
        }

        private void Positions_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormMain._instance.isopenedpositions = false;
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvPostitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
               FormEditPositions editPostitions = new FormEditPositions();
                editPostitions.ShowDialog();
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (dgvPostitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Համոզվա՞ծ եք, որ ցանկանում եք հեռացնել նշված տողը", "Զգուշացում", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deletequery = "delete from Positions where ( id = " + "@id )";
                    cmd = new OleDbCommand(deletequery, FormMain._instance.oledbconstring);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvPostitions.CurrentRow.Cells[0].Value.ToString()));
                    FormMain._instance.oledbconstring.Open();
                    cmd.ExecuteNonQuery();
                    FormMain._instance.oledbconstring.Close();
                    MessageBox.Show("Տվյալները հեռացված են");
                    tsbUpdatePositions_Click(null, null);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
