using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype_OrderingSystem_v2
{
    public partial class UsrCtrMenu : UserControl
    {
        String accessRight = "";
        String user;
        FrmMain frmMain;
        public UsrCtrMenu(String accessRight, String user, FrmMain frmMain)
        {
            this.frmMain = frmMain;
            this.accessRight = accessRight;
            this.user = user;
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Leave(object sender, EventArgs e)
        {

        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            UsrCtrMasterData ucMasterData = new UsrCtrMasterData();
            ucMasterData.Dock = DockStyle.Fill;
            this.Controls.Add(ucMasterData);
            ucMasterData.BringToFront();
        }


        private void btnGenerateDeliveryRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to logout the system?", "Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                UsrCtrLogin ucLogin = new UsrCtrLogin(frmMain);
                ucLogin.Dock = DockStyle.Fill;
                this.Controls.Add(ucLogin);
                ucLogin.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsrCtrMenu_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Hello " + user + "\n" + "Welcome to Design Home Ordering System \n";
            lbAccessRight.Text = "Your are login as\n " + accessRight;
        }

        private void btnEnquiryCatalogue_Click(object sender, EventArgs e)
        {
            UsrCtrProductCategory ucProductCategory = new UsrCtrProductCategory();
            ucProductCategory.Dock = DockStyle.Fill;
            this.Controls.Add(ucProductCategory);
            ucProductCategory.BringToFront();
        }


    }
}
