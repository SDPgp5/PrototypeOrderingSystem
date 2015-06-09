using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prototype_OrderingSystem_v2
{
     
    public partial class UsrCtrLogin : UserControl
    {
        private String connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=res\\database\\db.accdb";
        public bool Login = false;
        public String accessRight;
        public String user;
        FrmMain frmMain;
        public UsrCtrLogin(FrmMain frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
            Login = false;
            accessRight = "";
           // ucMenu = new UsrCtrMenu(accessRight, user, frmMain);
            //ucMenu.Dock = DockStyle.Fill;
           // this.Controls.Add(ucMenu);
            //ucMenu2 = new UsrCtrMenu2(accessRight, user, frmMain);
          //  ucMenu2.Dock = DockStyle.Fill;
            //this.Controls.Add(ucMenu2);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
	        Login = false;

            if (txtStaffID.Text.Length == 0 ||
			    txtPassword.Text.Length == 0)
            {
		        MessageBox.Show("Missing username or password. "
					+ "Please try again.");
		         txtStaffID.Clear();
		         txtPassword.Clear();
	        }
            else
            {
               try
               {
			       DataTable dt = new DataTable();
			       sqlStr = "Select * from Employee";
			       OleDbDataAdapter dataAdapter = 
					    new OleDbDataAdapter(sqlStr, connStr);
			       dataAdapter.Fill(dt);
			       dataAdapter.Dispose();
			        for (int i = 0; i < dt.Rows.Count && !Login; i++)
				    if (txtStaffID.Text.Equals(dt.Rows[i]["empID"])
				        && txtPassword.Text.Equals(dt.Rows[i]["encryptedPassword"]))
                    {
					    Login = true;
                        accessRight =(String)(dt.Rows[i]["jobTitle"]);
                        user = (String)(dt.Rows[i]["lName"]) + (String)(dt.Rows[i]["fName"]);
                    }
			        if (Login)
                    {
				        //this.Hide();
                        /*
                        UsrCtrMasterData ucMasterData = new UsrCtrMasterData();
                        ucMasterData.Dock = DockStyle.Fill;
                        this.Controls.Add(ucMasterData);
                        ucMasterData.BringToFront();
                        Console.WriteLine("Add MasterData");
                         *
                         */
                        frmMain.getMenuToolStripMenuItem().Visible = true;
                        if (accessRight == "Shop manager")
                        {
                            frmMain.getMasterDataMaintenanceToolStripMenuItem().Visible = true;
                            frmMain.getlogoutStripMenuItem1().Visible = true;
                            UsrCtrMenu ucMenu = new UsrCtrMenu(accessRight, user, frmMain);
                            //ucMenu.Dock = DockStyle.Fill;
                            this.Controls.Add(ucMenu);
                            ucMenu.BringToFront();
                        }
                        if (accessRight == "Salesman")
                        {
                            frmMain.getMasterDataMaintenanceToolStripMenuItem().Visible = false;
                            frmMain.getlogoutStripMenuItem1().Visible = true;
                            UsrCtrMenu2 ucMenu2 = new UsrCtrMenu2(accessRight, user, frmMain);
                            //ucMenu2.Dock = DockStyle.Fill;
                            this.Controls.Add(ucMenu2);
                            ucMenu2.BringToFront();
                        }

                    }
			        else
                    {
				        MessageBox.Show("Incorrect user name or password. "
					        + "Please try again.");
				        txtStaffID.Clear();
				        txtPassword.Clear();
			        }
		        }
		            catch (Exception ex)
                    {
			             MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
		            }
            }

        }

        public String getAccessRight()
        {
            return accessRight;
        }

        public String getUser()
        {
            return user;
        }

        private void UsrCtrLogin_Load(object sender, EventArgs e)
        {
            frmMain.getMenuToolStripMenuItem().Visible = false;
            frmMain.getlogoutStripMenuItem1().Visible = false;
        }

    }
}
