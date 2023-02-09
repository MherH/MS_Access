namespace MS_Access.BtnForms
{
    partial class FormAddPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPosts));
            this.lblPostPost = new System.Windows.Forms.Label();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.lblPostPosition = new System.Windows.Forms.Label();
            this.groupboxNewPost = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPostPost
            // 
            this.lblPostPost.AutoSize = true;
            this.lblPostPost.Location = new System.Drawing.Point(68, 66);
            this.lblPostPost.Name = "lblPostPost";
            this.lblPostPost.Size = new System.Drawing.Size(60, 16);
            this.lblPostPost.TabIndex = 1;
            this.lblPostPost.Text = "Պաշտոն";
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(210, 60);
            this.txtPostName.Multiline = true;
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(164, 22);
            this.txtPostName.TabIndex = 2;
            // 
            // txtPositionName
            // 
            this.txtPositionName.Location = new System.Drawing.Point(210, 103);
            this.txtPositionName.Multiline = true;
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(164, 22);
            this.txtPositionName.TabIndex = 3;
            // 
            // lblPostPosition
            // 
            this.lblPostPosition.AutoSize = true;
            this.lblPostPosition.Location = new System.Drawing.Point(68, 109);
            this.lblPostPosition.Name = "lblPostPosition";
            this.lblPostPosition.Size = new System.Drawing.Size(116, 16);
            this.lblPostPosition.TabIndex = 4;
            this.lblPostPosition.Text = "Ստորաբաժանում";
            // 
            // groupboxNewPost
            // 
            this.groupboxNewPost.Location = new System.Drawing.Point(58, 24);
            this.groupboxNewPost.Name = "groupboxNewPost";
            this.groupboxNewPost.Size = new System.Drawing.Size(366, 168);
            this.groupboxNewPost.TabIndex = 5;
            this.groupboxNewPost.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(85, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Գրանցել";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Չեղարկել";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 247);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPostPosition);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.txtPostName);
            this.Controls.Add(this.lblPostPost);
            this.Controls.Add(this.groupboxNewPost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Նոր/Ավելացնել";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPostPost;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.Label lblPostPosition;
        private System.Windows.Forms.GroupBox groupboxNewPost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}