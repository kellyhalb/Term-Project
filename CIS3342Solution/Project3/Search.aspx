<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Project3.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 150px; top: 298px; position: absolute; height: 308px; width: 628px" OnSelectedIndexChanged="gvProducts_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Select an Item to view Details">
                    <ItemTemplate>
                        <asp:Button ID="btnViewDetails" runat="server" OnClick="btnViewDetails_Click1" Text="View Details" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ImageField HeaderText="Image" DataImageUrlField="ProductImage">
                </asp:ImageField>
                <asp:BoundField HeaderText="Product Name" DataField="ProductName" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                <asp:BoundField DataField="AuctionEndDate" HeaderText="Auction Ends" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblBrowseItems" runat="server" style="z-index: 1; left: 310px; top: 87px; position: absolute; font-size: x-large" Text="Browse All Active Auctions"></asp:Label>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return Home" />
        <asp:DropDownList ID="ddlProductCategory" runat="server" style="z-index: 1; left: 281px; top: 165px; position: absolute; right: 823px; height: 21px">
            <asp:ListItem>Jewelry</asp:ListItem>
            <asp:ListItem>Clothing</asp:ListItem>
            <asp:ListItem>Boats</asp:ListItem>
            <asp:ListItem>Electronics</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSearchbyCategory" runat="server" OnClick="btnSearchbyCategory_Click" style="z-index: 1; left: 440px; top: 164px; position: absolute" Text="Search by Category" />
    </form>
</body>
</html>
