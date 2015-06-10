namespace Prototype_OrderingSystem_v2
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDeliveryRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquiryCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplifiedChineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fileToolStripMenuItem.Text = "System";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutStripMenuItem1
            // 
            this.logoutStripMenuItem1.Name = "logoutStripMenuItem1";
            this.logoutStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.logoutStripMenuItem1.Text = "Logout";
            this.logoutStripMenuItem1.Click += new System.EventHandler(this.logoutStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.masterDataMaintenanceToolStripMenuItem,
            this.takingOrderToolStripMenuItem,
            this.generateDeliveryRequestToolStripMenuItem,
            this.enquiryCatalogueToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Visible = false;
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // masterDataMaintenanceToolStripMenuItem
            // 
            this.masterDataMaintenanceToolStripMenuItem.Name = "masterDataMaintenanceToolStripMenuItem";
            this.masterDataMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.masterDataMaintenanceToolStripMenuItem.Text = "Master Data Maintenance";
            this.masterDataMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.masterDataMaintenanceToolStripMenuItem_Click);
            // 
            // takingOrderToolStripMenuItem
            // 
            this.takingOrderToolStripMenuItem.Name = "takingOrderToolStripMenuItem";
            this.takingOrderToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.takingOrderToolStripMenuItem.Text = "Taking Order";
            this.takingOrderToolStripMenuItem.Click += new System.EventHandler(this.takingOrderToolStripMenuItem_Click);
            // 
            // generateDeliveryRequestToolStripMenuItem
            // 
            this.generateDeliveryRequestToolStripMenuItem.Name = "generateDeliveryRequestToolStripMenuItem";
            this.generateDeliveryRequestToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.generateDeliveryRequestToolStripMenuItem.Text = "Generate Delivery Request";
            this.generateDeliveryRequestToolStripMenuItem.Click += new System.EventHandler(this.generateDeliveryRequestToolStripMenuItem_Click);
            // 
            // enquiryCatalogueToolStripMenuItem
            // 
            this.enquiryCatalogueToolStripMenuItem.Name = "enquiryCatalogueToolStripMenuItem";
            this.enquiryCatalogueToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.enquiryCatalogueToolStripMenuItem.Text = "Enquiry Catalogue";
            this.enquiryCatalogueToolStripMenuItem.Click += new System.EventHandler(this.enquiryCatalogueToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.simplifiedChineseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // simplifiedChineseToolStripMenuItem
            // 
            this.simplifiedChineseToolStripMenuItem.Name = "simplifiedChineseToolStripMenuItem";
            this.simplifiedChineseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.simplifiedChineseToolStripMenuItem.Text = "Simplified Chinese";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordering System For Staffs";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplifiedChineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDeliveryRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquiryCatalogueToolStripMenuItem;
    }
}

