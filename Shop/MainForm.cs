using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public partial class MainForm : Form
    {
        private ShopsInfoForm shopsInfoForm = new ShopsInfoForm();
        private ProductsShopsInfoForm productsShopsInfoForm = new ProductsShopsInfoForm();
        private TreeForm treeForm = new TreeForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            UpdateCurrentTab();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            try
            {
                shopInsertCommand.Parameters["@number"].Value = int.Parse(shopNumberTextBox.Text);
                shopInsertCommand.Parameters["@name"].Value = shopNameTextBox.Text;
                shopInsertCommand.Parameters["@address"].Value = shopAddressTextBox.Text;
                shopInsertCommand.Parameters["@square"].Value = float.Parse(shopSquareTextBox.Text.Replace(".", ","));
                shopInsertCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
            sqlConnection.Close();

            UpdateShopsTab();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(shopsDataGridView);
            int id = (int)row["number"];
            sqlConnection.Open();
            try
            {
                shopUpdateCommand.Parameters["@number"].Value = id;
                shopUpdateCommand.Parameters["@newNumber"].Value = int.Parse(shopNumberTextBox.Text);
                shopUpdateCommand.Parameters["@name"].Value = shopNameTextBox.Text;
                shopUpdateCommand.Parameters["@address"].Value = shopAddressTextBox.Text;
                shopUpdateCommand.Parameters["@square"].Value = float.Parse(shopSquareTextBox.Text.Replace(".", ","));
                shopUpdateCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
            sqlConnection.Close();

            UpdateShopsTab();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(shopsDataGridView);
            int number = (int)row["number"];
            sqlConnection.Open();
            shopDeleteCommand.Parameters["@number"].Value = number;
            shopDeleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateShopsTab();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            productAddCommand.Parameters["@name"].Value = productNameTextBox.Text;
            productAddCommand.Parameters["@sortId"].Value = sortCmb.SelectedValue;
            productAddCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateProductsTab();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(productsDataGridView);
            int id = (int)row["id"];
            sqlConnection.Open();
            productUpdateCommand.Parameters["@id"].Value = id;
            productUpdateCommand.Parameters["@Sort_id"].Value = sortCmb.SelectedValue;
            productUpdateCommand.Parameters["@name"].Value = productNameTextBox.Text;
            productUpdateCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateProductsTab();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(productsDataGridView);
            int id = (int)row["id"];
            sqlConnection.Open();
            productDeleteCommand.Parameters["@id"].Value = id;
            productDeleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateProductsTab();
        }

        private void AddSortButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sortInsertCommand.Parameters["@name"].Value = sortNameTextBox.Text;
            sortInsertCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateSortsTab();
        }

        private void DeleteSortButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["id"];
            sqlConnection.Open();
            sortDeleteCommand.Parameters["@id"].Value = CurrentTourId;
            sortDeleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateSortsTab();
        }

        private void UpdateSortButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int id = (int)row["id"];
            sqlConnection.Open();
            sortUpdateCommand.Parameters["@id"].Value = id;
            sortUpdateCommand.Parameters["@name"].Value = sortNameTextBox.Text;
            sortUpdateCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateSortsTab();
        }

        private DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0)
            {
                return null;
            }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillShopInfo();
        }

        private void FillShopInfo()
        {
            DataRow row = GetCurrentRow(shopsDataGridView);
            shopNumberTextBox.Text = row["number"].ToString();
            shopNameTextBox.Text = row["name"].ToString();
            shopAddressTextBox.Text = row["address"].ToString();
            shopSquareTextBox.Text = row["square"].ToString();
        }

        private void ProductsDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillProductInfo();
        }

        private void FillProductInfo()
        {
            DataRow row = GetCurrentRow(productsDataGridView);
            productNameTextBox.Text = row["name"].ToString();
            int sortId = Convert.ToInt32(row["id1"].ToString());
            sortCmb.SelectedValue = sortId;
        }

        private void FillSortInfo()
        {
            DataRow row = GetCurrentRow(dataGridView1);
            sortNameTextBox.Text = row["name"].ToString();
        }


        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            UpdateCurrentTab();
        }

        private void UpdateCurrentTab()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                UpdateShopsTab();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                UpdateProductsTab();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                UpdateSortsTab();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                UpdateShopProductsTab();
            }
        }

        private void UpdateShopsTab()
        {
            this.getAllShopsTableAdapter.Fill(this.shopDataSet.getAllShops);
        }

        private void UpdateShopProductsTab()
        {
            this.getAllProductsInShopTableAdapter.Fill(this.shopDataSet.getAllProductsInShop);
            this.getAllProductsTableAdapter.Fill(this.shopDataSet.getAllProducts);
            this.getAllShopsTableAdapter.Fill(this.shopDataSet.getAllShops);
        }

        private void UpdateSortsTab()
        {
            this.getAllSortsTableAdapter.Fill(this.shopDataSet.getAllSorts);
        }

        private void UpdateProductsTab()
        {
            this.getAllProductsTableAdapter.Fill(this.shopDataSet.getAllProducts);
            this.getAllSortsTableAdapter.Fill(this.shopDataSet.getAllSorts);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillSortInfo();
        }

        private void AddProductInShopButton_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            try
            {
                float cost = float.Parse(costTextBox.Text.Replace(".", ","));
                float quantity = float.Parse(quantityTextBox.Text.Replace(".", ","));
                if (cost <= 0 || quantity < 0)
                {
                    throw new Exception();
                }
                productInShopInsertCommand.Parameters["@productId"].Value = productCmb.SelectedValue; ;
                productInShopInsertCommand.Parameters["@shopNumber"].Value = shopCmb.SelectedValue;
                productInShopInsertCommand.Parameters["@cost"].Value = cost;
                productInShopInsertCommand.Parameters["@quantity"].Value = quantity;
                productInShopInsertCommand.Parameters["@unit"].Value = unitTextBox.Text;
                productInShopInsertCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
            sqlConnection.Close();

            UpdateShopProductsTab();
        }

        private void UpdateProductInShopButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(productsInShopGridView);
            int productId = (int)row["Products_id"];
            int shopNumder = (int)row["Shop_number"];
            sqlConnection.Open();
            try
            {
                float cost = float.Parse(costTextBox.Text.Replace(".", ","));
                float quantity = float.Parse(quantityTextBox.Text.Replace(".", ","));
                if (cost <= 0 || quantity < 0)
                {
                    throw new Exception();
                }
                productInShopUpdateCommand.Parameters["@productId"].Value = productId;
                productInShopUpdateCommand.Parameters["@shopNumber"].Value = shopNumder;
                productInShopUpdateCommand.Parameters["@newProductId"].Value = productCmb.SelectedValue;
                productInShopUpdateCommand.Parameters["@newShopNumber"].Value = shopCmb.SelectedValue;
                productInShopUpdateCommand.Parameters["@cost"].Value = cost;
                productInShopUpdateCommand.Parameters["@quantity"].Value = quantity;
                productInShopUpdateCommand.Parameters["@unit"].Value = unitTextBox.Text;
                productInShopUpdateCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
            sqlConnection.Close();

            UpdateShopProductsTab();
        }

        private void DeleteProductInShopButton_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(productsInShopGridView);
            int id = (int)row["id"];
            sqlConnection.Open();
            productInShopDeleteCommand.Parameters["@id"].Value = id;
            productInShopDeleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateShopProductsTab();
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != productsInShopGridView.RowCount - 1)
            {
                FillProductInShopInfo();
            } else
            {
                ClearProductinShopInfo();
            }
        }

        private void FillProductInShopInfo()
        {
            DataRow row = GetCurrentRow(productsInShopGridView);

            unitTextBox.Text = row["unit"].ToString();
            quantityTextBox.Text = row["quantity"].ToString();
            costTextBox.Text = row["cost"].ToString();

            int productId = Convert.ToInt32(row["Products_id"].ToString());
            productCmb.SelectedValue = productId;

            int shopNumber = Convert.ToInt32(row["Shop_number"].ToString());
            shopCmb.SelectedValue = shopNumber;
        }        

        private void ClearProductinShopInfo()
        {
            unitTextBox.Clear();
            quantityTextBox.Clear();
            costTextBox.Clear();
            productCmb.ResetText();
            shopCmb.ResetText();
        }

        private void QueryButton1_Click(object sender, EventArgs e)
        {
            if (shopsInfoForm.IsDisposed || !shopsInfoForm.Visible)
            {
                shopsInfoForm = new ShopsInfoForm();
                shopsInfoForm.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (productsShopsInfoForm.IsDisposed || !productsShopsInfoForm.Visible)
            {
                productsShopsInfoForm = new ProductsShopsInfoForm();
                productsShopsInfoForm.Show();
            }
        }

        private void TreeButton_Click(object sender, EventArgs e)
        {
            if (treeForm.IsDisposed || !treeForm.Visible)
            {
                treeForm = new TreeForm();
                treeForm.Show();
            }
        }
    }
}
