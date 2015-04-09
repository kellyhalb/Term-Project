<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewReservations.aspx.cs" Inherits="Project2.ViewReservations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnCancelReservation" runat="server" style="z-index: 1; left: 396px; top: 473px; position: absolute" Text="Cancel Reservation" OnClick="btnCancelReservation_Click" />
        <asp:Label ID="lblViewReservationsTitle" runat="server" style="z-index: 1; left: 319px; top: 80px; position: absolute; font-size: x-large; font-family: Arial, Helvetica, sans-serif" Text="View My Reservations"></asp:Label>
        <asp:GridView ID="gvReservations" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvReservations_SelectedIndexChanged" style="z-index: 1; left: 111px; top: 145px; position: absolute; height: 190px; width: 622px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelectCancel" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Restaurant Name" DataField="Name" />
                <asp:BoundField DataField="Address" HeaderText="Restaurant Address" />
                <asp:BoundField DataField="Date" HeaderText="Reservation Date" />
                <asp:BoundField DataField="Time" HeaderText="Reservation Time" />
                <asp:BoundField DataField="PartySize" HeaderText="Party Size" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 55px; top: 429px; position: absolute; font-style: italic" Text="Select a reservation and hit &quot;cancel reservation&quot; to cancel a reservation.  If you're still hungry you can also make a new reservation!"></asp:Label>
        <asp:Button ID="btnNewReservation" runat="server" style="z-index: 1; left: 352px; top: 523px; position: absolute" Text="Search for a New Restaurant" OnClick="btnNewReservation_Click" />
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" Text="Return to Account Home" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 380px; top: 594px; position: absolute"></asp:Label>
    </form>
</body>
</html>
