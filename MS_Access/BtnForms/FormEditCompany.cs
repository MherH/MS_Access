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
    public partial class FormEditCompany : Form
    {
        OleDbCommand command;
        public static FormEditCompany instancecompanyedit;
        public FormEditCompany()
        {
            InitializeComponent();
            instancecompanyedit = this;
            txtCompanyNameEdit.Text = FormCompanyReg.instancecompany.GetCompanyName();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE CompanyReg SET CompanyReg.Company =" + " @companyname " + "WHERE (id = @id);";
            command = new OleDbCommand(updateQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@companyname", txtCompanyNameEdit.Text);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(FormCompanyReg.instancecompany.dgvCompany.CurrentRow.Cells[0].Value.ToString()));
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները թարմացված են");
            FormCompanyReg.instancecompany.tsbUpdateCompany_Click(null, null);
            this.Close();
            txtCompanyNameEdit.Clear();
        }
    }
}
