namespace MS_Access.BtnForms
{
    partial class FormEditPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPosts));
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.lblPostPosition = new System.Windows.Forms.Label();
            this.txtPositionNameEdit = new System.Windows.Forms.TextBox();
            this.txtPostNameEdit = new System.Windows.Forms.TextBox();
            this.lblPostPost = new System.Windows.Forms.Label();
            this.groupboxNewPost = new System.Windows.Forms.GroupBox();
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
            // lblPostPosition
            // 
            this.lblPostPosition.AutoSize = true;
            this.lblPostPosition.Location = new System.Drawing.Point(82, 114);
            this.lblPostPosition.Name = "lblPostPosition";
            this.lblPostPosition.Size = new System.Drawing.Size(116, 16);
            this.lblPostPosition.TabIndex = 11;
            this.lblPostPosition.Text = "Ստորաբաժանում";
            // 
            // txtPositionNameEdit
            // 
            this.txtPositionNameEdit.Location = new System.Drawing.Point(224, 108);
            this.txtPositionNameEdit.Multiline = true;
            this.txtPositionNameEdit.Name = "txtPositionNameEdit";
            this.txtPositionNameEdit.Size = new System.Drawing.Size(164, 22);
            this.txtPositionNameEdit.TabIndex = 10;
            // 
            // txtPostNameEdit
            // 
            this.txtPostNameEdit.Location = new System.Drawing.Point(224, 65);
            this.txtPostNameEdit.Multiline = true;
            this.txtPostNameEdit.Name = "txtPostNameEdit";
            this.txtPostNameEdit.Size = new System.Drawing.Size(164, 22);
            this.txtPostNameEdit.TabIndex = 9;
            // 
            // lblPostPost
            // 
            this.lblPostPost.AutoSize = true;
            this.lblPostPost.Location = new System.Drawing.Point(82, 71);
            this.lblPostPost.Name = "lblPostPost";
            this.lblPostPost.Size = new System.Drawing.Size(60, 16);
            this.lblPostPost.TabIndex = 8;
            this.lblPostPost.Text = "Պաշտոն";
            // 
            // groupboxNewPost
            // 
            this.groupboxNewPost.Location = new System.Drawing.Point(72, 29);
            this.groupboxNewPost.Name = "groupboxNewPost";
            this.groupboxNewPost.Size = new System.Drawing.Size(366, 168);
            this.groupboxNewPost.TabIndex = 12;
            this.groupboxNewPost.TabStop = false;
            // 
            // FormEditPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 260);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.lblPostPosition);
            this.Controls.Add(this.txtPositionNameEdit);
            this.Controls.Add(this.txtPostNameEdit);
            this.Controls.Add(this.lblPostPost);
            this.Controls.Add(this.groupboxNewPost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditPosts";
            this.Text = "Խմբագրել";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblPostPosition;
        private System.Windows.Forms.Label lblPostPost;
        private System.Windows.Forms.GroupBox groupboxNewPost;
        public System.Windows.Forms.TextBox txtPositionNameEdit;
        public System.Windows.Forms.TextBox txtPostNameEdit;
    }
}