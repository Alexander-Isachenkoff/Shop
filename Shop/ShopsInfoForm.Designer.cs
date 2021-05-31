namespace Shop
{
    partial class ShopsInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getShopsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet1 = new Shop.ShopDataSet();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.shopDataSet = new Shop.ShopDataSet();
            this.getShopsInfoTableAdapter = new Shop.ShopDataSetTableAdapters.getShopsInfoTableAdapter();
            this.excelReportButton = new System.Windows.Forms.Button();
            this.reportViewerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShopsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.squareDataGridViewTextBoxColumn,
            this.avgSquareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getShopsInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // squareDataGridViewTextBoxColumn
            // 
            this.squareDataGridViewTextBoxColumn.DataPropertyName = "square";
            this.squareDataGridViewTextBoxColumn.HeaderText = "square";
            this.squareDataGridViewTextBoxColumn.Name = "squareDataGridViewTextBoxColumn";
            // 
            // avgSquareDataGridViewTextBoxColumn
            // 
            this.avgSquareDataGridViewTextBoxColumn.DataPropertyName = "Avg_Square";
            this.avgSquareDataGridViewTextBoxColumn.HeaderText = "Avg_Square";
            this.avgSquareDataGridViewTextBoxColumn.Name = "avgSquareDataGridViewTextBoxColumn";
            this.avgSquareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getShopsInfoBindingSource
            // 
            this.getShopsInfoBindingSource.DataMember = "getShopsInfo";
            this.getShopsInfoBindingSource.DataSource = this.shopDataSet1;
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "ShopDataSet";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.getShopsInfo";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "getShopsInfo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("address", "address"),
                        new System.Data.Common.DataColumnMapping("square", "square"),
                        new System.Data.Common.DataColumnMapping("Avg_Square", "Avg_Square")})});
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getShopsInfoTableAdapter
            // 
            this.getShopsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // excelReportButton
            // 
            this.excelReportButton.Location = new System.Drawing.Point(13, 13);
            this.excelReportButton.Name = "excelReportButton";
            this.excelReportButton.Size = new System.Drawing.Size(75, 23);
            this.excelReportButton.TabIndex = 1;
            this.excelReportButton.Text = "Отчёт Excel";
            this.excelReportButton.UseVisualStyleBackColor = true;
            this.excelReportButton.Click += new System.EventHandler(this.ExcelReportButton_Click);
            // 
            // reportViewerButton
            // 
            this.reportViewerButton.Location = new System.Drawing.Point(94, 13);
            this.reportViewerButton.Name = "reportViewerButton";
            this.reportViewerButton.Size = new System.Drawing.Size(90, 23);
            this.reportViewerButton.TabIndex = 2;
            this.reportViewerButton.Text = "Report Viewer";
            this.reportViewerButton.UseVisualStyleBackColor = true;
            this.reportViewerButton.Click += new System.EventHandler(this.ReportViewerButton_Click);
            // 
            // ShopsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerButton);
            this.Controls.Add(this.excelReportButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShopsInfoForm";
            this.Text = "ShopsInfoForm";
            this.Load += new System.EventHandler(this.ShopsInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShopsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ShopDataSet shopDataSet;
        private ShopDataSet shopDataSet1;
        private System.Windows.Forms.BindingSource getShopsInfoBindingSource;
        private ShopDataSetTableAdapters.getShopsInfoTableAdapter getShopsInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button excelReportButton;
        private System.Windows.Forms.Button reportViewerButton;
    }
}