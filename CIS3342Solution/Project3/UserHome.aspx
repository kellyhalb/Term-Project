<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Project3.UserHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblWelcome" runat="server" style="z-index: 1; left: 301px; top: 62px; position: absolute; font-size: large" Text="Welcome to Your Account"></asp:Label>
        <asp:Button ID="btnAddProduct" runat="server" style="z-index: 1; left: 43px; top: 165px; position: absolute; right: 958px;" Text="Put an Item Up for Auction" OnClick="btnAddProduct_Click" />
        <asp:Button ID="btnViewMySales" runat="server" style="z-index: 1; left: 43px; top: 222px; position: absolute; width: 228px" Text="View My Sales/Auctions" OnClick="btnViewMySales_Click" />
        <asp:Button ID="btnBrowse" runat="server" style="z-index: 1; left: 436px; top: 164px; position: absolute; width: 216px" Text="Browse Items" OnClick="btnBrowse_Click" />
        <asp:Button ID="btnViewBids" runat="server" style="z-index: 1; left: 436px; top: 217px; position: absolute" Text="View Items I have Bid On" OnClick="btnViewBids_Click" />
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 42px; top: 115px; position: absolute"></asp:Label>
    </form>
</body>
</html>
