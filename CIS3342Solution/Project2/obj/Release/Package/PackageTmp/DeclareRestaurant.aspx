<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeclareRestaurant.aspx.cs" Inherits="Project2.DeclareRestaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 325px; top: 83px; position: absolute; font-size: x-large" Text="Declare Which Restaurant You Work For"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 145px; top: 124px; position: absolute; font-style: italic" Text="Once you delcare which restaurant you work for, you'll be able to view all the upcoming reservations for your restaurant."></asp:Label>
        <asp:GridView ID="gvRestaurants" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 203px; top: 357px; position: absolute; height: 273px; width: 677px">
            <Columns>
                <asp:TemplateField HeaderText="This is Where I Work">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 426px; top: 162px; position: absolute" Text="Declare Restaurant" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnReturnHome" runat="server" Text="Return Home" OnClick="btnReturnHome_Click" />
        <asp:Button ID="btnAddRestaurant" runat="server" style="z-index: 1; left: 277px; top: 213px; position: absolute" Text="I don't see where I work, I need to add my restaurant first" OnClick="btnAddRestaurant_Click" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 265px; top: 306px; position: absolute"></asp:Label>
    </form>
</body>
</html>
