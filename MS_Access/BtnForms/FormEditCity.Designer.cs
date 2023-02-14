namespace MS_Access.BtnForms
{
    partial class FormEditCity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.txtCityNameEdit = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.groupboxEditCity = new System.Windows.Forms.GroupBox();
            this.groupboxEditCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(275, 203);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(113, 37);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Չեղարկել";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.Location = new System.Drawing.Point(99, 203);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(113, 37);
            this.btnSaveEdit.TabIndex = 13;
            this.btnSaveEdit.Text = "Գրանցել";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // txtCityNameEdit
            // 
            this.txtCityNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityNameEdit.Location = new System.Drawing.Point(66, 91);
            this.txtCityNameEdit.Multiline = true;
            this.txtCityNameEdit.Name = "txtCityNameEdit";
            this.txtCityNameEdit.Size = new System.Drawing.Size(233, 27);
            this.txtCityNameEdit.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(90, 34);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(183, 30);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "Քաղաք/մարզ անվանում";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupboxEditCity
            // 
            this.groupboxEditCity.Controls.Add(this.txtCityNameEdit);
            this.groupboxEditCity.Controls.Add(this.lblCity);
            this.groupboxEditCity.Location = new System.Drawing.Point(72, 29);
            this.groupboxEditCity.Name = "groupboxEditCity";
            this.groupboxEditCity.Size = new System.Drawing.Size(366, 168);
            this.groupboxEditCity.TabIndex = 12;
            this.groupboxEditCity.TabStop = false;
            // 
            // FormEditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 260);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.groupboxEditCity);
            this.Name = "FormEditCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Խմբագրել";
            this.groupboxEditCity.ResumeLayout(false);
            this.groupboxEditCity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox groupboxEditCity;
        public System.Windows.Forms.TextBox txtCityNameEdit;
    }
}