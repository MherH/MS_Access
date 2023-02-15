namespace MS_Access
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformers = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompanyReg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdmDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEduc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKadrer = new System.Windows.Forms.ToolStripMenuItem();
            this.MSLogoMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSLogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart,
            this.tsmBrowse,
            this.tsmFinance,
            this.tsmKadrer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmStart
            // 
            this.tsmStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInformers});
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(67, 24);
            this.tsmStart.Text = "Սկիզբ";
            // 
            // tsmInformers
            // 
            this.tsmInformers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPost,
            this.tsmPosition,
            this.tsmCompanyReg,
            this.tsmAdmDiv,
            this.tsmCity,
            this.tsmEduc,
            this.tsmProfLevel});
            this.tsmInformers.Name = "tsmInformers";
            this.tsmInformers.Size = new System.Drawing.Size(224, 26);
            this.tsmInformers.Text = "Տեղեկատուներ";
            // 
            // tspPost
            // 
            this.tspPost.Name = "tspPost";
            this.tspPost.Size = new System.Drawing.Size(316, 26);
            this.tspPost.Text = "Պաշտոն";
            this.tspPost.Click += new System.EventHandler(this.tspPost_Click);
            // 
            // tsmPosition
            // 
            this.tsmPosition.Name = "tsmPosition";
            this.tsmPosition.Size = new System.Drawing.Size(316, 26);
            this.tsmPosition.Text = "Նախագիծ/Ստորաբաժանում";
            this.tsmPosition.Click += new System.EventHandler(this.tsmPosition_Click);
            // 
            // tsmCompanyReg
            // 
            this.tsmCompanyReg.Name = "tsmCompanyReg";
            this.tsmCompanyReg.Size = new System.Drawing.Size(316, 26);
            this.tsmCompanyReg.Text = "Գրանցված կազմակերպություն";
            this.tsmCompanyReg.Click += new System.EventHandler(this.tsmCompanyReg_Click);
            // 
            // tsmAdmDiv
            // 
            this.tsmAdmDiv.Name = "tsmAdmDiv";
            this.tsmAdmDiv.Size = new System.Drawing.Size(316, 26);
            this.tsmAdmDiv.Text = "Համայնք";
            this.tsmAdmDiv.Click += new System.EventHandler(this.tsmAdmDiv_Click);
            // 
            // tsmCity
            // 
            this.tsmCity.Name = "tsmCity";
            this.tsmCity.Size = new System.Drawing.Size(316, 26);
            this.tsmCity.Text = "Քաղաք/մարզ";
            this.tsmCity.Click += new System.EventHandler(this.tsmCity_Click);
            // 
            // tsmEduc
            // 
            this.tsmEduc.Name = "tsmEduc";
            this.tsmEduc.Size = new System.Drawing.Size(316, 26);
            this.tsmEduc.Text = "Կրթություն";
            // 
            // tsmProfLevel
            // 
            this.tsmProfLevel.Name = "tsmProfLevel";
            this.tsmProfLevel.Size = new System.Drawing.Size(316, 26);
            this.tsmProfLevel.Text = "Աշխատանքային մակարդակ";
            // 
            // tsmBrowse
            // 
            this.tsmBrowse.Name = "tsmBrowse";
            this.tsmBrowse.Size = new System.Drawing.Size(56, 24);
            this.tsmBrowse.Text = "Ֆայլ";
            this.tsmBrowse.Click += new System.EventHandler(this.tsmBrowse_Click);
            // 
            // tsmFinance
            // 
            this.tsmFinance.Name = "tsmFinance";
            this.tsmFinance.Size = new System.Drawing.Size(81, 24);
            this.tsmFinance.Text = "Ֆինանս";
            // 
            // tsmKadrer
            // 
            this.tsmKadrer.Name = "tsmKadrer";
            this.tsmKadrer.Size = new System.Drawing.Size(79, 24);
            this.tsmKadrer.Text = "Կադրեր";
            // 
            // MSLogoMain
            // 
            this.MSLogoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSLogoMain.Image = global::MS_Access.Properties.Resources.LogoOlny;
            this.MSLogoMain.InitialImage = null;
            this.MSLogoMain.Location = new System.Drawing.Point(0, 28);
            this.MSLogoMain.Name = "MSLogoMain";
            this.MSLogoMain.Size = new System.Drawing.Size(800, 422);
            this.MSLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MSLogoMain.TabIndex = 1;
            this.MSLogoMain.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MSLogoMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Բարի Գալուստ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSLogoMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmInformers;
        private System.Windows.Forms.ToolStripMenuItem tsmPosition;
        private System.Windows.Forms.PictureBox MSLogoMain;
        private System.Windows.Forms.ToolStripMenuItem tspPost;
        private System.Windows.Forms.ToolStripMenuItem tsmCompanyReg;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmDiv;
        private System.Windows.Forms.ToolStripMenuItem tsmCity;
        private System.Windows.Forms.ToolStripMenuItem tsmEduc;
        private System.Windows.Forms.ToolStripMenuItem tsmProfLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmBrowse;
        private System.Windows.Forms.ToolStripMenuItem tsmFinance;
        private System.Windows.Forms.ToolStripMenuItem tsmKadrer;
    }
}

