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
    public partial class frmLogin : Form
    {
        ResourceManager resManager;    // declare Resource manager to access to specific cultureinfo
        CultureInfo culInfo;            // declare culture info

        public frmLogin()
        {
            InitializeComponent();
            simplifiedChineseToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            resManager = new ResourceManager("MultiLanguageApp.Resource.Res", typeof(frmLogin).Assembly);
            switch_language();
            UsrCtrLogin usrCtrLogin = new UsrCtrLogin();
            usrCtrLogin.Dock = DockStyle.Fill;
            this.Controls.Add(usrCtrLogin);
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

    }

}
