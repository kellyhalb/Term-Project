<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRestaurant.aspx.cs" Inherits="Project2.AddRestaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlNewRestCuisine" runat="server" style="z-index: 1; left: 298px; top: 299px; position: absolute">
            <asp:ListItem>Italian</asp:ListItem>
            <asp:ListItem>Contemporary American</asp:ListItem>
            <asp:ListItem>Mexican</asp:ListItem>
            <asp:ListItem>Mediterranen</asp:ListItem>
            <asp:ListItem>Chinese</asp:ListItem>
            <asp:ListItem>Japanese</asp:ListItem>
            <asp:ListItem>Indian</asp:ListItem>
        </asp:DropDownList>
    
    </div>
        <asp:Label ID="lblRestName" runat="server" style="z-index: 1; left: 174px; top: 156px; position: absolute" Text="Restaurant Name:"></asp:Label>
        <asp:TextBox ID="txtnewRestName" runat="server" style="z-index: 1; left: 294px; top: 157px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRestAddress" runat="server" style="z-index: 1; left: 159px; top: 204px; position: absolute" Text="Restaurant Address:"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 116px; top: 253px; position: absolute" Text="Restaurant Phone Number:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 284px; top: 56px; position: absolute; font-size: 36pt; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif" Text="Add a New Restaurant"></asp:Label>
        <asp:TextBox ID="txtnewRestAddress" runat="server" style="z-index: 1; left: 296px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNewRestPhone" runat="server" style="z-index: 1; left: 298px; top: 249px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNewRestCuisine" runat="server" style="z-index: 1; left: 129px; top: 299px; position: absolute; bottom: 347px" Text="Restaurant Cuisine Type:"></asp:Label>
        <asp:Button ID="btnAddRestaurantReturnHome" runat="server" OnClick="btnAddRestaurantReturnHome_Click" style="z-index: 1; left: 292px; top: 455px; position: absolute; width: 427px" Text="Add Restaurant And Return Home" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 189px; top: 365px; position: absolute; color: #FF0000"></asp:Label>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Back to Account Home Page" />
    </form>
</body>
</html>
