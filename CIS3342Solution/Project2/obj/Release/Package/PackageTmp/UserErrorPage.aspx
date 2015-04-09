<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserErrorPage.aspx.cs" Inherits="Project2.UserErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 45px; width: 1492px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" style="z-index: 1; left: 192px; top: 351px; position: absolute" Text="Ok, I get it, take me back to my account home page" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 331px; top: 92px; position: absolute; font-size: xx-large" Text="Whoa there!"></asp:Label>
        <asp:Button ID="btnLoginPage" runat="server" OnClick="btnLoginPage_Click" style="z-index: 1; left: 51px; top: 297px; position: absolute" Text="I work for a restaurant and I'm going to need to make a new Representative Account" />
        <asp:Label ID="Label2" runat="server" style="position: absolute; z-index: 1; left: 125px; top: 172px; height: 106px; width: 586px" Text="According to our records, you are just a civilian user. The function that you have just selected is reserved for Restaurant Representatives that work for a specific restaurant. "></asp:Label>
    </form>
</body>
</html>
