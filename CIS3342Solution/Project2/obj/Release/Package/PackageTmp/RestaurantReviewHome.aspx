<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantReviewHome.aspx.cs" Inherits="Project2.RestaurantReviewHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

        <style type="text/css">

        body {
            /*text-align: center;*/
            
            background-image: url("foodbackground.jpg");
            background-repeat:repeat;
            background-color:white;
            background-size:100% auto;
        }



        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblHomePageTitle" runat="server" style="z-index: 1; left: 17px; top: 47px; position: absolute; font-size: 40pt; font-family: 'Lucida Handwriting';" Text="Welcome to Restaurant Explorer"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 163px; top: 337px; position: absolute; margin-top: 0px" Text="Log-In to Existing Account" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCreateNewAccount" runat="server" style="z-index: 1; left: 603px; top: 535px; position: absolute" Text="Create New Account" OnClick="btnCreateNewAccount_Click" />
        <p>
            <asp:TextBox ID="txtDesiredUsername" runat="server" style="z-index: 1; left: 714px; top: 322px; position: absolute; width: 167px;"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 712px; top: 193px; position: absolute; width: 171px;"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 713px; top: 233px; position: absolute; width: 170px;"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 235px; top: 263px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 236px; top: 211px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblExistingPassword" runat="server" style="z-index: 1; left: 132px; top: 263px; position: absolute; width: 60px; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Password:"></asp:Label>
        <asp:Label ID="lblExistingName" runat="server" style="z-index: 1; left: 130px; top: 212px; position: absolute; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Username:"></asp:Label>
        <asp:Label ID="lblNewUsername" runat="server" style="z-index: 1; left: 532px; top: 325px; position: absolute; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Desired Username:"></asp:Label>
        <asp:Label ID="lblNewPasswordConfirm" runat="server" style="font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif; z-index: 1; left: 483px; top: 411px; position: absolute" Text="Re-Enter Your Password:"></asp:Label>
        <asp:Label ID="lblNewPassword" runat="server" style="font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif; z-index: 1; left: 540px; top: 368px; position: absolute; height: 26px; right: 427px;" Text="Enter a Password:"></asp:Label>
        <p>
            <asp:TextBox ID="txtDesiredPassword" runat="server" style="z-index: 1; left: 715px; top: 365px; position: absolute; width: 168px" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 713px; top: 277px; position: absolute; width: 175px"></asp:TextBox>
        </p>
        <asp:Label ID="lblNewName" runat="server" style="z-index: 1; left: 640px; top: 190px; position: absolute; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Name:"></asp:Label>
        <asp:Label ID="lblNewPhone" runat="server" style="z-index: 1; left: 562px; top: 227px; position: absolute; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Phone Number:"></asp:Label>
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" style="z-index: 1; left: 258px; top: 146px; position: absolute; font-size: large; font-family: Arial, Helvetica, sans-serif;"></asp:Label>
        <asp:TextBox ID="txtDesiredPasswordConfirm" runat="server" style="z-index: 1; left: 717px; top: 410px; position: absolute; width: 169px; margin-top: 0px;" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblNewEmail" runat="server" style="font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif; z-index: 1; left: 565px; top: 278px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblReporNot" runat="server" style="z-index: 1; left: 502px; top: 446px; position: absolute; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="Desired Account Type:"></asp:Label>
        <asp:DropDownList ID="ddlRep" runat="server" style="z-index: 1; left: 719px; top: 449px; position: absolute">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem Value="User">Customer</asp:ListItem>
            <asp:ListItem Value="Representative">Restaurant Representative</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
