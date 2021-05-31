using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sortsAdapter.SelectCommand.ExecuteNonQuery();
            sortsAdapter.Fill(shopDataSet);
            productsAdapter.Fill(shopDataSet);
            productInShopAdapter.Fill(shopDataSet);

            foreach (DataRow sort in shopDataSet.getAllSorts.Rows)
            {
                int sortId = (int)sort["id"];
                TreeNode sortNode = new TreeNode(sort["name"].ToString());
                treeView.Nodes.Add(sortNode);
                foreach (DataRow product in shopDataSet.getAllProducts.Rows)
                {
                    if ((int)product["id1"] == sortId)
                    {
                        int productId = (int)product["id"];
                        TreeNode productNode = new TreeNode(product["name"].ToString());
                        sortNode.Nodes.Add(productNode);

                        foreach (DataRow productInShop in shopDataSet.getAllProductsInShop.Rows)
                        {
                            if ((int)productInShop["Products_id"] == productId)
                            {
                                productNode.Nodes.Add(new TreeNode(productInShop["Shop_name"].ToString()));
                            }
                        }
                    }
                }
            }
            sqlConnection.Close();
        }
    }
}
