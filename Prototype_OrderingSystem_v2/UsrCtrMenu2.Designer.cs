namespace Prototype_OrderingSystem_v2
{
    partial class UsrCtrMenu2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbAccessRight = new System.Windows.Forms.Label();
            this.panBaseMasterData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnqiuryCatalogue = new System.Windows.Forms.Button();
            this.btnTakingOrder = new System.Windows.Forms.Button();
            this.btnGenerateDeliveryRequest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.ProductTableAdapter();
            this.dbDataSet = new Prototype_OrderingSystem_v2.res.database.dbDataSet();
            this.categoryTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.CategoryTableAdapter();
            this.bsDataSet = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.SupplierTableAdapter();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panBaseMasterData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAccessRight
            // 
            this.lbAccessRight.AutoSize = true;
            this.lbAccessRight.Location = new System.Drawing.Point(465, 17);
            this.lbAccessRight.Name = "lbAccessRight";
            this.lbAccessRight.Size = new System.Drawing.Size(0, 13);
            this.lbAccessRight.TabIndex = 20;
            // 
            // panBaseMasterData
            // 
            this.panBaseMasterData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBaseMasterData.BackColor = System.Drawing.Color.DimGray;
            this.panBaseMasterData.Controls.Add(this.panel2);
            this.panBaseMasterData.Controls.Add(this.panel1);
            this.panBaseMasterData.Location = new System.Drawing.Point(3, 3);
            this.panBaseMasterData.Name = "panBaseMasterData";
            this.panBaseMasterData.Size = new System.Drawing.Size(954, 529);
            this.panBaseMasterData.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbAccessRight);
            this.panel2.Controls.Add(this.lbWelcome);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(164, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 343);
            this.panel2.TabIndex = 5;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(41, 44);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(0, 13);
            this.lbWelcome.TabIndex = 19;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(238, 294);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 34);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnqiuryCatalogue);
            this.groupBox2.Controls.Add(this.btnTakingOrder);
            this.groupBox2.Controls.Add(this.btnGenerateDeliveryRequest);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(159, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 156);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Taking Maintainance";
            // 
            // btnEnqiuryCatalogue
            // 
            this.btnEnqiuryCatalogue.BackColor = System.Drawing.Color.IndianRed;
            this.btnEnqiuryCatalogue.FlatAppearance.BorderSize = 0;
            this.btnEnqiuryCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnqiuryCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqiuryCatalogue.ForeColor = System.Drawing.Color.White;
            this.btnEnqiuryCatalogue.Location = new System.Drawing.Point(32, 112);
            this.btnEnqiuryCatalogue.Name = "btnEnqiuryCatalogue";
            this.btnEnqiuryCatalogue.Size = new System.Drawing.Size(186, 25);
            this.btnEnqiuryCatalogue.TabIndex = 15;
            this.btnEnqiuryCatalogue.Text = "Enqiury Catalogue";
            this.btnEnqiuryCatalogue.UseVisualStyleBackColor = false;
            this.btnEnqiuryCatalogue.Click += new System.EventHandler(this.btnEnqiuryCatalogue_Click);
            // 
            // btnTakingOrder
            // 
            this.btnTakingOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnTakingOrder.FlatAppearance.BorderSize = 0;
            this.btnTakingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakingOrder.ForeColor = System.Drawing.Color.White;
            this.btnTakingOrder.Location = new System.Drawing.Point(32, 29);
            this.btnTakingOrder.Name = "btnTakingOrder";
            this.btnTakingOrder.Size = new System.Drawing.Size(186, 25);
            this.btnTakingOrder.TabIndex = 14;
            this.btnTakingOrder.Text = "Taking Order";
            this.btnTakingOrder.UseVisualStyleBackColor = false;
            this.btnTakingOrder.Click += new System.EventHandler(this.btnTakingOrder_Click);
            // 
            // btnGenerateDeliveryRequest
            // 
            this.btnGenerateDeliveryRequest.BackColor = System.Drawing.Color.IndianRed;
            this.btnGenerateDeliveryRequest.FlatAppearance.BorderSize = 0;
            this.btnGenerateDeliveryRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateDeliveryRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDeliveryRequest.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDeliveryRequest.Location = new System.Drawing.Point(32, 69);
            this.btnGenerateDeliveryRequest.Name = "btnGenerateDeliveryRequest";
            this.btnGenerateDeliveryRequest.Size = new System.Drawing.Size(186, 25);
            this.btnGenerateDeliveryRequest.TabIndex = 13;
            this.btnGenerateDeliveryRequest.Text = "Generate Delivery Request";
            this.btnGenerateDeliveryRequest.UseVisualStyleBackColor = false;
            this.btnGenerateDeliveryRequest.Click += new System.EventHandler(this.btnGenerateDeliveryRequest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 87);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::Prototype_OrderingSystem_v2.Properties.Resources.Banner4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // bsDataSet
            // 
            this.bsDataSet.DataSource = this.dbDataSet;
            this.bsDataSet.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dbDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bsDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.dbDataSet;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // UsrCtrMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panBaseMasterData);
            this.Name = "UsrCtrMenu2";
            this.Size = new System.Drawing.Size(968, 546);
            this.Load += new System.EventHandler(this.UsrCtrMenu2_Load);
            this.panBaseMasterData.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAccessRight;
        private System.Windows.Forms.Panel panBaseMasterData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakingOrder;
        private System.Windows.Forms.Button btnGenerateDeliveryRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private res.database.dbDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private res.database.dbDataSet dbDataSet;
        private res.database.dbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource bsDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private res.database.dbDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnEnqiuryCatalogue;

    }
}
