<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationConfirmation.aspx.cs" Inherits="Project2.ReservationConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblResConfirmation" runat="server" style="font-style: italic; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: xx-large; z-index: 1; left: 16px; top: 93px; position: absolute" Text="You won't be hungry for long! You have successfully booked a reservation. "></asp:Label>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="z-index: 1; left: 193px; top: 351px; position: absolute" Text="I May Want to Book Another, Take me to the Search Page Again" />
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" style="z-index: 1; left: 314px; top: 301px; position: absolute" Text="Great, Take me back to my home page" />
    </form>
</body>
</html>
