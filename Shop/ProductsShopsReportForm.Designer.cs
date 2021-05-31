namespace Shop
{
    partial class ProductsShopsReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ShopDataSet = new Shop.ShopDataSet();
            this.secondQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondQueryTableAdapter = new Shop.ShopDataSetTableAdapters.secondQueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.secondQueryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shop.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // ShopDataSet
            // 
            this.ShopDataSet.DataSetName = "ShopDataSet";
            this.ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secondQueryBindingSource
            // 
            this.secondQueryBindingSource.DataMember = "secondQuery";
            this.secondQueryBindingSource.DataSource = this.ShopDataSet;
            // 
            // secondQueryTableAdapter
            // 
            this.secondQueryTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsShopsReportForm
            // 
            this.ClientSize = new System.Drawing.Size(708, 401);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductsShopsReportForm";
            this.Load += new System.EventHandler(this.ProductsShopsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondQueryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource secondQueryBindingSource;
        private ShopDataSet ShopDataSet;
        private ShopDataSetTableAdapters.secondQueryTableAdapter secondQueryTableAdapter;
    }
}