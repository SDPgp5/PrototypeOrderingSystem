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
    public partial class UsrCtrFilter : UserControl
    {
        public UsrCtrFilter()
        {

            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == false)
            {
                btnShowHide.Text = "Show more additional options";
                splitContainer1.Panel2Collapsed = true;
                this.Refresh();
            }
            else
            {
                btnShowHide.Text = "Hide the additional options";
                splitContainer1.Panel2Collapsed = false;
                this.Refresh();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // Make background transparent
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        private void UsrCtrFilter_Load(object sender, EventArgs e)
        {
            CreateParams cp = new CreateParams() ;
        }




    }
}
