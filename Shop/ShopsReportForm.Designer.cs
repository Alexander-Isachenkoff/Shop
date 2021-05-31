namespace Shop
{
    partial class ShopsReportForm
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
            this.getShopsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getShopsInfoTableAdapter = new Shop.ShopDataSetTableAdapters.getShopsInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShopsInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getShopsInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Shop.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ShopDataSet
            // 
            this.ShopDataSet.DataSetName = "ShopDataSet";
            this.ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getShopsInfoBindingSource
            // 
            this.getShopsInfoBindingSource.DataMember = "getShopsInfo";
            this.getShopsInfoBindingSource.DataSource = this.ShopDataSet;
            // 
            // getShopsInfoTableAdapter
            // 
            this.getShopsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ShopsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ShopsReportForm";
            this.Text = "ShopsReportForm";
            this.Load += new System.EventHandler(this.ShopsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShopsInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getShopsInfoBindingSource;
        private ShopDataSet ShopDataSet;
        private ShopDataSetTableAdapters.getShopsInfoTableAdapter getShopsInfoTableAdapter;
    }
}