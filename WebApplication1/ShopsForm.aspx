<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopsForm.aspx.cs" CodeFile="ShopsForm.aspx.cs" Inherits="WebApplication1.ShopsForm" %>

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
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="number" DataSourceID="SqlDataSource1" Width="888px" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="number" HeaderText="number" ReadOnly="True" SortExpression="number" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" >
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" >
                <ItemStyle Width="300px" />
                </asp:BoundField>
                <asp:BoundField DataField="square" HeaderText="square" SortExpression="square" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="getAllShops" DeleteCommand="deleteShop" DeleteCommandType="StoredProcedure" InsertCommand="addShop" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure" UpdateCommand="updateShop" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="number" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="numberTextBox" Name="number" PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="nameTextBox" Name="name" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="addressTextBox" Name="address" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="squareTextBox" Name="square" PropertyName="Text" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="number" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="newNumber" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="name" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="address" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="square" PropertyName="SelectedValue" Type="Double" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="number" DataSourceID="SqlDataSource2" Height="50px" Width="215px" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemDeleted="DetailsView1_ItemDeleted" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:TemplateField HeaderText="number" SortExpression="number">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("number") %>'></asp:Label>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:CompareValidator ID="CompareValidator11" runat="server" ErrorMessage="Номер магазина должен быть целым числом" ControlToValidate="TextBox1" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Вы должны указать номер магазина" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("number") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("number") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="name" SortExpression="name">
                    <EditItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Вы должны указать наименование магазина" ControlToValidate="nameTextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="nameTextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Вы должны указать наименование магазина" ControlToValidate="nameTextBox2"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="nameTextBox2" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="address" SortExpression="address">
                    <EditItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Вы должны указать адрес магазина" ControlToValidate="addressTextBox1"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="addressTextBox1" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Вы должны указать адрес магазина" ControlToValidate="addressTextBox2"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="addressTextBox2" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="square" SortExpression="square">
                    <EditItemTemplate>
                        <asp:CompareValidator ID="CompareValidator13" runat="server" ErrorMessage="Площадь должна быть числом" ControlToValidate="TextBox3" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Площадь должна быть больше 0" ControlToValidate="TextBox3" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Вы должны указать площадь магазина" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("square") %>' ControlToValidate="TextBox3"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:CompareValidator ID="CompareValidator12" runat="server" ErrorMessage="Площадь должна быть числом" ControlToValidate="TextBox4" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator><br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Площадь должна быть больше 0" ControlToValidate="TextBox4" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Вы должны указать площадь магазина" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("square") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("square") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowInsertButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ShopConnectionString %>" SelectCommand="getShopByNumber" SelectCommandType="StoredProcedure" DeleteCommand="deleteShop" DeleteCommandType="StoredProcedure" InsertCommand="addShop" InsertCommandType="StoredProcedure" UpdateCommand="updateShop" UpdateCommandType="StoredProcedure" OnInserting="SqlDataSource2_Inserting" OnUpdating="SqlDataSource2_Updating">
            <DeleteParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="number" PropertyName="SelectedValue" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="number" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="name" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="address" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="square" PropertyName="SelectedValue" Type="Double" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="number" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="number" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="newNumber" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DetailsView1" Name="name" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="address" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DetailsView1" Name="square" PropertyName="SelectedValue" Type="Double" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
