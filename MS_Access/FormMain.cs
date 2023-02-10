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

        public bool isopenedposts = false;
        public bool isopenedbrowse = false;
        public bool isopenedpositions = false;
        private void tspPost_Click(object sender, EventArgs e)
        {
            FormPosts f2 = new FormPosts();
            if (isopenedposts == true)
            {
                MessageBox.Show("Պատուհանը արդեն բացված է");
                f2.BringToFront();
                return;
            }
            else
            {
                f2.Show();
                isopenedposts = true;
            }
        }

        public void tsmBrowse_Click(object sender, EventArgs e)
        {
            FormBrowse formBrowse = new FormBrowse();
            if (isopenedbrowse == true)
            {
                MessageBox.Show("Պատուհանը արդեն բացված է");
                formBrowse.BringToFront();
                return;
            }
            else
            {
                formBrowse.Show();
                this.Connstring = formBrowse.connstring;
                isopenedbrowse = true;
            }
        }

        public void tsmPosition_Click(object sender, EventArgs e)
        {
            FormPositions formPositions = new FormPositions();
            if (isopenedpositions == true)
            {
                MessageBox.Show("Պատուհանը արդեն բացված է");
                formPositions.BringToFront();
                return;
            }
            else
            {
                formPositions.Show();
            }
            isopenedpositions = true;
        }
    }
}
