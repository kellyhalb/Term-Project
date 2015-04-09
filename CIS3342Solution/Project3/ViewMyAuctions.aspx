<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyAuctions.aspx.cs" Inherits="Project3.ViewMyAuctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblViewMyAuctions" runat="server" style="z-index: 1; left: 389px; top: 54px; position: absolute; font-size: xx-large" Text="View My Auctions"></asp:Label>
        <asp:GridView ID="gvMyAuctions" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvMyAuctions_SelectedIndexChanged" style="z-index: 1; left: 232px; top: 279px; position: absolute; height: 336px; width: 563px">
            <Columns>
                <asp:TemplateField HeaderText="Select One">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="ProductDescription" HeaderText="Product Description" />
                <asp:BoundField DataField="ReservePrice" DataFormatString="{0:c}" HeaderText="Reserve Price" />
                <asp:ImageField DataImageUrlField="ProductImage" HeaderText="Image">
                </asp:ImageField>
                <asp:BoundField DataField="Bids" HeaderText="Bids" />
                <asp:BoundField DataField="CurrentBid" DataFormatString="{0:c}" HeaderText="Current Bid" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return Home" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 342px; top: 138px; position: absolute; font-style: italic" Text="You May Select a Product to either edit or delete"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 319px; top: 175px; position: absolute" Text="Delete Selected" />
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 175px; position: absolute; left: 570px; height: 26px" Text="Edit Selected" />
        </p>
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 274px; top: 234px; position: absolute"></asp:Label>
        <asp:Label ID="lblEditTitle" runat="server" style="z-index: 1; left: 236px; top: 688px; position: absolute" Text="Edit Your Auction Below:" Visible="False"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 331px; top: 730px; position: absolute; width: 459px" Visible="False"></asp:TextBox>
        <asp:Label ID="lblProductNameTitle" runat="server" style="z-index: 1; left: 205px; top: 731px; position: absolute" Text="Product Name:" Visible="False"></asp:Label>
        <p>
            <asp:Label ID="lblProductDescriptionTitle" runat="server" style="z-index: 1; left: 172px; top: 783px; position: absolute" Text="Product Description:" Visible="False"></asp:Label>
            <asp:Button ID="btnSubmitEdit" runat="server" OnClick="btnSubmitEdit_Click" style="z-index: 1; left: 440px; top: 1045px; position: absolute; margin-top: 0px" Text="Submit Edit" Visible="False" />
        </p>
        <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 1; left: 329px; top: 790px; position: absolute; height: 166px; width: 461px" Visible="False"></asp:TextBox>
        <asp:Label ID="lblReservePriceTitle" runat="server" style="z-index: 1; left: 209px; top: 987px; position: absolute" Text="Reserve Price:" Visible="False"></asp:Label>
        <asp:TextBox ID="txtReservePrice" runat="server" style="z-index: 1; left: 326px; top: 987px; position: absolute" Visible="False"></asp:TextBox>
    </form>
</body>
</html>
