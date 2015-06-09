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
    public partial class UsrCtrLogin : UserControl
    {
        public UsrCtrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {///

            UsrCtrMasterData ucMasterData = new UsrCtrMasterData();
           // ucMasterData.Dock = DockStyle.Fill;
            this.Controls.Add(ucMasterData);
            ucMasterData.BringToFront();
            Console.WriteLine("Add MasterData");
        }

    }
}
