<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Project3.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblAddItemTitle" runat="server" style="z-index: 1; left: 216px; top: 74px; position: absolute; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: xx-large" Text="Put Up an Item For Auction"></asp:Label>
        <asp:Button ID="btnAddItem" runat="server" style="z-index: 1; left: 381px; top: 543px; position: absolute; margin-top: 0px" Text="Add Item" OnClick="btnAddItem_Click" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 189px; top: 142px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 174px; top: 211px; position: absolute; width: 199px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 62px; top: 211px; position: absolute" Text="Product Name"></asp:Label>
        <asp:Label ID="lblProductDescription" runat="server" style="z-index: 1; left: 31px; top: 256px; position: absolute" Text="Product Desciprtion"></asp:Label>
        <asp:Label ID="lblStartBiddingAt" runat="server" style="z-index: 1; left: 445px; top: 213px; position: absolute; right: 458px" Text="Start the bidding at"></asp:Label>
        <asp:Label ID="lblReservePrice" runat="server" style="z-index: 1; left: 478px; top: 255px; position: absolute" Text="Reserve Price"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 44px; top: 403px; position: absolute" Text="Product Category"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 457px; top: 307px; position: absolute" Text="Auction End Date"></asp:Label>
        <asp:Label ID="lblProductSubCategory" runat="server" style="z-index: 1; left: 63px; top: 443px; position: absolute" Text="Sub Category"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 1; left: 171px; top: 256px; position: absolute; height: 115px; width: 208px"></asp:TextBox>
        <asp:DropDownList ID="ddlProductCategory" runat="server" AutoPostBack="True" style="z-index: 1; left: 174px; top: 401px; position: absolute; height: 30px; width: 204px; bottom: 174px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Jewelry</asp:ListItem>
            <asp:ListItem>Clothing</asp:ListItem>
            <asp:ListItem>Accessories</asp:ListItem>
            <asp:ListItem>Furniture</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtStartPrice" runat="server" style="z-index: 1; left: 583px; top: 206px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReservePrice" runat="server" style="z-index: 1; left: 584px; top: 255px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlProductSubCategory" runat="server" style="z-index: 1; left: 174px; top: 444px; position: absolute; height: 19px; width: 204px; right: 639px">
        </asp:DropDownList>
        <asp:Calendar ID="calTime" runat="server" OnSelectionChanged="calTime_SelectionChanged" style="z-index: 1; left: 502px; top: 341px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" style="z-index: 1; left: 37px; top: 27px; position: absolute; width: 83px" Text="Return Home" />
    </form>
</body>
</html>
