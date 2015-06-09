using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace Prototype_OrderingSystem_v2
{
    public partial class FrmMain : Form
    {
        ResourceManager resManager;    // declare Resource manager to access to specific cultureinfo
        CultureInfo culInfo;            // declare culture info
        UsrCtrLogin ucLogin;
        UsrCtrMenu ucMenu;
        UsrCtrMenu2 ucMenu2;
        String accessRight = "";
        public FrmMain()
        {
            InitializeComponent();
            simplifiedChineseToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            resManager = new ResourceManager("MultiLanguageApp.Resource.Res", typeof(FrmMain).Assembly);
            switch_language();
            ucLogin = new UsrCtrLogin(this);
            //ucLogin.Dock = DockStyle.Fill;
            this.Controls.Add(ucLogin);

        }
        void switch_language()
        {
            if (simplifiedChineseToolStripMenuItem.Checked == true)
            {
                culInfo = CultureInfo.CreateSpecificCulture("cn");
            }
            else
            {
                culInfo = CultureInfo.CreateSpecificCulture("en");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit the system?", "Confirmation", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes){
                System.Windows.Forms.Application.Exit();    
            }
                                                                                                                                                                                                                                                                                     
        }

        private void logoutStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to logout the system?", "Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ucLogin = new UsrCtrLogin(this);
               // ucLogin.Dock = DockStyle.Fill;
                this.Controls.Add(ucLogin);
                ucLogin.BringToFront();
               menuStrip.BringToFront();
            }
            
        }

        public ToolStripMenuItem getMenuToolStripMenuItem() 
        {
            return menuToolStripMenuItem;
        }

        public ToolStripMenuItem getMasterDataMaintenanceToolStripMenuItem()
        {
            return masterDataMaintenanceToolStripMenuItem;
        }

        public ToolStripMenuItem getlogoutStripMenuItem1()
        {
            return logoutStripMenuItem1;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ucLogin = new UsrCtrLogin(this);
            accessRight = ucLogin.getAccessRight();
            String user = ucLogin.getUser();
            Console.WriteLine(user);
            Console.WriteLine("AR:" + accessRight);
            if (accessRight.Equals("Shop manager"))
            {
                ucMenu = new UsrCtrMenu(accessRight, user, this);
                //ucMenu.Dock = DockStyle.Fill;
                this.Controls.Add(ucMenu);
                ucMenu.BringToFront();
                menuStrip.BringToFront();
                Console.WriteLine("menu works:");
            }
            if (accessRight.Equals("Salesman"))
            {
                ucMenu2 = new UsrCtrMenu2(accessRight, user, this);
                ucMenu2.Dock = DockStyle.Fill;
                this.Controls.Add(ucMenu2);
                ucMenu2.BringToFront();
                menuStrip.BringToFront();
            }

        }

        private void masterDataMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
                UsrCtrMasterData ucMasterData = new UsrCtrMasterData();
                ucMasterData.Dock = DockStyle.Fill;
                this.Controls.Add(ucMasterData);
                ucMasterData.BringToFront();

        }



        private void generateDeliveryRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void takingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enquiryCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }

}
