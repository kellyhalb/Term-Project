<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="Project3.ViewDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblViewDetails" runat="server" style="z-index: 1; left: 284px; top: 52px; position: absolute; font-size: x-large; font-family: Arial, Helvetica, sans-serif" Text="View Products Details"></asp:Label>
        <asp:Label ID="lblProductNameTitle" runat="server" style="z-index: 1; left: 84px; top: 139px; position: absolute" Text="Product Name:"></asp:Label>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 195px; top: 138px; position: absolute"></asp:Label>
        <asp:Label ID="lblProductDescriptionTitle" runat="server" style="z-index: 1; left: 55px; top: 181px; position: absolute; height: 20px" Text="Product Description:"></asp:Label>
        <asp:Label ID="lblProductDescription" runat="server" style="z-index: 1; left: 200px; top: 182px; position: absolute; height: 125px; width: 216px"></asp:Label>
        <p>
            <asp:Label ID="lblSoldBy" runat="server" style="z-index: 1; left: 495px; top: 138px; position: absolute" Text="Sold By:"></asp:Label>
        </p>
        <asp:Label ID="lblSellerUsername" runat="server" style="z-index: 1; left: 568px; top: 136px; position: absolute"></asp:Label>
        <asp:Label ID="lblAuctionEndDateTitle" runat="server" style="z-index: 1; left: 443px; top: 181px; position: absolute" Text="Auction End Date:"></asp:Label>
        <asp:Label ID="lblAuctionEndDate" runat="server" style="z-index: 1; left: 571px; top: 179px; position: absolute"></asp:Label>
        <asp:Label ID="lblCurrentBidTitle" runat="server" style="z-index: 1; left: 477px; top: 260px; position: absolute" Text="Current Bid:"></asp:Label>
        <asp:Label ID="lblReservePriceTitle" runat="server" style="z-index: 1; left: 464px; top: 221px; position: absolute" Text="Reserve Price:"></asp:Label>
        <asp:Label ID="lblReservePrice" runat="server" style="z-index: 1; left: 574px; top: 218px; position: absolute"></asp:Label>
        <asp:Label ID="lblCurrentBid" runat="server" style="z-index: 1; left: 570px; top: 258px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="lblBid" runat="server" OnClick="lblBid_Click" style="z-index: 1; left: 167px; top: 365px; position: absolute" Text="I'd Like to Bid on This" />
            <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" style="z-index: 1; left: 21px; top: 36px; position: absolute" Text="Return Home" />
        </p>
        <asp:Button ID="lblReturntoSearch" runat="server" style="z-index: 1; left: 395px; top: 364px; position: absolute" Text="No Thanks, Return to Search" OnClick="lblReturntoSearch_Click" />
        <asp:Label ID="lblAddYourBid" runat="server" style="z-index: 1; left: 178px; top: 479px; position: absolute; font-weight: 700; text-decoration: underline" Text="Add Your Bid:" Visible="False"></asp:Label>
        <asp:Label ID="lblBidPriceTitle" runat="server" style="z-index: 1; left: 173px; top: 531px; position: absolute; right: 482px" Text="What do you want to bid for this?" Visible="False"></asp:Label>
        <asp:TextBox ID="txtAddBidPrice" runat="server" style="z-index: 1; left: 395px; top: 530px; position: absolute" Visible="False"></asp:TextBox>
        <asp:Button ID="btnSubmitBid" runat="server" OnClick="btnSubmitBid_Click" style="z-index: 1; left: 334px; top: 610px; position: absolute" Text="Submit Bid" Visible="False" />
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 184px; top: 437px; position: absolute"></asp:Label>
    </form>
</body>
</html>
