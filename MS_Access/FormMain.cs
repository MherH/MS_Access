using MS_Access.FileConnect;
using MS_Access.InformerForms;
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

namespace MS_Access
{
    public partial class FormMain : Form
    {
        public static FormMain  _instance;
        public string Connstring;
        public OleDbConnection oledbconstring;
        public FormMain()
        {
            InitializeComponent();
            Connstring = "";
            oledbconstring = new OleDbConnection();
            _instance = this;
        }


        private void tspPost_Click(object sender, EventArgs e)
        {
            FormPosts f2 = new FormPosts();
            f2.Show();
        }

        public void tsmBrowse_Click(object sender, EventArgs e)
        {
            FormBrowse formBrowse = new FormBrowse();
            formBrowse.Show();
            this.Connstring = formBrowse.connstring;

        }

        public void tsmPosition_Click(object sender, EventArgs e)
        {
            FormPositions formPositions = new FormPositions();
            formPositions.Show();
        }
    }
}
