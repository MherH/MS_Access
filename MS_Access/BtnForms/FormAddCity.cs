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
    public partial class FormAddCity : Form
    {
        OleDbCommand command;
        public FormAddCity()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO City ( City )\r\nSELECT" + " @cityname AS Expr1;";
            command = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@cityname", txtCityName.Text);
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները գրանցված են");
            CityProvince.instancecity.tsbUpdateCity_Click(null, null);
            this.Close();
            txtCityName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCityName.Clear();
            this.Close();
        }
    }
}
