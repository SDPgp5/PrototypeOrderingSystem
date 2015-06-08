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
    public partial class UsrCtrMasterData : UserControl
    {
        public UsrCtrMasterData()
        {
            InitializeComponent();
        }

        private void UsrCtrMasterData_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.dbDataSet.Product);
            this.supplierTableAdapter.Fill(this.dbDataSet.Supplier);
        }
   
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                try
                {
                    productBindingSource.EndEdit();
                    productTableAdapter.Update(this.dbDataSet.Product);
                    MessageBox.Show("Update successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update in Error: " + ex.Message);
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.AddNew();
                productIDTextBox.Text = GenID("PT", "000000", "product");
                btnReset_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add record: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure to delete the record? \n It is irreversible!", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (choice == DialogResult.Yes)
            {
                productBindingSource.RemoveCurrent();
                MessageBox.Show("Delete successfully!");
            }
        }

        private String GenID(String preID, String format, String table) // find out the unused ID; 
        {
            int startingPoint = 0;
            String startingID = preID + startingPoint.ToString(format);
            for (int i = 0; i < productBindingSource.Count; i++)
            {
                foreach (DataRow row in this.dbDataSet.Product)
                {
                    Console.WriteLine("ID:" + startingID + "VS" + row[0]);
                    if (startingID.Equals(row[0]))
                    {
                        startingID = preID + (++startingPoint).ToString(format);
                        break;
                    }
                }
            }
            return startingID;
        }

        private void productNameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (productNameTextBox.Text.Equals(""))
            {
                productNameTextBox.BackColor = System.Drawing.Color.Khaki;
                errProvider.SetError(productNameTextBox, "Cannot be not");
                errProvider.SetIconAlignment(productNameTextBox, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errProvider.SetError(productNameTextBox, "");
                productNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            productBindingSource.CancelEdit();
        }

        private void splitContainer2_Panel2_Leave(object sender, EventArgs e)
        {
            if (dbDataSet.HasChanges())
            {
                DialogResult choice = MessageBox.Show("You are exiting the editing!\nDo you want save your changes?", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (choice == DialogResult.Yes)
                    btnUpdate_Click(null, null);
                else
                    btnCancel_Click(null, null);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            productNameTextBox.Clear();
            priceNumericUpDown.Value = 0;
            categoryIDComboBox.Text = "";
            descriptionTextBox.Clear();
            colorTextBox.Clear();
            sizeComboBox.Text = "";
            weightNumericUpDown.Value = 0;
            materialTextBox.Clear();
            designerTextBox.Clear();
            manufacturerTextBox.Clear();
            supplierIDComboBox.Text = "";
            productionDateDateTimePicker.Text = "";
            discountNumericUpDown.Value = 0;
            availableComboBox.Text = "N";
            stock_levelNumericUpDown.Value = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            UsrCtrFilter ucFilter = new UsrCtrFilter();
            ucFilter.Dock = DockStyle.Fill;
            this.Controls.Add(ucFilter);
            ucFilter.BringToFront();
            Console.WriteLine("Show");
        }





    }
}
