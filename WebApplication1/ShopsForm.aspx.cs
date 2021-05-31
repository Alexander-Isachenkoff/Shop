using System;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShopsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void ShopsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShopsForm.aspx");
        }

        protected void ProductsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductsForm.aspx");
        }

        protected void SortsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SortsForm.aspx");
        }

        protected void ProductsInShopsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductsInShopsForm.aspx");
        }

        protected void Query1_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Query1_Form.aspx");
        }

        protected void Query2_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Query2_Form.aspx");
        }

        private void TryPerformQuery(SqlDataSourceCommandEventArgs e)
        {
            e.Command.Connection.Open();
            try
            {
                e.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            e.Command.Connection.Close();
            e.Cancel = true;
        }

        protected void SqlDataSource2_Updating(object sender, SqlDataSourceCommandEventArgs e)
        {
            TryPerformQuery(e);
        }

        protected void SqlDataSource2_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {
            TryPerformQuery(e);
        }
    }
}