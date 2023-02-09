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
    public partial class FormLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public FormLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mhero\Desktop\ACCESS\MS_Mher.accdb;Persist Security Info=False;";
            this.ActiveControl = txtLogin;
            txtLogin.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            connection.Open(); 

            connection.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where Username ='"+ txtLogin.Text + "' and Password='"+ txtPass.Text + "'";
            
           OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if(count == 1)
            {
                connection.Close();
                connection.Dispose();
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();

            }

            else if (count > 1)
            {
                MessageBox.Show("Dublicate Username and Password");
            }
            else
            {
                MessageBox.Show("Username and Password is incorret");
            }

            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Would you like to Cancel?"
                , "Confirm"
                , MessageBoxButtons.YesNo
                );
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;

            }
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (e.KeyChar.Equals(Convert.ToChar(13)))
                {
                    btnLogin_Click(sender, e);
                }
            
        }

    }
}
