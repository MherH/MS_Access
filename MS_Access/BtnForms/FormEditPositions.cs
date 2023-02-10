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
    public partial class FormEditPositions : Form
    {
        OleDbCommand command;
        public static FormEditPositions instance;
        public string id;
        public FormEditPositions()
        {
            InitializeComponent();
            instance = this;
            txtPositionNameEdit.Text = FormPositions.instance.GetPositionName();
        }


        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string insertQuery = "UPDATE Positions SET Positions.PositionName =" + " @positionname " + "WHERE (id = @id);";
            command = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            command.Parameters.AddWithValue("@positionname", txtPositionNameEdit.Text);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(FormPositions.instance.dgvPostitions.CurrentRow.Cells[0].Value.ToString()));
            FormMain._instance.oledbconstring.Open();
            command.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները թարմացված են");
            FormPositions.instance.tsbUpdatePositions_Click(null, null);
            this.Close();
            txtPositionNameEdit.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtPositionNameEdit.Clear();
            this.Close();
        }
    }
}
