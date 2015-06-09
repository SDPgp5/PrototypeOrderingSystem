namespace Prototype_OrderingSystem_v2
{
    partial class UsrCtrMasterData
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label designerLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label productionDateLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label availableLabel;
            System.Windows.Forms.Label stock_levelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCtrMasterData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panBaseMasterData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnquiry = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsDataSet = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Prototype_OrderingSystem_v2.res.database.dbDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.availableComboBox = new System.Windows.Forms.ComboBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.designerTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stock_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.ProductTableAdapter();
            this.categoryTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.CategoryTableAdapter();
            this.supplierTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.SupplierTableAdapter();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            designerLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            productionDateLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            stock_levelLabel = new System.Windows.Forms.Label();
            this.panBaseMasterData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_levelNumericUpDown)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(13, 29);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(60, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(13, 60);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(77, 13);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "product Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(13, 87);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "price:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(13, 120);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(65, 13);
            categoryIDLabel.TabIndex = 6;
            categoryIDLabel.Text = "category ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 148);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "description:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(13, 179);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 10;
            colorLabel.Text = "color:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(13, 209);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(28, 13);
            sizeLabel.TabIndex = 12;
            sizeLabel.Text = "size:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(13, 234);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(41, 13);
            weightLabel.TabIndex = 14;
            weightLabel.Text = "weight:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(13, 268);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(46, 13);
            materialLabel.TabIndex = 16;
            materialLabel.Text = "material:";
            // 
            // designerLabel
            // 
            designerLabel.AutoSize = true;
            designerLabel.Location = new System.Drawing.Point(13, 298);
            designerLabel.Name = "designerLabel";
            designerLabel.Size = new System.Drawing.Size(50, 13);
            designerLabel.TabIndex = 18;
            designerLabel.Text = "designer:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(13, 328);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(72, 13);
            manufacturerLabel.TabIndex = 20;
            manufacturerLabel.Text = "manufacturer:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(13, 359);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(60, 13);
            supplierIDLabel.TabIndex = 22;
            supplierIDLabel.Text = "supplier ID:";
            // 
            // productionDateLabel
            // 
            productionDateLabel.AutoSize = true;
            productionDateLabel.Location = new System.Drawing.Point(13, 388);
            productionDateLabel.Name = "productionDateLabel";
            productionDateLabel.Size = new System.Drawing.Size(86, 13);
            productionDateLabel.TabIndex = 24;
            productionDateLabel.Text = "production Date:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(13, 414);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 26;
            discountLabel.Text = "discount:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(13, 450);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(52, 13);
            availableLabel.TabIndex = 28;
            availableLabel.Text = "available:";
            // 
            // stock_levelLabel
            // 
            stock_levelLabel.AutoSize = true;
            stock_levelLabel.Location = new System.Drawing.Point(13, 477);
            stock_levelLabel.Name = "stock_levelLabel";
            stock_levelLabel.Size = new System.Drawing.Size(61, 13);
            stock_levelLabel.TabIndex = 30;
            stock_levelLabel.Text = "stock level:";
            // 
            // panBaseMasterData
            // 
            this.panBaseMasterData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBaseMasterData.BackColor = System.Drawing.Color.DimGray;
            this.panBaseMasterData.Controls.Add(this.panel2);
            this.panBaseMasterData.Controls.Add(this.panel1);
            this.panBaseMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBaseMasterData.Location = new System.Drawing.Point(0, 0);
            this.panBaseMasterData.Name = "panBaseMasterData";
            this.panBaseMasterData.Size = new System.Drawing.Size(954, 637);
            this.panBaseMasterData.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(13, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 542);
            this.panel2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEnquiry);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquiry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Keyword:";
            // 
            // txtEnquiry
            // 
            this.txtEnquiry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEnquiry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnquiry.Location = new System.Drawing.Point(72, 23);
            this.txtEnquiry.Name = "txtEnquiry";
            this.txtEnquiry.Size = new System.Drawing.Size(201, 23);
            this.txtEnquiry.TabIndex = 12;
            this.txtEnquiry.TextChanged += new System.EventHandler(this.txtEnquiry_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.IndianRed;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(301, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 25);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Advanced Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(750, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh table";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(750, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 25);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print table";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabCategory);
            this.tabControl1.Location = new System.Drawing.Point(14, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.splitContainer2);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(887, 421);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Leave += new System.EventHandler(this.splitContainer2_Panel2_Leave);
            this.splitContainer2.Size = new System.Drawing.Size(881, 415);
            this.splitContainer2.SplitterDistance = 511;
            this.splitContainer2.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "/Total records: {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 390);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(511, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bsDataSet;
            // 
            // bsDataSet
            // 
            this.bsDataSet.DataSource = this.dbDataSet;
            this.bsDataSet.Position = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(101, 22);
            this.bindingNavigatorCountItem.Text = "/Total records: {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.designerDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.productBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 350);
            this.dataGridView2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel4);
            this.splitContainer3.Size = new System.Drawing.Size(366, 415);
            this.splitContainer3.SplitterDistance = 362;
            this.splitContainer3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.availableComboBox);
            this.panel3.Controls.Add(productIDLabel);
            this.panel3.Controls.Add(this.productIDTextBox);
            this.panel3.Controls.Add(productNameLabel);
            this.panel3.Controls.Add(this.productNameTextBox);
            this.panel3.Controls.Add(priceLabel);
            this.panel3.Controls.Add(this.priceNumericUpDown);
            this.panel3.Controls.Add(categoryIDLabel);
            this.panel3.Controls.Add(this.categoryIDComboBox);
            this.panel3.Controls.Add(descriptionLabel);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Controls.Add(colorLabel);
            this.panel3.Controls.Add(this.colorTextBox);
            this.panel3.Controls.Add(sizeLabel);
            this.panel3.Controls.Add(this.sizeComboBox);
            this.panel3.Controls.Add(weightLabel);
            this.panel3.Controls.Add(this.weightNumericUpDown);
            this.panel3.Controls.Add(materialLabel);
            this.panel3.Controls.Add(this.materialTextBox);
            this.panel3.Controls.Add(designerLabel);
            this.panel3.Controls.Add(this.designerTextBox);
            this.panel3.Controls.Add(manufacturerLabel);
            this.panel3.Controls.Add(this.manufacturerTextBox);
            this.panel3.Controls.Add(supplierIDLabel);
            this.panel3.Controls.Add(this.supplierIDComboBox);
            this.panel3.Controls.Add(productionDateLabel);
            this.panel3.Controls.Add(this.productionDateDateTimePicker);
            this.panel3.Controls.Add(discountLabel);
            this.panel3.Controls.Add(this.discountNumericUpDown);
            this.panel3.Controls.Add(availableLabel);
            this.panel3.Controls.Add(stock_levelLabel);
            this.panel3.Controls.Add(this.stock_levelNumericUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 362);
            this.panel3.TabIndex = 0;
            // 
            // availableComboBox
            // 
            this.availableComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productBindingSource, "available", true));
            this.availableComboBox.FormattingEnabled = true;
            this.availableComboBox.Items.AddRange(new object[] {
            "A",
            "N"});
            this.availableComboBox.Location = new System.Drawing.Point(102, 446);
            this.availableComboBox.Name = "availableComboBox";
            this.availableComboBox.Size = new System.Drawing.Size(121, 21);
            this.availableComboBox.TabIndex = 32;
            this.availableComboBox.Text = "N";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "productID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(102, 26);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.productIDTextBox.TabIndex = 1;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "productName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(102, 56);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.productNameTextBox.TabIndex = 3;
            this.productNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productNameTextBox_Validating);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "price", true));
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(102, 87);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.priceNumericUpDown.TabIndex = 5;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumericUpDown.ThousandsSeparator = true;
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "categoryID", true));
            this.categoryIDComboBox.DataSource = this.categoryBindingSource;
            this.categoryIDComboBox.DisplayMember = "categoryID";
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(102, 117);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryIDComboBox.TabIndex = 7;
            this.categoryIDComboBox.ValueMember = "categoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dbDataSet;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(102, 145);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 24);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(102, 176);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(200, 20);
            this.colorTextBox.TabIndex = 11;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "size", true));
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.sizeComboBox.Location = new System.Drawing.Point(102, 206);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(200, 21);
            this.sizeComboBox.TabIndex = 13;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "weight", true));
            this.weightNumericUpDown.DecimalPlaces = 2;
            this.weightNumericUpDown.Location = new System.Drawing.Point(102, 234);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.weightNumericUpDown.TabIndex = 15;
            this.weightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "material", true));
            this.materialTextBox.Location = new System.Drawing.Point(102, 264);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(200, 20);
            this.materialTextBox.TabIndex = 17;
            // 
            // designerTextBox
            // 
            this.designerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "designer", true));
            this.designerTextBox.Location = new System.Drawing.Point(102, 295);
            this.designerTextBox.Name = "designerTextBox";
            this.designerTextBox.Size = new System.Drawing.Size(195, 20);
            this.designerTextBox.TabIndex = 19;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(102, 325);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(195, 20);
            this.manufacturerTextBox.TabIndex = 21;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "supplierID", true));
            this.supplierIDComboBox.DataSource = this.supplierBindingSource;
            this.supplierIDComboBox.DisplayMember = "supplierID";
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(102, 355);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(195, 21);
            this.supplierIDComboBox.TabIndex = 23;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.dbDataSet;
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.productionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "productionDate", true));
            this.productionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(102, 384);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.productionDateDateTimePicker.TabIndex = 25;
            this.productionDateDateTimePicker.Value = new System.DateTime(2015, 6, 6, 0, 0, 0, 0);
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(102, 414);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(195, 20);
            this.discountNumericUpDown.TabIndex = 27;
            // 
            // stock_levelNumericUpDown
            // 
            this.stock_levelNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "stockLevel", true));
            this.stock_levelNumericUpDown.Location = new System.Drawing.Point(102, 477);
            this.stock_levelNumericUpDown.Name = "stock_levelNumericUpDown";
            this.stock_levelNumericUpDown.Size = new System.Drawing.Size(195, 20);
            this.stock_levelNumericUpDown.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 49);
            this.panel4.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(34, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(136, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.splitContainer1);
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(887, 421);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(881, 415);
            this.splitContainer1.SplitterDistance = 627;
            this.splitContainer1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnImportCSV);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(446, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 60);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access Record: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(87, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.BackColor = System.Drawing.Color.IndianRed;
            this.btnImportCSV.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnImportCSV.FlatAppearance.BorderSize = 0;
            this.btnImportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImportCSV.ForeColor = System.Drawing.Color.White;
            this.btnImportCSV.Location = new System.Drawing.Point(165, 23);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(96, 25);
            this.btnImportCSV.TabIndex = 12;
            this.btnImportCSV.Text = "Import CSV";
            this.btnImportCSV.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 87);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(363, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designerDataGridViewTextBoxColumn
            // 
            this.designerDataGridViewTextBoxColumn.DataPropertyName = "designer";
            this.designerDataGridViewTextBoxColumn.HeaderText = "designer";
            this.designerDataGridViewTextBoxColumn.Name = "designerDataGridViewTextBoxColumn";
            this.designerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "productionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "productionDate";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            this.availableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stockLevel";
            this.dataGridViewTextBoxColumn1.HeaderText = "stockLevel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // UsrCtrMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panBaseMasterData);
            this.Name = "UsrCtrMasterData";
            this.Size = new System.Drawing.Size(954, 637);
            this.Load += new System.EventHandler(this.UsrCtrMasterData_Load);
            this.panBaseMasterData.ResumeLayout(false);
            this.panBaseMasterData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_levelNumericUpDown)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabCategory.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBaseMasterData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private res.database.dbDataSet dbDataSet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox designerTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.DateTimePicker productionDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown stock_levelNumericUpDown;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource bsDataSet;
        private res.database.dbDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private res.database.dbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private res.database.dbDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ComboBox availableComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEnquiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

    }
}
