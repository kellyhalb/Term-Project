<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyRestaurantsReservations.aspx.cs" Inherits="Project2.ViewMyRestaurantsReservations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 251px; top: 119px; position: absolute; font-size: xx-large;" Text="View Reservations for Your Restaurant"></asp:Label>
        <asp:GridView ID="gvReservations" runat="server" style="z-index: 1; left: 244px; top: 203px; position: absolute; height: 233px; width: 524px" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Username" HeaderText="Reservation Made By" />
                <asp:BoundField DataField="Date" HeaderText="Reservation Date" />
                <asp:BoundField DataField="Time" HeaderText="Reservation Time" />
                <asp:BoundField DataField="PartySize" HeaderText="Party Size" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return Home" />
    </form>
</body>
</html>
