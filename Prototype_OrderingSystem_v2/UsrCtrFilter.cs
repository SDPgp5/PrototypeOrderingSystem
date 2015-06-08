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
        //dsadsaad
        UsrCtrMasterData ucMasterData;
        String productID;
        public UsrCtrFilter(String productID, UsrCtrMasterData ucMasterData)
        {
            this.ucMasterData = ucMasterData;
            this.productID = productID;
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

        private void UsrCtrFilter_Load(object sender, EventArgs e)
        {
            productIDTextBox.Text = productID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.parent.close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ucMasterData.getProductBindingSource().Filter = string.Format("ProductID Like '%{0}%'", productIDTextBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("ProductName Like '%{0}%'", productNameTextBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("CategoryID Like '%{0}%'", categoryIDComboBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("SupplierID Like '%{0}%'", supplierIDComboBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("Available Like '%{0}%'", availableComboBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("StockLevel Like '%{0}%'",stockLevelTextBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("price Like '%{0}%'", priceTextBox.Text);
            ucMasterData.getProductBindingSource().Filter = string.Format("color Like '%{0}%'", colorTextBox.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }





    }
}
