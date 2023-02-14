namespace MS_Access.BtnForms
{
    partial class FormEditCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCompany));
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.txtCompanyNameEdit = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.groupboxEditCompany = new System.Windows.Forms.GroupBox();
            this.groupboxEditCompany.SuspendLayout();
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
            // txtCompanyNameEdit
            // 
            this.txtCompanyNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyNameEdit.Location = new System.Drawing.Point(66, 85);
            this.txtCompanyNameEdit.Multiline = true;
            this.txtCompanyNameEdit.Name = "txtCompanyNameEdit";
            this.txtCompanyNameEdit.Size = new System.Drawing.Size(231, 27);
            this.txtCompanyNameEdit.TabIndex = 9;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(66, 36);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(231, 30);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Գրանցված կազմ․ անվանում";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupboxEditCompany
            // 
            this.groupboxEditCompany.Controls.Add(this.txtCompanyNameEdit);
            this.groupboxEditCompany.Controls.Add(this.lblCompany);
            this.groupboxEditCompany.Location = new System.Drawing.Point(72, 29);
            this.groupboxEditCompany.Name = "groupboxEditCompany";
            this.groupboxEditCompany.Size = new System.Drawing.Size(366, 168);
            this.groupboxEditCompany.TabIndex = 12;
            this.groupboxEditCompany.TabStop = false;
            // 
            // FormEditCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 260);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.groupboxEditCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Խմբագրել";
            this.groupboxEditCompany.ResumeLayout(false);
            this.groupboxEditCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.GroupBox groupboxEditCompany;
        public System.Windows.Forms.TextBox txtCompanyNameEdit;
    }
}