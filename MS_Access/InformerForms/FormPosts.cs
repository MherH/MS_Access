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
        //public string editid;
        //public string editpostname;
        //public string editpostition;

        public FormPosts()
        {
            InitializeComponent();
            //editid = editidtext;
            //editpostition = editpositionnametext;
            //editpostname = editpostnametext;
            instance = this;
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
            string SearchQuery = "select * from  Posts where (id = @id or Posts.PostName = @postname or Posts.[Position] = @position";
            cmd.Parameters.AddWithValue("@postname", tsbSearch.Text);
            cmd.Parameters.AddWithValue("@position", tsbSearch.Text);
            cmd.Parameters.AddWithValue("@id", tsbSearch.Text.ToString());
            cmd = new OleDbCommand(SearchQuery, FormMain._instance.oledbconstring);
            FormMain._instance.oledbconstring.Open();
            cmd.ExecuteReader();
            FormMain._instance.oledbconstring.Close();
            FormPosts.instance.tsbUpdate_Click(null, null);
            tsbSearch.Clear();
        }

        public bool searchclicked = false;

        string editidtext;
        string editpostnametext;
        string editpositionnametext;
        public void tsbEdit_Click(object sender, EventArgs e)
        {
            if(FormPosts.instance.dgvPosts.RowCount == 0 )
            {
                MessageBox.Show("Տող ընտրված չէ");
                return;
            }
            //FormEditPosts.instance.txtPostNameEdit.Text = dgvPosts.CurrentRow.Cells[1].Value.ToString();
            //FormEditPosts.instance.txtPositionNameEdit.Text = dgvPosts.CurrentRow.Cells[2].Value.ToString();
            FormEditPosts editPosts = new FormEditPosts();
            editPosts.ShowDialog();

        }   



    }
}
