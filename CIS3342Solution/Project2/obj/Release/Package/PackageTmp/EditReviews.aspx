<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditReviews.aspx.cs" Inherits="Project2.EditReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblAddEditDeleteTitle" runat="server" style="z-index: 1; left: 261px; top: 68px; position: absolute; font-size: xx-large; font-family: 'Arial Black'" Text="Edit/Delete Your Reviews"></asp:Label>
        <asp:DropDownList ID="ddlPriceRating" runat="server" style="z-index: 1; left: 205px; top: 885px; position: absolute" Visible="False">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="gvReviews" runat="server" AutoGenerateColumns="False" style="height: 259px; width: 732px; z-index: 1; left: 105px; top: 375px; position: absolute; margin-top: 0px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Restaurant Name" DataField="Name" />
                <asp:BoundField DataField="Address" HeaderText="Restaurant Address" />
                <asp:BoundField HeaderText="Your Price Rating" DataField="PriceRating" />
                <asp:BoundField HeaderText="Your Quality Rating" DataField="QualityRating" />
                <asp:BoundField DataField="Review" HeaderText="Your Review" />
            </Columns>
        </asp:GridView>
        <p>
            <asp:Label ID="TitleAddress" runat="server" style="z-index: 1; left: 117px; top: 833px; position: absolute" Text="Address:" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnReturnHome" runat="server" style="z-index: 1; left: 21px; top: 31px; position: absolute" Text="Return To Account Home Page" OnClick="btnReturnHome_Click" />
        </p>
        <p>
            <asp:Label ID="lblYourReviews" runat="server" style="z-index: 1; left: 211px; top: 343px; position: absolute" Text="Your Reviews:"></asp:Label>
            <asp:Label ID="lblRestaurantName" runat="server" style="z-index: 1; left: 204px; top: 792px; position: absolute"></asp:Label>
            <asp:Label ID="lblRestaurantAddress" runat="server" style="z-index: 1; left: 202px; top: 833px; position: absolute"></asp:Label>
            <asp:Label ID="TitleNewPriceRating" runat="server" style="z-index: 1; left: 70px; top: 881px; position: absolute" Text="New Price Rating:" Visible="False"></asp:Label>
            <asp:Label ID="TitleNewQualityRating" runat="server" style="z-index: 1; left: 53px; top: 924px; position: absolute" Text="New Quality Rating:" Visible="False"></asp:Label>
            <asp:Label ID="TitleReviewComments" runat="server" style="z-index: 1; left: 551px; top: 766px; position: absolute" Text="Review Comments" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 232px; top: 273px; position: absolute"></asp:Label>
            <asp:Label ID="TitleEditReview" runat="server" style="z-index: 1; left: 328px; top: 716px; position: absolute" Text="Edit This Review (Must Change at least one aspect):" Visible="False"></asp:Label>
            <asp:Label ID="TitleRestaurantName" runat="server" style="z-index: 1; left: 113px; top: 792px; position: absolute; right: 1026px" Text="Restaurant:" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="lblEditReview" runat="server" style="z-index: 1; left: 229px; top: 225px; position: absolute; width: 206px; margin-top: 0px" Text="Edit Selected Review" OnClick="lblEditReview_Click" />
        <p>
            <asp:Button ID="btnDeleteReview" runat="server" style="z-index: 1; left: 476px; top: 225px; position: absolute; margin-bottom: 5px" Text="Delete Selected Review" OnClick="btnDeleteReview_Click" />
        </p>
        <p>
            <asp:Button ID="btnConfirmEdit" runat="server" style="z-index: 1; left: 429px; top: 996px; position: absolute" Text="Confirm Edit" OnClick="btnConfirmEdit_Click" Visible="False" />
        </p>
        <asp:TextBox ID="txtNewComments" runat="server" style="z-index: 1; left: 556px; top: 794px; position: absolute; height: 172px; width: 375px" Visible="False"></asp:TextBox>
        <asp:DropDownList ID="ddlQualityRating" runat="server" style="z-index: 1; left: 205px; top: 918px; position: absolute" Visible="False">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
