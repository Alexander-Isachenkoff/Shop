<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsInShopsForm.aspx.cs" CodeFile="ProductsInShopsForm.aspx.cs" Inherits="WebApplication1.ProductsInShopsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Button ID="ShopsButton" runat="server" OnClick="ShopsButton_Click" Text="Магазины" Width="100px" />
            <asp:Button ID="ProductsButton" runat="server" Text="Товары" Width="100px" OnClick="ProductsButton_Click" />
            <asp:Button ID="SortsButton" runat="server" Text="Сорта" Width="100px" OnClick="SortsButton_Click" />
            <asp:Button ID="ProductsInShopsButton" runat="server" Text="Продукты в магазинах" Width="159px" OnClick="ProductsInShopsButton_Click" />
            <asp:Button ID="Query1_Button" runat="server" Text="Запрос 1" Width="100px" OnClick="Query1_Button_Click" />
            <asp:Button ID="Query2_Button" runat="server" Text="Запрос 2" Width="100px" OnClick="Query2_Button_Click" />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="Vertical" Width="845px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
                <asp:BoundField DataField="cost" HeaderText="Цена" SortExpression="cost" />
                <asp:BoundField DataField="quantity" HeaderText="Количество" SortExpression="quantity" />
                <asp:BoundField DataField="unit" HeaderText="Единица измерения" SortExpression="unit" />
                <asp:BoundField DataField="Products_id" HeaderText="Products_id" SortExpression="Products_id" >
                <ControlStyle Width="0px" />
                <FooterStyle Width="0px" />
                <HeaderStyle Width="0px" />
                <ItemStyle Width="0px" />
                </asp:BoundField>
                <asp:BoundField DataField="Shop_number" HeaderText="Номер магазина" SortExpression="Shop_number" />
                <asp:BoundField DataField="Shop_name" HeaderText="Название магазина" SortExpression="Shop_name" />
                <asp:BoundField DataField="Product_name" HeaderText="Товар" SortExpression="Product_name" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" DeleteCommand="deleteProductInShop" DeleteCommandType="StoredProcedure" InsertCommand="addProduct_in_Shop" InsertCommandType="StoredProcedure" SelectCommand="getAllProductsInShop" SelectCommandType="StoredProcedure" UpdateCommand="updateProductInShop" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="productId" Type="Int32" />
                <asp:Parameter Name="shopNumber" Type="Int32" />
                <asp:Parameter Name="cost" Type="Decimal" />
                <asp:Parameter Name="quantity" Type="Double" />
                <asp:Parameter Name="unit" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="productId" Type="Int32" />
                <asp:Parameter Name="shopNumber" Type="Int32" />
                <asp:Parameter Name="newProductId" Type="Int32" />
                <asp:Parameter Name="newShopNumber" Type="Int32" />
                <asp:Parameter Name="cost" Type="Decimal" />
                <asp:Parameter Name="quantity" Type="Double" />
                <asp:Parameter Name="unit" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="id" DataSourceID="ProductInShopDataSource" ForeColor="#333333" GridLines="Vertical" Height="50px" Width="315px" OnItemDeleted="DetailsView1_ItemDeleted" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
<%--                <asp:BoundField DataField="Products_id" HeaderText="Products_id" SortExpression="Products_id" />
                <asp:BoundField DataField="Shop_number" HeaderText="Shop_number" SortExpression="Shop_number" />
                <asp:BoundField DataField="Shop_name" HeaderText="Shop_name" SortExpression="Shop_name" />--%>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
                <asp:TemplateField HeaderText="Количество" SortExpression="quantity">
                    <EditItemTemplate>
                        <asp:CompareValidator ID="CompareValidator13" runat="server" ErrorMessage="Количество должно быть числом" ControlToValidate="TextBox2" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Количество должно быть больше 0" ControlToValidate="TextBox2" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Вы должны указать количество" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("quantity") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:CompareValidator ID="CompareValidator131" runat="server" ErrorMessage="Количество должно быть числом" ControlToValidate="TextBox2" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator11" runat="server" ErrorMessage="Количество должно быть больше 0" ControlToValidate="TextBox2" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Вы должны указать количество" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("quantity") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="unit" HeaderText="Единица измерения" SortExpression="unit" />
                <asp:TemplateField HeaderText="Цена" SortExpression="cost">
                    <EditItemTemplate>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Цена должна быть числом" ControlToValidate="TextBox1" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Цена должна быть больше 0" ControlToValidate="TextBox1" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Вы должны указать цену" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cost") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="Цена должна быть числом" ControlToValidate="TextBox1" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator5" runat="server" ErrorMessage="Цена должна быть больше 0" ControlToValidate="TextBox1" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Вы должны указать цену" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cost") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("cost") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Товар" SortExpression="Products_id">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ProductEditDropDownList" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:DropDownList ID="ProductInsertDropDownList" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id">
                        </asp:DropDownList>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Product_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Магазин" SortExpression="Shop_number">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ShopEditDropDownList" runat="server" DataSourceID="SqlDataSource3" DataTextField="Магазин" DataValueField="number">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:DropDownList ID="ShopInsertDropDownList" runat="server" DataSourceID="SqlDataSource3" DataTextField="Магазин" DataValueField="number">
                        </asp:DropDownList>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Shop_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="getAllProducts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="select number, concat(name, N' (номер: ', number, ')') as 'Магазин'
from Shop"></asp:SqlDataSource>
        <asp:SqlDataSource ID="ProductInShopDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" DeleteCommand="deleteProductInShop" DeleteCommandType="StoredProcedure" InsertCommand="addProduct_in_Shop" InsertCommandType="StoredProcedure" SelectCommand="getProductInShopById" SelectCommandType="StoredProcedure" UpdateCommand="updateProductInShop" UpdateCommandType="StoredProcedure" OnInserting="ProductInShopDataSource_Inserting" OnUpdating="ProductInShopDataSource_Updating">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="DetailsView1$ProductInsertDropDownList" Name="productId" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1$ShopInsertDropDownList" Name="shopNumber" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="cost" PropertyName="SelectedValue" Type="Decimal" />
                <asp:ControlParameter ControlID="DetailsView1" Name="quantity" PropertyName="SelectedValue" Type="Double" />
                <asp:ControlParameter ControlID="DetailsView1" Name="unit" PropertyName="SelectedValue" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="GridView1" Name="productId" PropertyName="SelectedRow.Cells[4].Text" Type="Int32" />
                <asp:ControlParameter ControlID="GridView1" Name="shopNumber" PropertyName="SelectedRow.Cells[5].Text" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1$ProductEditDropDownList" Name="newProductId" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1$ShopEditDropDownList" Name="newShopNumber" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="cost" PropertyName="SelectedValue" Type="Decimal" />
                <asp:ControlParameter ControlID="DetailsView1" Name="quantity" PropertyName="SelectedValue" Type="Double" />
                <asp:ControlParameter ControlID="DetailsView1" Name="unit" PropertyName="SelectedValue" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>

    </form>
</body>
</html>
