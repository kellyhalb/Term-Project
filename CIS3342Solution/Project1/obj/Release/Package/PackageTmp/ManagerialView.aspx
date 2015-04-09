<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerialView.aspx.cs" Inherits="Project1.ManagerialView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return to Pizza Ordering" />
        <asp:Label ID="lblManagersTitle" runat="server" style="font-size: xx-large; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; z-index: 1; left: 290px; top: 35px; position: absolute" Text="Managers Info"></asp:Label>
        <asp:GridView ID="gvManager" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 156px; top: 157px; position: absolute; height: 168px; width: 484px">
            <Columns>
                <asp:BoundField DataField="PizzaType" HeaderText="Pizza Type" />
                <asp:BoundField DataField="BasePrice" HeaderText="Base Price" />
                <asp:BoundField DataField="TotalQuantityOrdered" HeaderText="Total Quantity" />
                <asp:BoundField DataField="TotalSales" HeaderText="Total Sales" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
