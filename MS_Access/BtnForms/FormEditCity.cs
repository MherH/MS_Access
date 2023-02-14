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
    public partial class FormEditCity : Form
    {
        OleDbCommand command;
        public static FormEditCity instancecity;
        public FormEditCity()
        {
            InitializeComponent();
            instancecity = this;
            txtCityNameEdit.Text = CityProvince.instancecity.GetCityName();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE City SET City.City =" + " @cityname " + "WHERE (id = @id);";
            command = new OleDbCommand(updateQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@cityname", txtCityNameEdit.Text);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(CityProvince.instancecity.dgvCity.CurrentRow.Cells[0].Value.ToString()));
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները թարմացված են");
            CityProvince.instancecity.tsbUpdateCity_Click(null, null);
            this.Close();
            txtCityNameEdit.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtCityNameEdit.Clear();
            this.Close();
        }
    }
}
