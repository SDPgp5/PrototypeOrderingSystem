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
    public partial class UsrCtrProductCategory : UserControl
    {
        public UsrCtrProductCategory()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Leave(object sender, EventArgs e)
        {

        }

        private void UsrCtrProductCategory_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.dbDataSet.Product);
            this.categoryTableAdapter.Fill(this.dbDataSet.Category);
            foreach (DataRow row in this.dbDataSet.Category.Rows)
            {
                TreeNode node;
                if(String.IsNullOrEmpty(row["parentID"].ToString())){
                     node = new TreeNode(row["categoryName"].ToString());
                     Console.WriteLine("Now" + row["categoryID"].ToString());
                     treeView.Nodes.Add(node);
                    foreach (DataRow subRow in this.dbDataSet.Category.Rows)
                    {
           
                        if (row["categoryID"].ToString().Equals(subRow["parentID"]))
                        {
                            node.Nodes.Add(subRow["categoryName"].ToString());

                            Console.WriteLine("Child" + subRow["categoryID"].ToString()+"Parent " +"Child" + subRow["parentID"].ToString());
                        }
                    }
                }
            }
        }
    }
}
