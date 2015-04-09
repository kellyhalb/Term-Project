<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuctionLogin.aspx.cs" Inherits="Project3.AuctionLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblLoginTitle" runat="server" style="z-index: 1; left: 323px; top: 89px; position: absolute; font-size: xx-large; right: 610px;" Text="Welcome to E-Sell"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 153px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 152px; top: 257px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 62px; top: 203px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 66px; top: 257px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtDesiredPassword2" runat="server" style="z-index: 1; left: 662px; top: 381px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblExistingTitle" runat="server" style="z-index: 1; left: 115px; top: 160px; position: absolute" Text="Existing User Log-In"></asp:Label>
        <asp:Label ID="lblNewAccount" runat="server" style="z-index: 1; left: 639px; top: 163px; position: absolute" Text="Create a New Account"></asp:Label>
        <asp:Label ID="lblNewUsername" runat="server" style="z-index: 1; left: 529px; top: 295px; position: absolute" Text="Desired Username:"></asp:Label>
        <asp:Label ID="lblNewName" runat="server" style="z-index: 1; left: 599px; top: 217px; position: absolute" Text="Name:"></asp:Label>
        <asp:Label ID="lblDesiredPassword" runat="server" style="z-index: 1; left: 529px; top: 339px; position: absolute" Text="Desired Password:"></asp:Label>
        <asp:Label ID="lblNewPassword2" runat="server" style="z-index: 1; left: 522px; top: 383px; position: absolute" Text="Re-Enter Password:"></asp:Label>
        <asp:Label ID="lblNewEmail" runat="server" style="z-index: 1; left: 547px; top: 256px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblDesiredAccount" runat="server" style="z-index: 1; left: 504px; top: 427px; position: absolute" Text="Desired Account Type:"></asp:Label>
        <asp:TextBox ID="txtNewName" runat="server" style="z-index: 1; left: 660px; top: 210px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNewEmail" runat="server" style="z-index: 1; left: 661px; top: 252px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDesiredUsername" runat="server" style="z-index: 1; left: 662px; top: 292px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDesiredPassword1" runat="server" style="z-index: 1; left: 661px; top: 341px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlAccountType" runat="server" style="z-index: 1; left: 666px; top: 424px; position: absolute; height: 18px; width: 127px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Buyer</asp:ListItem>
            <asp:ListItem>Seller</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnLogIn" runat="server" style="z-index: 1; left: 176px; top: 317px; position: absolute" Text="Log-In" OnClick="btnLogIn_Click" />
        <asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" style="z-index: 1; left: 654px; top: 491px; position: absolute" Text="Create New Account" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 526px; top: 554px; position: absolute"></asp:Label>
    </form>
</body>
</html>
