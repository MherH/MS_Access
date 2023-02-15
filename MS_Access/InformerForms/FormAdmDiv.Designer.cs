namespace MS_Access.InformerForms
{
    partial class FormAdmDiv
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
            this.ownDataGridView1 = new MS_Access.MSComponents.OwnDataGridView();
            this.SuspendLayout();
            // 
            // ownDataGridView1
            // 
            this.ownDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.ownDataGridView1.Name = "ownDataGridView1";
            this.ownDataGridView1.Size = new System.Drawing.Size(1000, 563);
            this.ownDataGridView1.TabIndex = 0;
            // 
            // FormAdmDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ownDataGridView1);
            this.Name = "FormAdmDiv";
            this.Text = "Համայնք";
            this.ResumeLayout(false);

        }

        #endregion

        private MSComponents.OwnDataGridView ownDataGridView1;
    }
}