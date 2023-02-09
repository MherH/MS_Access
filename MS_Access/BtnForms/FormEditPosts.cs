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

namespace MS_Access.BtnForms
{
    public partial class FormEditPosts : Form
    {
        OleDbCommand command;
        public static FormEditPosts instance;
        public string id;
        public string editposition;
        public string editpost;
        
        public FormEditPosts()
        {
            InitializeComponent();
            instance = this;
           // id = FormPosts.instance.dgvPosts.CurrentRow.Cells[0].Value.ToString();
            editposition = FormPosts.instance.dgvPosts.CurrentRow.Cells[1].Value.ToString();
            editpost = FormPosts.instance.dgvPosts.CurrentRow.Cells[2].Value.ToString();
        }



        public void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string insertQuery = "UPDATE Posts SET Posts.PostName =" + " @postname ," + " Posts.[Position] = @position " +
                "WHERE (id = @id);";
            command = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@postname", txtPostNameEdit.Text);
            command.Parameters.AddWithValue("@position", txtPositionNameEdit.Text);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(FormPosts.instance.dgvPosts.CurrentRow.Cells[0].Value.ToString()));
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները թարմացված են");
            FormPosts.instance.tsbUpdate_Click(null, null);
            this.Close();
            txtPositionNameEdit.Clear();
            txtPostNameEdit.Clear();
        }
    }
}
