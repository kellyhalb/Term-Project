<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyBids.aspx.cs" Inherits="Project3.ViewMyBids" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 327px; top: 73px; position: absolute; font-size: xx-large; font-family: Arial, Helvetica, sans-serif" Text="Items You Have Bid On"></asp:Label>
        <asp:GridView ID="gvBids" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 289px; top: 203px; position: absolute; height: 195px; width: 420px">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:ImageField DataImageUrlField="ProductImage" HeaderText="Product Image">
                </asp:ImageField>
                <asp:BoundField DataField="BidPrice" HeaderText="Your Bid" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return Home" />
    </form>
</body>
</html>
