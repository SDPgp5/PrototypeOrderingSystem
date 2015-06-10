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
    public partial class UsrCtrMenu2 : UserControl
    {
        String accessRight = "";
        String user = "";
        FrmMain frmMain;
        public UsrCtrMenu2(String accessRight, String user, FrmMain frmMain)
        {
            this.frmMain = frmMain;
            this.accessRight = accessRight;
            this.user = user;
            InitializeComponent();
        }

        private void UsrCtrMenu2_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Hello " + user + "\n" + "Welcome to Design Home Ordering System \n";
            lbAccessRight.Text = "Your are login as\n " + accessRight;
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

        private void btnTakingOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnEnqiuryCatalogue_Click(object sender, EventArgs e)
        {

        }
    }
}
