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
        public UsrCtrFilter(UsrCtrMasterData ucMasterData)
        {
            this.ucMasterData = ucMasterData;
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
            this.supplierTableAdapter.Fill(this.dbDataSet.Supplier);
            this.categoryTableAdapter.Fill(this.dbDataSet.Category);
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.parent.close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ucMasterData.getProductBindingSource().RemoveFilter();
            //if (!String.IsNullOrEmpty(productIDTextBox.Text))
           String stockLevel = "";
            if (!String.IsNullOrEmpty(stockLevelTextBox.Text))
                stockLevel = "AND stockLevel = " + Convert.ToInt32(stockLevelTextBox.Text);
            String available ="";
            if (!String.IsNullOrEmpty(availableComboBox.Text))
                available = "AND available = '" + availableComboBox.Text+"'";
            String price = "";
            if (!String.IsNullOrEmpty(priceTextBox.Text))
                price = "AND price = '" + priceTextBox.Text+"'";
             ucMasterData.getProductBindingSource().Filter = string.Format("ProductID Like '%{0}%' AND ProductName Like '%{1}%' AND CategoryID Like '%{2}%' AND SupplierID Like '%{3}%' AND Color Like '%{4}%' AND Material Like '%{5}'"
                   , productIDTextBox.Text, productNameTextBox.Text, categoryIDTextBox.Text, supplierIDTextBox.Text, colorTextBox.Text, materialTextBox.Text) + available + stockLevel + price;

            //ucMasterData.getProductBindingSource().Filter = string.Format("SupplierID Like '%{0}%'", supplierIDTextBox.Text);
            //ucMasterData.getProductBindingSource().Filter = "available = '" + "C" + "'";
          //  Console.WriteLine(string.Format("ProductID Like '%{0}%' AND ProductName Like '%{1}%' AND CategoryID Like '%{2}%' AND SupplierID Like '%{3}%'"
          //          + "AND Available = '{4}'", productIDTextBox.Text, productNameTextBox.Text, categoryIDTextBox.Text, supplierIDTextBox.Text, availableComboBox.Text) + "AND stockLevel = " + Convert.ToInt32(stockLevelTextBox.Text));
           // if (!String.IsNullOrEmpty(stockLevelTextBox.Text))
              //  ucMasterData.getProductBindingSource().Filter = "StockLevel = '" + Convert.ToInt32(stockLevelTextBox.Text) + "'";
           // if (!String.IsNullOrEmpty(priceTextBox.Text))
              //  ucMasterData.getProductBindingSource().Filter = "price = '" + Convert.ToInt32(priceTextBox.Text) + "'";
            
            //ucMasterData.getProductBindingSource().Filter = string.Format("color Like '%{0}%'", colorTextBox.Text);
            //ucMasterData.getProductBindingSource().Filter = string.Format("material Like '%{0}%'", materialTextBox.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        public TextBox getProductIDTextBox() 
        {
            return productIDTextBox;
        }



    }
}
