namespace MS_Access.BtnForms
{
    partial class FormEditPositions
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
            this.txtPositionNameEdit = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.groupboxNewPost = new System.Windows.Forms.GroupBox();
            this.groupboxNewPost.SuspendLayout();
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
            // txtPositionNameEdit
            // 
            this.txtPositionNameEdit.Location = new System.Drawing.Point(203, 71);
            this.txtPositionNameEdit.Multiline = true;
            this.txtPositionNameEdit.Name = "txtPositionNameEdit";
            this.txtPositionNameEdit.Size = new System.Drawing.Size(157, 30);
            this.txtPositionNameEdit.TabIndex = 9;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(6, 71);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(191, 30);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Ստորաբաժանման անվանում";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupboxNewPost
            // 
            this.groupboxNewPost.Controls.Add(this.txtPositionNameEdit);
            this.groupboxNewPost.Controls.Add(this.lblPosition);
            this.groupboxNewPost.Location = new System.Drawing.Point(72, 29);
            this.groupboxNewPost.Name = "groupboxNewPost";
            this.groupboxNewPost.Size = new System.Drawing.Size(366, 168);
            this.groupboxNewPost.TabIndex = 12;
            this.groupboxNewPost.TabStop = false;
            // 
            // FormEditPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 260);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.groupboxNewPost);
            this.Name = "FormEditPositions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Խմբագրել";
            this.groupboxNewPost.ResumeLayout(false);
            this.groupboxNewPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox groupboxNewPost;
        public System.Windows.Forms.TextBox txtPositionNameEdit;
    }
}