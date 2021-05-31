<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Query2_Form.aspx.cs" CodeFile="Query2_Form.aspx.cs" Inherits="WebApplication1.Query2_Form" %>

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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="number" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="number" HeaderText="number" ReadOnly="True" SortExpression="number" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="square" HeaderText="square" SortExpression="square" />
                    <asp:BoundField DataField="Avg_Square" HeaderText="Avg_Square" ReadOnly="True" SortExpression="Avg_Square" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="getShopsInfo" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
