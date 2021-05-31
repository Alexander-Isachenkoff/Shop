using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopsReportForm : Form
    {
        public ShopsReportForm()
        {
            InitializeComponent();
        }

        private void ShopsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataSet.getShopsInfo". При необходимости она может быть перемещена или удалена.
            this.getShopsInfoTableAdapter.Fill(this.ShopDataSet.getShopsInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
