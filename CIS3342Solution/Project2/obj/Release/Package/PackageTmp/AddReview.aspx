<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddReview.aspx.cs" Inherits="Project2.AddReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblAddReviewTitle" runat="server" style="z-index: 1; left: 264px; top: 57px; position: absolute; font-size: 36pt; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif" Text="Add a Review"></asp:Label>
        <asp:Label ID="lblRestName" runat="server" style="z-index: 1; left: 127px; top: 166px; position: absolute" Text="Restaurant Name:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 145px; top: 227px; position: absolute" Text="Your Review:"></asp:Label>
        <asp:DropDownList ID="ddlQualityRating" runat="server" style="z-index: 1; left: 254px; top: 411px; position: absolute">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtReview" runat="server" style="z-index: 1; left: 251px; top: 222px; position: absolute; height: 129px; width: 345px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 80px; top: 411px; position: absolute" Text="Restaurant Quality Rating:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 88px; top: 454px; position: absolute" Text="Restaurant Price Rating:"></asp:Label>
        <asp:DropDownList ID="ddlPriceRating" runat="server" style="z-index: 1; left: 253px; top: 450px; position: absolute">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="1">1</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblRestaurantName" runat="server" style="z-index: 1; left: 250px; top: 166px; position: absolute"></asp:Label>
        <asp:Button ID="btnAddReview" runat="server" OnClick="btnAddReview_Click" style="z-index: 1; left: 367px; top: 534px; position: absolute" Text="Add Review" />
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Back to Account Home" />
        <p>
            <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 232px; top: 506px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
