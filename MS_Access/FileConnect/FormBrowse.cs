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
using System.Web;
using MS_Access.InformerForms;
using System.Xml.Linq;

namespace MS_Access.FileConnect
{ 
    public partial class FormBrowse : Form
    {
        public static FormBrowse instance;
        public  string connstring;
        
        public FormBrowse()
        {
            InitializeComponent();
            instance = this;
            this.FormClosing += Browse_FormClosing;
        }


        public void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathBox.Text = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName;
                string[] names = fileName.Split('.');
                string name1 = names[0];
                //if(FilePathBox.Text != "")
                //{
                //    ReadAccessDB(name1, FilePathBox.Text);
                //}

                // FileNameClass.FileName = FilePathBox.Text;
            }
        }

        private void Browse_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormMain._instance.isopenedbrowse = false;
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            FormMain._instance.Connstring = FilePathBox.Text;
            FormMain._instance.oledbconstring = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + FilePathBox.Text);
            this.Hide();
            if (FilePathBox.Text == null || FilePathBox.Text == "")
            {
                MessageBox.Show("Ֆայլը ընտրված չէ");
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
