<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FruitStore.aspx.cs" Inherits="MyStore.FruitStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="50px" Width="180px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                <asp:ListItem Text="Banana" Value="Banana"></asp:ListItem>
                <asp:ListItem Text="Grapes" Value="Grapes"></asp:ListItem>
                <asp:ListItem Text="Pomegranate" Value="Pomegranate"></asp:ListItem>
                <asp:ListItem Text="Dragon Fruit" Value="Dragon Fruit"></asp:ListItem>
                <asp:ListItem Text="Guava" Value="Guava"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Visible="False">
                <AlternatingRowStyle BackColor="White" />
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
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Image ID="FruitImage" runat="server" Height="500px" Width="500px" />
            <br />
            <br />
            <h2>Rs <asp:Label ID="FruitPrice" runat="server"></asp:Label> /Kg</h2>
        </div>
    </form>
</body>
</html>
