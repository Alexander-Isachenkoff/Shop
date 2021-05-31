<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SortsForm.aspx.cs" CodeFile="SortsForm.aspx.cs" Inherits="WebApplication1.SortsForm" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="dataGridSelectSource" ForeColor="#333333" GridLines="Vertical" Width="845px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="Наименование сорта" SortExpression="name" />
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
        <asp:SqlDataSource ID="dataGridSelectSource" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" DeleteCommand="deleteSort" DeleteCommandType="StoredProcedure" InsertCommand="addSort" InsertCommandType="StoredProcedure" SelectCommand="getAllSorts" SelectCommandType="StoredProcedure" UpdateCommand="updateSort" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="name" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="sortsDataSource" ForeColor="#333333" GridLines="None" Height="50px" OnItemDeleted="DetailsView1_ItemDeleted" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated" Width="297px" DataKeyNames="id">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:TemplateField HeaderText="Название" SortExpression="name">
                    <EditItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Вы должны указать наименование сорта" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Вы должны указать наименование сорта" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
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
        <asp:SqlDataSource ID="sortsDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" DeleteCommand="deleteSort" DeleteCommandType="StoredProcedure" InsertCommand="addSort" InsertCommandType="StoredProcedure" SelectCommand="getSortById" SelectCommandType="StoredProcedure" UpdateCommand="updateSort" UpdateCommandType="StoredProcedure" OnInserting="sortsDataSource_Inserting" OnUpdating="sortsDataSource_Updating">
            <DeleteParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="name" PropertyName="SelectedValue" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="name" PropertyName="SelectedValue" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
         
        
    </form>
</body>
</html>
