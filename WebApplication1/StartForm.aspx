<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartForm.aspx.cs" CodeFile="StartForm.aspx.cs" Inherits="WebApplication1.StartForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="ShopsButton" runat="server" OnClick="ShopsButton_Click" Text="Магазины" Width="100px" />
        <asp:Button ID="ProductsButton" runat="server" Text="Товары" Width="100px" OnClick="ProductsButton_Click" />
        <asp:Button ID="SortsButton" runat="server" Text="Сорта" Width="100px" OnClick="SortsButton_Click" />
        <asp:Button ID="ProductsInShopsButton" runat="server" Text="Продукты в магазинах" Width="159px" OnClick="ProductsInShopsButton_Click" />
        <asp:Button ID="Query1_Button" runat="server" Text="Запрос 1" Width="100px" OnClick="Query1_Button_Click" />
        <asp:Button ID="Query2_Button" runat="server" Text="Запрос 2" Width="100px" OnClick="Query2_Button_Click" />
    </form>
</body>
</html>
