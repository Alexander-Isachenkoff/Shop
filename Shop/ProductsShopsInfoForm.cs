using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public partial class ProductsShopsInfoForm : Form
    {
        public ProductsShopsInfoForm()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("Number", typeof(int)));

            foreach (var number in checkedListBox1.CheckedItems)
                tvp.Rows.Add(number);

            sqlConnection1.Open();
            sqlSelectCommand1.Parameters["@List"].Value = tvp;
            shopDataSet.secondQuery.Clear();
            sqlDataAdapter1.Fill(shopDataSet.secondQuery);
            sqlConnection1.Close();
        }

        private void ProductsShopsInfoForm_Load(object sender, EventArgs e)
        {
            sqlDataAdapter2.Fill(shopDataSet.getAllShops);
            
            checkedListBox1.Items.Clear();
            foreach (DataRow item in shopDataSet.getAllShops.Rows)
            {
                checkedListBox1.Items.Add(item["number"], false);
            }
        }

        private void ExcelReportButton_Click(object sender, EventArgs e)
        {
            new ExcelReporter().ShowExcelReport(dataGridView1);
        }

        private void ReportViewer_Click(object sender, EventArgs e)
        {
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("Number", typeof(int)));

            foreach (var number in checkedListBox1.CheckedItems)
                tvp.Rows.Add(number);
            new ProductsShopsReportForm(tvp).Show();
        }
    }
}
