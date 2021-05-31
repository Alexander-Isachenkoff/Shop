<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query1_Form.aspx.cs" CodeFile="Query1_Form.aspx.cs" Inherits="WebApplication1.Query1_Form" %>

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
        <div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="getAllShops" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            Номер магазина:
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="number" DataValueField="number">
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
                <asp:BoundField DataField="Products_id" HeaderText="Products_id" SortExpression="Products_id" Visible="False" />
                <asp:BoundField DataField="Shop_number" HeaderText="Номер магазина" SortExpression="Shop_number" />
                <asp:BoundField DataField="cost" HeaderText="Цена" SortExpression="cost" />
                <asp:BoundField DataField="quantity" HeaderText="Количество" SortExpression="quantity" />
                <asp:BoundField DataField="unit" HeaderText="Единица измерения" SortExpression="unit" />
                <asp:BoundField DataField="id1" HeaderText="id1" InsertVisible="False" ReadOnly="True" SortExpression="id1" Visible="False" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" Visible="False" />
                <asp:BoundField DataField="Sort_id" HeaderText="Sort_id" SortExpression="Sort_id" Visible="False" />
                <asp:BoundField DataField="number" SortExpression="number" />
                <asp:BoundField DataField="name1" HeaderText="Название магазина" SortExpression="name1" />
                <asp:BoundField DataField="address" HeaderText="Адрес" SortExpression="address" />
                <asp:BoundField DataField="square" HeaderText="Площадь" SortExpression="square" />
                <asp:BoundField DataField="name2" HeaderText="name2" SortExpression="name2" Visible="False" />
                <asp:BoundField DataField="name3" HeaderText="Товар" SortExpression="name3" />
                <asp:BoundField DataField="Column1" HeaderText="Стоимость" ReadOnly="True" SortExpression="Column1" />
                <asp:BoundField DataField="Column2" HeaderText="Стоимость всех товаров" ReadOnly="True" SortExpression="Column2" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="secondQuery_Single" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="number" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="ExecuteButton" runat="server" OnClick="ExecuteButton_Click" Text="Выполнить" />
    </form>
</body>
</html>
