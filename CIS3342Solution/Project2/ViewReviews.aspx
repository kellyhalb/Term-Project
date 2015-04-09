<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewReviews.aspx.cs" Inherits="Project2.ViewReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblViewReviewsTitle" runat="server" style="z-index: 1; left: 467px; top: 47px; position: absolute; font-size: xx-large" Text="View Reviews"></asp:Label>
        <asp:GridView ID="gvReviews" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 151px; top: 211px; position: absolute; height: 339px; width: 818px; margin-top: 0px">
            <Columns>
                <asp:BoundField DataField="Username" HeaderText="Review By" />
                <asp:BoundField DataField="Review" HeaderText="Review Comments" />
                <asp:BoundField DataField="PriceRating" HeaderText="Price Range" />
                <asp:BoundField DataField="QualityRating" HeaderText="Quality Rating" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return Home" />
        <asp:Button ID="btnMakeReservation" runat="server" OnClick="btnMakeReservation_Click" style="z-index: 1; left: 361px; top: 106px; position: absolute" Text="I like what I see, I want to book a reservation" />
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="z-index: 1; left: 361px; top: 149px; position: absolute; width: 383px" Text="Eh, Let me search for something else" />
    </form>
</body>
</html>
