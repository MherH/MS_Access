﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MS_Access.InformerForms;

namespace MS_Access.BtnForms
{
    public partial class FormAddPosts : Form
    {
        OleDbCommand cmd;
        public string postnametext;
        public string positionnametext;
        public static FormAddPosts instanceaddpost;
        public FormAddPosts()
        {
            InitializeComponent();
            postnametext = txtPostName.Text;
            positionnametext = txtPositionName.Text;
            instanceaddpost = this;
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Posts ( PostName, [Position] )\r\nSELECT" + " @postname AS Expr1,@position AS Expr2;";
            cmd = new OleDbCommand(insertQuery, FormMain._instance.oledbconstring);
            cmd.Parameters.AddWithValue("@postname", txtPostName.Text);
            cmd.Parameters.AddWithValue("@position", txtPositionName.Text);
            FormMain._instance.oledbconstring.Open();
            cmd.ExecuteNonQuery();
            FormMain._instance.oledbconstring.Close();
            MessageBox.Show("Տվյալները գրանցված են");
            FormPosts.instance.tsbUpdate_Click(null,null);
            this.Close();
            txtPositionName.Clear();
            txtPostName.Clear();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            txtPostName.Clear();
            txtPositionName.Clear();
            this.Close();
        }
    }
}
