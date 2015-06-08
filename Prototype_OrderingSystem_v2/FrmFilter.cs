using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype_OrderingSystem_v2
{
    public partial class FrmFilter : Form
    {
        UsrCtrMasterData ucMasterData;
        String productID;
        UsrCtrFilter ucFilter;
        public FrmFilter(String productID, UsrCtrMasterData ucMasterData)
        {
            ucFilter = new UsrCtrFilter(productID, ucMasterData);
            this.ucMasterData = ucMasterData;
            this.productID = productID;
            InitializeComponent();
        }

        private void FrmFilter_Load(object sender, EventArgs e)
       {
            ucFilter.Dock = DockStyle.Fill;
            this.Controls.Add(ucFilter);
       }

        private void FrmFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
                this.Hide();
                e.Cancel = true;
        }



        //private void FrmFilter_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Hide();
        //    e.Cancel = true;
       // }
    }
}
