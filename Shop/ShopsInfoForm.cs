using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopsInfoForm : Form
    {
        public ShopsInfoForm()
        {
            InitializeComponent();
        }

        private void ShopsInfoForm_Load(object sender, EventArgs e)
        {
            this.getShopsInfoTableAdapter.Fill(this.shopDataSet1.getShopsInfo);
        }

        private void ExcelReportButton_Click(object sender, EventArgs e)
        {
            new ExcelReporter().ShowExcelReport(dataGridView1);
        }

        private void ReportViewerButton_Click(object sender, EventArgs e)
        {
            new ShopsReportForm().Show();
        }
    }
}
