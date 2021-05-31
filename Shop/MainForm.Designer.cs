namespace Shop
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shopSquareTextBox = new System.Windows.Forms.TextBox();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.shopNumberTextBox = new System.Windows.Forms.TextBox();
            this.shopsDataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Shop.ShopDataSet();
            this.updateShopButton = new System.Windows.Forms.Button();
            this.deleteShopButton = new System.Windows.Forms.Button();
            this.addShopButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.sortCmb = new System.Windows.Forms.ComboBox();
            this.getAllSortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.updateSortButton = new System.Windows.Forms.Button();
            this.deleteSortButton = new System.Windows.Forms.Button();
            this.addSortButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sortNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.updateProductInShopButton = new System.Windows.Forms.Button();
            this.deleteProductInShopButton = new System.Windows.Forms.Button();
            this.addProductInShopButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shopCmb = new System.Windows.Forms.ComboBox();
            this.productCmb = new System.Windows.Forms.ComboBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.productsInShopGridView = new System.Windows.Forms.DataGridView();
            this.shopnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllProductsInShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.shopsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.shopDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.shopInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.shopSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.shopUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.getAllShopsTableAdapter = new Shop.ShopDataSetTableAdapters.getAllShopsTableAdapter();
            this.getAllSortsTableAdapter = new Shop.ShopDataSetTableAdapters.getAllSortsTableAdapter();
            this.sortSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.sortInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sortUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.sortDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sortsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.productInShopSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.productInShopInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.productInShopUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.productInShopDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.productInShopDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.queryButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productSelectCommand = new System.Data.SqlClient.SqlCommand();
            this.productAddCommand = new System.Data.SqlClient.SqlCommand();
            this.productUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.productDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.productsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.getAllProductsTableAdapter = new Shop.ShopDataSetTableAdapters.getAllProductsTableAdapter();
            this.getAllProductsInShopTableAdapter = new Shop.ShopDataSetTableAdapters.getAllProductsInShopTableAdapter();
            this.treeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllSortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInShopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsInShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 42);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.shopSquareTextBox);
            this.tabPage1.Controls.Add(this.shopAddressTextBox);
            this.tabPage1.Controls.Add(this.shopNameTextBox);
            this.tabPage1.Controls.Add(this.shopNumberTextBox);
            this.tabPage1.Controls.Add(this.shopsDataGridView);
            this.tabPage1.Controls.Add(this.updateShopButton);
            this.tabPage1.Controls.Add(this.deleteShopButton);
            this.tabPage1.Controls.Add(this.addShopButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазины";
            // 
            // shopSquareTextBox
            // 
            this.shopSquareTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopSquareTextBox.Location = new System.Drawing.Point(730, 84);
            this.shopSquareTextBox.Name = "shopSquareTextBox";
            this.shopSquareTextBox.Size = new System.Drawing.Size(156, 20);
            this.shopSquareTextBox.TabIndex = 28;
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopAddressTextBox.Location = new System.Drawing.Point(730, 58);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(156, 20);
            this.shopAddressTextBox.TabIndex = 27;
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopNameTextBox.Location = new System.Drawing.Point(730, 32);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.shopNameTextBox.TabIndex = 26;
            // 
            // shopNumberTextBox
            // 
            this.shopNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopNumberTextBox.Location = new System.Drawing.Point(730, 6);
            this.shopNumberTextBox.Name = "shopNumberTextBox";
            this.shopNumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.shopNumberTextBox.TabIndex = 25;
            // 
            // shopsDataGridView
            // 
            this.shopsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopsDataGridView.AutoGenerateColumns = false;
            this.shopsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.squareDataGridViewTextBoxColumn});
            this.shopsDataGridView.DataSource = this.getAllShopsBindingSource;
            this.shopsDataGridView.Location = new System.Drawing.Point(9, 6);
            this.shopsDataGridView.Name = "shopsDataGridView";
            this.shopsDataGridView.Size = new System.Drawing.Size(626, 425);
            this.shopsDataGridView.TabIndex = 24;
            this.shopsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // squareDataGridViewTextBoxColumn
            // 
            this.squareDataGridViewTextBoxColumn.DataPropertyName = "square";
            this.squareDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.squareDataGridViewTextBoxColumn.Name = "squareDataGridViewTextBoxColumn";
            // 
            // getAllShopsBindingSource
            // 
            this.getAllShopsBindingSource.DataMember = "getAllShops";
            this.getAllShopsBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateShopButton
            // 
            this.updateShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateShopButton.Location = new System.Drawing.Point(722, 119);
            this.updateShopButton.Name = "updateShopButton";
            this.updateShopButton.Size = new System.Drawing.Size(75, 23);
            this.updateShopButton.TabIndex = 23;
            this.updateShopButton.Text = "Изменить";
            this.updateShopButton.UseVisualStyleBackColor = true;
            this.updateShopButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteShopButton
            // 
            this.deleteShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteShopButton.Location = new System.Drawing.Point(803, 119);
            this.deleteShopButton.Name = "deleteShopButton";
            this.deleteShopButton.Size = new System.Drawing.Size(75, 23);
            this.deleteShopButton.TabIndex = 22;
            this.deleteShopButton.Text = "Удалить";
            this.deleteShopButton.UseVisualStyleBackColor = true;
            this.deleteShopButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addShopButton
            // 
            this.addShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addShopButton.Location = new System.Drawing.Point(641, 119);
            this.addShopButton.Name = "addShopButton";
            this.addShopButton.Size = new System.Drawing.Size(75, 23);
            this.addShopButton.TabIndex = 21;
            this.addShopButton.Text = "Добавить";
            this.addShopButton.UseVisualStyleBackColor = true;
            this.addShopButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Площадь";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.updateProductButton);
            this.tabPage2.Controls.Add(this.deleteProductButton);
            this.tabPage2.Controls.Add(this.addProductButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.productNameTextBox);
            this.tabPage2.Controls.Add(this.sortCmb);
            this.tabPage2.Controls.Add(this.productsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            // 
            // updateProductButton
            // 
            this.updateProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateProductButton.Location = new System.Drawing.Point(725, 67);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(75, 23);
            this.updateProductButton.TabIndex = 17;
            this.updateProductButton.Text = "Изменить";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.Location = new System.Drawing.Point(806, 67);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 16;
            this.deleteProductButton.Text = "Удалить";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.Location = new System.Drawing.Point(644, 67);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Наименование:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сорт:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextBox.Location = new System.Drawing.Point(736, 6);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.productNameTextBox.TabIndex = 13;
            // 
            // sortCmb
            // 
            this.sortCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortCmb.DataSource = this.getAllSortsBindingSource;
            this.sortCmb.DisplayMember = "name";
            this.sortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCmb.FormattingEnabled = true;
            this.sortCmb.Location = new System.Drawing.Point(736, 32);
            this.sortCmb.Name = "sortCmb";
            this.sortCmb.Size = new System.Drawing.Size(143, 21);
            this.sortCmb.TabIndex = 14;
            this.sortCmb.ValueMember = "id";
            // 
            // getAllSortsBindingSource
            // 
            this.getAllSortsBindingSource.DataMember = "getAllSorts";
            this.getAllSortsBindingSource.DataSource = this.shopDataSet;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn,
            this.id1DataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.getAllProductsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(9, 6);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(629, 358);
            this.productsDataGridView.TabIndex = 10;
            this.productsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellEnter);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "id1";
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            this.id1DataGridViewTextBoxColumn.ReadOnly = true;
            this.id1DataGridViewTextBoxColumn.Visible = false;
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "Сорт";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            // 
            // getAllProductsBindingSource
            // 
            this.getAllProductsBindingSource.DataMember = "getAllProducts";
            this.getAllProductsBindingSource.DataSource = this.shopDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.updateSortButton);
            this.tabPage3.Controls.Add(this.deleteSortButton);
            this.tabPage3.Controls.Add(this.addSortButton);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.sortNameTextBox);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(889, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сорта";
            // 
            // updateSortButton
            // 
            this.updateSortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateSortButton.Location = new System.Drawing.Point(723, 32);
            this.updateSortButton.Name = "updateSortButton";
            this.updateSortButton.Size = new System.Drawing.Size(75, 23);
            this.updateSortButton.TabIndex = 13;
            this.updateSortButton.Text = "Изменить";
            this.updateSortButton.UseVisualStyleBackColor = true;
            this.updateSortButton.Click += new System.EventHandler(this.UpdateSortButton_Click);
            // 
            // deleteSortButton
            // 
            this.deleteSortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSortButton.Location = new System.Drawing.Point(804, 32);
            this.deleteSortButton.Name = "deleteSortButton";
            this.deleteSortButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSortButton.TabIndex = 12;
            this.deleteSortButton.Text = "Удалить";
            this.deleteSortButton.UseVisualStyleBackColor = true;
            this.deleteSortButton.Click += new System.EventHandler(this.DeleteSortButton_Click);
            // 
            // addSortButton
            // 
            this.addSortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSortButton.Location = new System.Drawing.Point(642, 32);
            this.addSortButton.Name = "addSortButton";
            this.addSortButton.Size = new System.Drawing.Size(75, 23);
            this.addSortButton.TabIndex = 11;
            this.addSortButton.Text = "Добавить";
            this.addSortButton.UseVisualStyleBackColor = true;
            this.addSortButton.Click += new System.EventHandler(this.AddSortButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Наименование";
            // 
            // sortNameTextBox
            // 
            this.sortNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortNameTextBox.Location = new System.Drawing.Point(724, 6);
            this.sortNameTextBox.Name = "sortNameTextBox";
            this.sortNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.sortNameTextBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.getAllSortsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 358);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.updateProductInShopButton);
            this.tabPage4.Controls.Add(this.deleteProductInShopButton);
            this.tabPage4.Controls.Add(this.addProductInShopButton);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.shopCmb);
            this.tabPage4.Controls.Add(this.productCmb);
            this.tabPage4.Controls.Add(this.unitTextBox);
            this.tabPage4.Controls.Add(this.quantityTextBox);
            this.tabPage4.Controls.Add(this.costTextBox);
            this.tabPage4.Controls.Add(this.productsInShopGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(889, 441);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Продукты в магазинах";
            // 
            // updateProductInShopButton
            // 
            this.updateProductInShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateProductInShopButton.Location = new System.Drawing.Point(678, 144);
            this.updateProductInShopButton.Name = "updateProductInShopButton";
            this.updateProductInShopButton.Size = new System.Drawing.Size(75, 23);
            this.updateProductInShopButton.TabIndex = 16;
            this.updateProductInShopButton.Text = "Изменить";
            this.updateProductInShopButton.UseVisualStyleBackColor = true;
            this.updateProductInShopButton.Click += new System.EventHandler(this.UpdateProductInShopButton_Click);
            // 
            // deleteProductInShopButton
            // 
            this.deleteProductInShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductInShopButton.Location = new System.Drawing.Point(759, 144);
            this.deleteProductInShopButton.Name = "deleteProductInShopButton";
            this.deleteProductInShopButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductInShopButton.TabIndex = 15;
            this.deleteProductInShopButton.Text = "Удалить";
            this.deleteProductInShopButton.UseVisualStyleBackColor = true;
            this.deleteProductInShopButton.Click += new System.EventHandler(this.DeleteProductInShopButton_Click);
            // 
            // addProductInShopButton
            // 
            this.addProductInShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductInShopButton.Location = new System.Drawing.Point(597, 144);
            this.addProductInShopButton.Name = "addProductInShopButton";
            this.addProductInShopButton.Size = new System.Drawing.Size(75, 23);
            this.addProductInShopButton.TabIndex = 14;
            this.addProductInShopButton.Text = "Добавить";
            this.addProductInShopButton.UseVisualStyleBackColor = true;
            this.addProductInShopButton.Click += new System.EventHandler(this.AddProductInShopButton_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(594, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Стоимость";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Количество";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Единица измерения";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Товар";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Магазин";
            // 
            // shopCmb
            // 
            this.shopCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopCmb.DataSource = this.getAllShopsBindingSource;
            this.shopCmb.DisplayMember = "name";
            this.shopCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shopCmb.Location = new System.Drawing.Point(709, 4);
            this.shopCmb.Name = "shopCmb";
            this.shopCmb.Size = new System.Drawing.Size(170, 21);
            this.shopCmb.TabIndex = 5;
            this.shopCmb.ValueMember = "number";
            // 
            // productCmb
            // 
            this.productCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productCmb.DataSource = this.getAllProductsBindingSource;
            this.productCmb.DisplayMember = "name";
            this.productCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCmb.Location = new System.Drawing.Point(709, 31);
            this.productCmb.Name = "productCmb";
            this.productCmb.Size = new System.Drawing.Size(170, 21);
            this.productCmb.TabIndex = 4;
            this.productCmb.ValueMember = "id";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitTextBox.Location = new System.Drawing.Point(709, 109);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(170, 20);
            this.unitTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextBox.Location = new System.Drawing.Point(709, 83);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(170, 20);
            this.quantityTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.Location = new System.Drawing.Point(709, 57);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(170, 20);
            this.costTextBox.TabIndex = 1;
            // 
            // productsInShopGridView
            // 
            this.productsInShopGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsInShopGridView.AutoGenerateColumns = false;
            this.productsInShopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInShopGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopnumberDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.productsidDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.productsInShopGridView.DataSource = this.getAllProductsInShopBindingSource;
            this.productsInShopGridView.Location = new System.Drawing.Point(10, 4);
            this.productsInShopGridView.Name = "productsInShopGridView";
            this.productsInShopGridView.Size = new System.Drawing.Size(578, 427);
            this.productsInShopGridView.TabIndex = 0;
            this.productsInShopGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEnter);
            // 
            // shopnumberDataGridViewTextBoxColumn
            // 
            this.shopnumberDataGridViewTextBoxColumn.DataPropertyName = "Shop_number";
            this.shopnumberDataGridViewTextBoxColumn.HeaderText = "Номер магазина";
            this.shopnumberDataGridViewTextBoxColumn.Name = "shopnumberDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // productsidDataGridViewTextBoxColumn
            // 
            this.productsidDataGridViewTextBoxColumn.DataPropertyName = "Products_id";
            this.productsidDataGridViewTextBoxColumn.HeaderText = "Products_id";
            this.productsidDataGridViewTextBoxColumn.Name = "productsidDataGridViewTextBoxColumn";
            this.productsidDataGridViewTextBoxColumn.Visible = false;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количетсво";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // getAllProductsInShopBindingSource
            // 
            this.getAllProductsInShopBindingSource.DataMember = "getAllProductsInShop";
            this.getAllProductsInShopBindingSource.DataSource = this.shopDataSet;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // shopsDataAdapter
            // 
            this.shopsDataAdapter.DeleteCommand = this.shopDeleteCommand;
            this.shopsDataAdapter.InsertCommand = this.shopInsertCommand;
            this.shopsDataAdapter.SelectCommand = this.shopSelectCommand;
            this.shopsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "getAllShops", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("address", "address"),
                        new System.Data.Common.DataColumnMapping("square", "square")})});
            this.shopsDataAdapter.UpdateCommand = this.shopUpdateCommand;
            // 
            // shopDeleteCommand
            // 
            this.shopDeleteCommand.CommandText = "dbo.deleteShop";
            this.shopDeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.shopDeleteCommand.Connection = this.sqlConnection;
            this.shopDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.Int, 4, "number")});
            // 
            // shopInsertCommand
            // 
            this.shopInsertCommand.CommandText = "dbo.addShop";
            this.shopInsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.shopInsertCommand.Connection = this.sqlConnection;
            this.shopInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.Int, 4, "number"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 255, "name"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 255, "address"),
            new System.Data.SqlClient.SqlParameter("@square", System.Data.SqlDbType.Float, 8, "square")});
            // 
            // shopSelectCommand
            // 
            this.shopSelectCommand.CommandText = "dbo.getAllShops";
            this.shopSelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.shopSelectCommand.Connection = this.sqlConnection;
            this.shopSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // shopUpdateCommand
            // 
            this.shopUpdateCommand.CommandText = "dbo.updateShop";
            this.shopUpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.shopUpdateCommand.Connection = this.sqlConnection;
            this.shopUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.Int, 4, "number"),
            new System.Data.SqlClient.SqlParameter("@newNumber", System.Data.SqlDbType.Int, 4, "number"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 255, "name"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 255, "address"),
            new System.Data.SqlClient.SqlParameter("@square", System.Data.SqlDbType.Float, 8, "square")});
            // 
            // getAllShopsTableAdapter
            // 
            this.getAllShopsTableAdapter.ClearBeforeFill = true;
            // 
            // getAllSortsTableAdapter
            // 
            this.getAllSortsTableAdapter.ClearBeforeFill = true;
            // 
            // sortSelectCommand
            // 
            this.sortSelectCommand.CommandText = "dbo.getAllSorts";
            this.sortSelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.sortSelectCommand.Connection = this.sqlConnection;
            this.sortSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sortInsertCommand
            // 
            this.sortInsertCommand.CommandText = "dbo.addSort";
            this.sortInsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.sortInsertCommand.Connection = this.sqlConnection;
            this.sortInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name")});
            // 
            // sortUpdateCommand
            // 
            this.sortUpdateCommand.CommandText = "dbo.updateSort";
            this.sortUpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.sortUpdateCommand.Connection = this.sqlConnection;
            this.sortUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20, "name")});
            // 
            // sortDeleteCommand
            // 
            this.sortDeleteCommand.CommandText = "dbo.deleteSort";
            this.sortDeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.sortDeleteCommand.Connection = this.sqlConnection;
            this.sortDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sortsDataAdapter
            // 
            this.sortsDataAdapter.DeleteCommand = this.sortDeleteCommand;
            this.sortsDataAdapter.InsertCommand = this.sortInsertCommand;
            this.sortsDataAdapter.SelectCommand = this.sortSelectCommand;
            this.sortsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "getAllSorts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name")})});
            this.sortsDataAdapter.UpdateCommand = this.sortUpdateCommand;
            // 
            // productInShopSelectCommand
            // 
            this.productInShopSelectCommand.CommandText = "dbo.getAllProductsInShop";
            this.productInShopSelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productInShopSelectCommand.Connection = this.sqlConnection;
            this.productInShopSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // productInShopInsertCommand
            // 
            this.productInShopInsertCommand.CommandText = "dbo.addProduct_in_Shop";
            this.productInShopInsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productInShopInsertCommand.Connection = this.sqlConnection;
            this.productInShopInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@productId", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@shopNumber", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "cost", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.Float, 8, "quantity"),
            new System.Data.SqlClient.SqlParameter("@unit", System.Data.SqlDbType.NVarChar, 20, "unit")});
            // 
            // productInShopUpdateCommand
            // 
            this.productInShopUpdateCommand.CommandText = "dbo.updateProductInShop";
            this.productInShopUpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productInShopUpdateCommand.Connection = this.sqlConnection;
            this.productInShopUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@productId", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@shopNumber", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@newProductId", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@newShopNumber", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "cost", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.Float, 8, "quantity"),
            new System.Data.SqlClient.SqlParameter("@unit", System.Data.SqlDbType.NVarChar, 20, "unit")});
            // 
            // productInShopDeleteCommand
            // 
            this.productInShopDeleteCommand.CommandText = "dbo.deleteProductInShop";
            this.productInShopDeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productInShopDeleteCommand.Connection = this.sqlConnection;
            this.productInShopDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // productInShopDataAdapter
            // 
            this.productInShopDataAdapter.DeleteCommand = this.productInShopDeleteCommand;
            this.productInShopDataAdapter.InsertCommand = this.productInShopInsertCommand;
            this.productInShopDataAdapter.SelectCommand = this.productInShopSelectCommand;
            this.productInShopDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "getAllProductsInShop", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("cost", "cost"),
                        new System.Data.Common.DataColumnMapping("quantity", "quantity"),
                        new System.Data.Common.DataColumnMapping("unit", "unit"),
                        new System.Data.Common.DataColumnMapping("Products_id", "Products_id"),
                        new System.Data.Common.DataColumnMapping("Shop_number", "Shop_number"),
                        new System.Data.Common.DataColumnMapping("Product_name", "Product_name")})});
            this.productInShopDataAdapter.UpdateCommand = this.productInShopUpdateCommand;
            // 
            // queryButton1
            // 
            this.queryButton1.Location = new System.Drawing.Point(93, 13);
            this.queryButton1.Name = "queryButton1";
            this.queryButton1.Size = new System.Drawing.Size(75, 23);
            this.queryButton1.TabIndex = 1;
            this.queryButton1.Text = "Запрос 2";
            this.queryButton1.UseVisualStyleBackColor = true;
            this.queryButton1.Click += new System.EventHandler(this.QueryButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запрос 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // productSelectCommand
            // 
            this.productSelectCommand.CommandText = "dbo.getAllProducts";
            this.productSelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productSelectCommand.Connection = this.sqlConnection;
            this.productSelectCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // productAddCommand
            // 
            this.productAddCommand.CommandText = "dbo.addProduct";
            this.productAddCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productAddCommand.Connection = this.sqlConnection;
            this.productAddCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 255, "name"),
            new System.Data.SqlClient.SqlParameter("@sortId", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // productUpdateCommand
            // 
            this.productUpdateCommand.CommandText = "dbo.updateProduct";
            this.productUpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productUpdateCommand.Connection = this.sqlConnection;
            this.productUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 255, "name"),
            new System.Data.SqlClient.SqlParameter("@Sort_id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // productDeleteCommand
            // 
            this.productDeleteCommand.CommandText = "dbo.deleteProduct";
            this.productDeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.productDeleteCommand.Connection = this.sqlConnection;
            this.productDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // productsDataAdapter
            // 
            this.productsDataAdapter.DeleteCommand = this.productDeleteCommand;
            this.productsDataAdapter.InsertCommand = this.productAddCommand;
            this.productsDataAdapter.SelectCommand = this.productSelectCommand;
            this.productsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "getAllProducts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("id1", "id1"),
                        new System.Data.Common.DataColumnMapping("name1", "name1")})});
            this.productsDataAdapter.UpdateCommand = this.productUpdateCommand;
            // 
            // getAllProductsTableAdapter
            // 
            this.getAllProductsTableAdapter.ClearBeforeFill = true;
            // 
            // getAllProductsInShopTableAdapter
            // 
            this.getAllProductsInShopTableAdapter.ClearBeforeFill = true;
            // 
            // treeButton
            // 
            this.treeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeButton.Location = new System.Drawing.Point(803, 13);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(75, 23);
            this.treeButton.TabIndex = 3;
            this.treeButton.Text = "Tree";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.treeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queryButton1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllSortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInShopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProductsInShopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView shopsDataGridView;
        private System.Windows.Forms.Button updateShopButton;
        private System.Windows.Forms.Button deleteShopButton;
        private System.Windows.Forms.Button addShopButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shopSquareTextBox;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.TextBox shopNumberTextBox;
        private System.Windows.Forms.BindingSource getAllShopsBindingSource;
        private ShopDataSet shopDataSet;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlDataAdapter shopsDataAdapter;
        private System.Data.SqlClient.SqlCommand shopInsertCommand;
        private System.Data.SqlClient.SqlCommand shopSelectCommand;
        private System.Data.SqlClient.SqlCommand shopUpdateCommand;
        private ShopDataSetTableAdapters.getAllShopsTableAdapter getAllShopsTableAdapter;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox sortCmb;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        private ShopDataSetTableAdapters.getAllSortsTableAdapter getAllSortsTableAdapter;
        private System.Windows.Forms.BindingSource getAllSortsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sortNameTextBox;
        private System.Windows.Forms.Button updateSortButton;
        private System.Windows.Forms.Button deleteSortButton;
        private System.Windows.Forms.Button addSortButton;
        private System.Data.SqlClient.SqlCommand shopDeleteCommand;
        private System.Data.SqlClient.SqlCommand sortSelectCommand;
        private System.Data.SqlClient.SqlCommand sortInsertCommand;
        private System.Data.SqlClient.SqlCommand sortUpdateCommand;
        private System.Data.SqlClient.SqlCommand sortDeleteCommand;
        private System.Data.SqlClient.SqlDataAdapter sortsDataAdapter;
        private System.Windows.Forms.DataGridView productsInShopGridView;
        private System.Windows.Forms.Button updateProductInShopButton;
        private System.Windows.Forms.Button deleteProductInShopButton;
        private System.Windows.Forms.Button addProductInShopButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox shopCmb;
        private System.Windows.Forms.ComboBox productCmb;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Data.SqlClient.SqlCommand productInShopSelectCommand;
        private System.Data.SqlClient.SqlCommand productInShopInsertCommand;
        private System.Data.SqlClient.SqlCommand productInShopUpdateCommand;
        private System.Data.SqlClient.SqlCommand productInShopDeleteCommand;
        private System.Data.SqlClient.SqlDataAdapter productInShopDataAdapter;
        private System.Windows.Forms.Button queryButton1;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlCommand productSelectCommand;
        private System.Data.SqlClient.SqlCommand productAddCommand;
        private System.Data.SqlClient.SqlCommand productUpdateCommand;
        private System.Data.SqlClient.SqlCommand productDeleteCommand;
        private System.Data.SqlClient.SqlDataAdapter productsDataAdapter;
        private System.Windows.Forms.BindingSource getAllProductsBindingSource;
        private ShopDataSetTableAdapters.getAllProductsTableAdapter getAllProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareDataGridViewTextBoxColumn;
        private ShopDataSetTableAdapters.getAllProductsInShopTableAdapter getAllProductsInShopTableAdapter;
        private System.Windows.Forms.BindingSource getAllProductsInShopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button treeButton;
    }
}