using System;

namespace WebApplication1
{
    public partial class StartForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}