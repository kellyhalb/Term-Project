<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TermProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 207px; top: 36px; position: absolute; font-family: 'Lucida Handwriting'; font-size: x-large" Text="Welcome to Online Vacation Builder"></asp:Label>
        <asp:Label ID="lblExistingusername" runat="server" style="z-index: 1; left: 67px; top: 185px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblExistingPassword" runat="server" style="z-index: 1; left: 64px; top: 232px; position: absolute" Text="Password:"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 142px; top: 144px; position: absolute" Text="Existing User Log-in:"></asp:Label>
        <asp:Label ID="lblCreateNewAccount" runat="server" style="z-index: 1; left: 584px; top: 146px; position: absolute" Text="Create a New Account:"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 507px; top: 188px; position: absolute" Text="Name:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 508px; top: 235px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 499px; top: 296px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 520px; top: 357px; position: absolute" Text="City:"></asp:Label>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 513px; top: 418px; position: absolute" Text="State:"></asp:Label>
        <p>
            <asp:Label ID="lblZipCode" runat="server" style="z-index: 1; left: 638px; top: 420px; position: absolute; right: 358px" Text="Zip Code:"></asp:Label>
        </p>
        <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" style="z-index: 1; left: 78px; top: 337px; position: absolute" Text="Log-In to Existing Account" />
        <asp:Label ID="lblDesiredUsername" runat="server" style="z-index: 1; left: 437px; top: 481px; position: absolute" Text="Desired Username:"></asp:Label>
        <asp:Label ID="lblDesiredPassword" runat="server" style="z-index: 1; left: 441px; top: 537px; position: absolute" Text="Desired Password:"></asp:Label>
        <asp:Label ID="lblreenterpassword" runat="server" style="z-index: 1; left: 384px; top: 587px; position: absolute" Text="Re-Enter Desired Password:"></asp:Label>
        <asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" style="z-index: 1; left: 548px; top: 679px; position: absolute" Text="Create New Account" />
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 147px; top: 185px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 147px; top: 235px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNewName" runat="server" style="z-index: 1; left: 569px; top: 188px; position: absolute; width: 207px"></asp:TextBox>
        <asp:TextBox ID="txtNewEmail" runat="server" style="z-index: 1; left: 569px; top: 234px; position: absolute; width: 208px"></asp:TextBox>
        <asp:TextBox ID="txtNewAddress" runat="server" style="z-index: 1; left: 568px; top: 294px; position: absolute; width: 208px"></asp:TextBox>
        <asp:TextBox ID="txtNewCity" runat="server" style="z-index: 1; left: 569px; top: 358px; position: absolute; width: 207px"></asp:TextBox>
        <asp:TextBox ID="txtNewState" runat="server" style="z-index: 1; left: 571px; top: 419px; position: absolute; width: 36px"></asp:TextBox>
        <asp:TextBox ID="txtNewZipCode" runat="server" style="z-index: 1; left: 712px; top: 418px; position: absolute; width: 78px"></asp:TextBox>
        <asp:TextBox ID="txtNewUsername" runat="server" style="z-index: 1; left: 567px; top: 483px; position: absolute; width: 217px"></asp:TextBox>
        <asp:TextBox ID="txtDesiredPassword" runat="server" style="z-index: 1; left: 570px; top: 537px; position: absolute; width: 216px"></asp:TextBox>
        <asp:TextBox ID="txtDesiredPassword1" runat="server" style="z-index: 1; left: 573px; top: 585px; position: absolute; width: 210px"></asp:TextBox>
        <asp:RadioButtonList ID="rdoListLogin" runat="server" style="z-index: 1; left: 109px; top: 271px; position: absolute; height: 52px; width: 154px">
            <asp:ListItem>Remember Me</asp:ListItem>
            <asp:ListItem>Don&#39;t Remember Me</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButton ID="rdoRememberMe" runat="server" style="z-index: 1; left: 575px; top: 639px; position: absolute" Text="Remember Me" />
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 135px; top: 99px; position: absolute"></asp:Label>
    </form>
</body>
</html>
