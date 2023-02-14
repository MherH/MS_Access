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
    public partial class FormAddCompany : Form
    {
        OleDbCommand command;
        public FormAddCompany()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO CompanyReg ( Company )\r\nSELECT" + " @companyname AS Expr1;";
            command = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@companyname", txtCompanyName.Text);
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները գրանցված են");
            FormCompanyReg.instancecompany.tsbUpdateCompany_Click(null, null);
            this.Close();
            txtCompanyName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            this.Close();
        }
    }
}
