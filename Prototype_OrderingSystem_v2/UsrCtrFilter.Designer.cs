namespace Prototype_OrderingSystem_v2
{
    partial class UsrCtrFilter
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryIDLabel;
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
            System.Windows.Forms.Label descriptionLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.stock_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.designerTextBox = new System.Windows.Forms.TextBox();
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Prototype_OrderingSystem_v2.res.database.dbDataSet();
            this.productTableAdapter = new Prototype_OrderingSystem_v2.res.database.dbDataSetTableAdapters.ProductTableAdapter();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
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
            descriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_levelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.ForeColor = System.Drawing.Color.Black;
            productIDLabel.Location = new System.Drawing.Point(6, 23);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(66, 15);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productNameLabel.ForeColor = System.Drawing.Color.Black;
            productNameLabel.Location = new System.Drawing.Point(232, 23);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(88, 15);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "product Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.Black;
            priceLabel.Location = new System.Drawing.Point(317, 93);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(37, 15);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "price:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryIDLabel.ForeColor = System.Drawing.Color.Black;
            categoryIDLabel.Location = new System.Drawing.Point(6, 58);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(71, 15);
            categoryIDLabel.TabIndex = 6;
            categoryIDLabel.Text = "category ID:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.ForeColor = System.Drawing.Color.Black;
            colorLabel.Location = new System.Drawing.Point(9, 30);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(37, 15);
            colorLabel.TabIndex = 10;
            colorLabel.Text = "color:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.ForeColor = System.Drawing.Color.Black;
            sizeLabel.Location = new System.Drawing.Point(9, 95);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(32, 15);
            sizeLabel.TabIndex = 12;
            sizeLabel.Text = "size:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.ForeColor = System.Drawing.Color.Black;
            weightLabel.Location = new System.Drawing.Point(184, 95);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(46, 15);
            weightLabel.TabIndex = 14;
            weightLabel.Text = "weight:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            materialLabel.ForeColor = System.Drawing.Color.Black;
            materialLabel.Location = new System.Drawing.Point(237, 30);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(55, 15);
            materialLabel.TabIndex = 16;
            materialLabel.Text = "material:";
            // 
            // designerLabel
            // 
            designerLabel.AutoSize = true;
            designerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            designerLabel.ForeColor = System.Drawing.Color.Black;
            designerLabel.Location = new System.Drawing.Point(8, 63);
            designerLabel.Name = "designerLabel";
            designerLabel.Size = new System.Drawing.Size(58, 15);
            designerLabel.TabIndex = 18;
            designerLabel.Text = "designer:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufacturerLabel.ForeColor = System.Drawing.Color.Black;
            manufacturerLabel.Location = new System.Drawing.Point(234, 63);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(83, 15);
            manufacturerLabel.TabIndex = 20;
            manufacturerLabel.Text = "manufacturer:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIDLabel.ForeColor = System.Drawing.Color.Black;
            supplierIDLabel.Location = new System.Drawing.Point(234, 58);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(69, 15);
            supplierIDLabel.TabIndex = 22;
            supplierIDLabel.Text = "supplier ID:";
            // 
            // productionDateLabel
            // 
            productionDateLabel.AutoSize = true;
            productionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productionDateLabel.ForeColor = System.Drawing.Color.Black;
            productionDateLabel.Location = new System.Drawing.Point(232, 132);
            productionDateLabel.Name = "productionDateLabel";
            productionDateLabel.Size = new System.Drawing.Size(97, 15);
            productionDateLabel.TabIndex = 24;
            productionDateLabel.Text = "production Date:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.ForeColor = System.Drawing.Color.Black;
            discountLabel.Location = new System.Drawing.Point(320, 98);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(56, 15);
            discountLabel.TabIndex = 26;
            discountLabel.Text = "discount:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            availableLabel.ForeColor = System.Drawing.Color.Black;
            availableLabel.Location = new System.Drawing.Point(6, 93);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(59, 15);
            availableLabel.TabIndex = 28;
            availableLabel.Text = "available:";
            // 
            // stock_levelLabel
            // 
            stock_levelLabel.AutoSize = true;
            stock_levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stock_levelLabel.ForeColor = System.Drawing.Color.Black;
            stock_levelLabel.Location = new System.Drawing.Point(164, 93);
            stock_levelLabel.Name = "stock_levelLabel";
            stock_levelLabel.Size = new System.Drawing.Size(66, 15);
            stock_levelLabel.TabIndex = 30;
            stock_levelLabel.Text = "stock level:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.Black;
            descriptionLabel.Location = new System.Drawing.Point(9, 132);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(70, 15);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "description:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 395);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(519, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(519, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(519, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 29);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(204, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Advanced Filter";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(527, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 27);
            this.button3.TabIndex = 34;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(19, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnShowHide);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(494, 343);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 32;
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowHide.ForeColor = System.Drawing.Color.White;
            this.btnShowHide.Location = new System.Drawing.Point(146, 129);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(221, 23);
            this.btnShowHide.TabIndex = 28;
            this.btnShowHide.Text = "Show/ Hide additional option";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.categoryIDComboBox);
            this.groupBox1.Controls.Add(categoryIDLabel);
            this.groupBox1.Controls.Add(this.stock_levelNumericUpDown);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(availableLabel);
            this.groupBox1.Controls.Add(this.supplierIDComboBox);
            this.groupBox1.Controls.Add(this.productIDTextBox);
            this.groupBox1.Controls.Add(productNameLabel);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(supplierIDLabel);
            this.groupBox1.Controls.Add(productIDLabel);
            this.groupBox1.Controls.Add(stock_levelLabel);
            this.groupBox1.Controls.Add(this.priceNumericUpDown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 119);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple filering option:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "N",
            "A"});
            this.comboBox1.Location = new System.Drawing.Point(76, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 23);
            this.comboBox1.TabIndex = 32;
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(76, 53);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(152, 23);
            this.categoryIDComboBox.TabIndex = 7;
            // 
            // stock_levelNumericUpDown
            // 
            this.stock_levelNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_levelNumericUpDown.Location = new System.Drawing.Point(236, 91);
            this.stock_levelNumericUpDown.Name = "stock_levelNumericUpDown";
            this.stock_levelNumericUpDown.Size = new System.Drawing.Size(62, 21);
            this.stock_levelNumericUpDown.TabIndex = 31;
            this.stock_levelNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(320, 20);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(152, 21);
            this.productNameTextBox.TabIndex = 3;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(320, 53);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(152, 23);
            this.supplierIDComboBox.TabIndex = 23;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(76, 20);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(152, 21);
            this.productIDTextBox.TabIndex = 1;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(369, 90);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(102, 21);
            this.priceNumericUpDown.TabIndex = 5;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.discountNumericUpDown);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(this.designerTextBox);
            this.groupBox2.Controls.Add(productionDateLabel);
            this.groupBox2.Controls.Add(materialLabel);
            this.groupBox2.Controls.Add(weightLabel);
            this.groupBox2.Controls.Add(designerLabel);
            this.groupBox2.Controls.Add(this.productionDateDateTimePicker);
            this.groupBox2.Controls.Add(manufacturerLabel);
            this.groupBox2.Controls.Add(this.weightNumericUpDown);
            this.groupBox2.Controls.Add(this.manufacturerTextBox);
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(this.materialTextBox);
            this.groupBox2.Controls.Add(this.sizeComboBox);
            this.groupBox2.Controls.Add(this.colorTextBox);
            this.groupBox2.Controls.Add(colorLabel);
            this.groupBox2.Controls.Add(sizeLabel);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 177);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional filter option:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(167, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountNumericUpDown.Location = new System.Drawing.Point(385, 93);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(89, 21);
            this.discountNumericUpDown.TabIndex = 27;
            this.discountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(78, 132);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(148, 40);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // designerTextBox
            // 
            this.designerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerTextBox.Location = new System.Drawing.Point(78, 63);
            this.designerTextBox.Name = "designerTextBox";
            this.designerTextBox.Size = new System.Drawing.Size(152, 21);
            this.designerTextBox.TabIndex = 19;
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.productionDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(326, 130);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(148, 21);
            this.productionDateDateTimePicker.TabIndex = 25;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DecimalPlaces = 2;
            this.weightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightNumericUpDown.Location = new System.Drawing.Point(240, 95);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(66, 21);
            this.weightNumericUpDown.TabIndex = 15;
            this.weightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerTextBox.Location = new System.Drawing.Point(323, 57);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(151, 21);
            this.manufacturerTextBox.TabIndex = 21;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTextBox.Location = new System.Drawing.Point(323, 25);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(151, 21);
            this.materialTextBox.TabIndex = 17;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(78, 95);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(82, 23);
            this.sizeComboBox.TabIndex = 13;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(78, 28);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(82, 21);
            this.colorTextBox.TabIndex = 11;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // UsrCtrFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "UsrCtrFilter";
            this.Size = new System.Drawing.Size(601, 401);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_levelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private res.database.dbDataSet dbDataSet;
        private res.database.dbDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}
