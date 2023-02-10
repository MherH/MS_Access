using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MS_Access.FileConnect;
using System.Configuration;
using System.Collections;
using MS_Access.BtnForms;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;

namespace MS_Access.InformerForms
{
    public partial class FormPosts : Form
    {
        OleDbCommand cmd;
        public static FormPosts instance;


        public FormPosts()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += Posts_FormClosing;
        }


 
        public void tsbUpdate_Click(object sender, EventArgs e)
        
        {
            if (FormMain._instance.Connstring == null)
            {
                return;
            }
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FormMain._instance.Connstring;
                //FormBrowse.instance.;
            //System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "select * from posts";
            OleDbConnection conn = new OleDbConnection(connection);
            OleDbCommand command = new OleDbCommand(query, conn);
            string constr = FormMain._instance.Connstring;
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

        public void tsbNew_Click(object sender, EventArgs e)
        {
            FormAddPosts addPosts = new FormAddPosts();
            addPosts.ShowDialog();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (tsbSearch.Text == "" || tsbSearch.Text == null)
            {
                tsbUpdate_Click(null, null);
            }
            else
            {
                string searchQuery = "SELECT * FROM Posts WHERE (Posts.[PostName] = " + "@postname" + " or Posts.[Position] = @position)";
                cmd = new OleDbCommand(searchQuery, FormMain._instance.oledbconstring);
                cmd.Parameters.AddWithValue("@postname", tsbSearch.Text);
                cmd.Parameters.AddWithValue("@position", tsbSearch.Text);
                FormMain._instance.oledbconstring.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                FormMain._instance.oledbconstring.Close();
                dgvPosts.DataSource = dt.DefaultView;
            }
        }

        public void tsbEdit_Click(object sender, EventArgs e)
        {
            if (FormPosts.instance.dgvPosts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                FormEditPosts editPosts = new FormEditPosts();
                editPosts.ShowDialog();
            }

        }
        public string GetPostName()
        {
            string postname = FormPosts.instance.dgvPosts.CurrentRow.Cells[1].Value.ToString();
            return postname;
        }

        private void Posts_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormMain._instance.isopenedposts = false;
            }
        }


        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (FormPosts.instance.dgvPosts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Համոզվա՞ծ եք, որ ցանկանում եք հեռացնել նշված տողը", "Զգուշացում", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deletequery = "delete from Posts where ( id = " + "@id )";
                    cmd = new OleDbCommand(deletequery, FormMain._instance.oledbconstring);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvPosts.CurrentRow.Cells[0].Value.ToString()));
                    FormMain._instance.oledbconstring.Open();
                    cmd.ExecuteNonQuery();
                    FormMain._instance.oledbconstring.Close();
                    MessageBox.Show("Տվյալները հեռացված են");
                    FormPosts.instance.tsbUpdate_Click(null, null);
                }
                else
                {

                }
            }
            

        }
    }
}
