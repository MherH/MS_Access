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
    public partial class FormAddPositions : Form
    {
        OleDbCommand command;
        public string positionnametext;
        public FormAddPositions()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Positions ( PositionName )\r\nSELECT" + " @positionname AS Expr1;";
            command = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@positionname", txtPositionName.Text);
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները գրանցված են");
            FormPositions.instance.tsbUpdatePositions_Click(null, null);
            this.Close();
            txtPositionName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPositionName.Clear();
            this.Close();
        }
    }
}
