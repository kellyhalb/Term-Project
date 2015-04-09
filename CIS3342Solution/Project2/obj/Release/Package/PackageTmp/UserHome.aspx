<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Project2.UserHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <style type="text/css">


        body {
            /*text-align: center;*/
            
            
            background-repeat:repeat;
            background-color:lightskyblue;
            background-size:100% auto;
        }



        </style>
        </head>
    <body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblAccountHomePageTitle" runat="server" style="z-index: 1; left: 346px; top: 22px; position: absolute; font-size: 38pt; font-family: Calibri; height: 60px; width: 599px; font-weight: 400; margin-top: 9px;" Text="Welcome to Your Account"></asp:Label>
        <asp:Label ID="lblQuestion" runat="server" CssClass="auto-style1" style="z-index: 1; left: 57px; top: 136px; position: absolute; font-size: xx-large; font-style: italic; font-family: 'Buxton Sketch'; height: 54px; width: 514px;" Text="Hey! I'm a Hungry Customer and I Want to.."></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 660px; top: 139px; position: absolute; font-size: x-large; font-style: italic; font-family: 'Buxton Sketch'; bottom: 497px;" Text="Hey! I'm also a Restaurant Representative and I would like to.."></asp:Label>
        <p>
        <asp:Button ID="btnViewEditDelete" runat="server" style="z-index: 1; left: 186px; top: 404px; position: absolute; width: 219px;" Text="Edit/Delete A Review" OnClick="btnViewEditDelete_Click" />
        </p>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 185px; top: 194px; position: absolute; width: 219px; margin-top: 5px;" Text="Search For Restaurants" OnClick="btnSearch_Click" />
        <asp:Label ID="lblSearchDirections" runat="server" style="z-index: 1; left: 26px; top: 231px; position: absolute; font-style: italic" Text="Here's where you can search for a restaurant and make reservations and add reviews"></asp:Label>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 34px; top: 43px; position: absolute; width: 134px" Text="Log Out" />
        <p>
        <asp:Button ID="btnViewMyReservations" runat="server" style="z-index: 1; left: 187px; top: 502px; position: absolute; width: 218px; margin-top: 0px;" Text="View My Reservations" OnClick="btnViewMyReservations_Click" />
        </p>
        <p>
        <asp:Button ID="btnAddRestaurant" runat="server" OnClick="btnAddRestaurant_Click" style="z-index: 1; left: 193px; top: 299px; position: absolute; width: 212px" Text="Add a New Restaurant" />
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 35px; top: 337px; position: absolute; font-style: italic" Text="Didn't See the Restaurant you Wanted in Search? It may not have been added yet."></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 54px; top: 442px; position: absolute; font-style: italic" Text="Changed your mind about something you said. That's cool. Change it here."></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAssignRestaurant" runat="server" style="z-index: 1; left: 792px; top: 209px; position: absolute" Text="Declare Which Restaurant I work for" OnClick="btnAssignRestaurant_Click" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 179px; top: 548px; position: absolute; font-style: italic" Text="Check out where you're eating next"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnViewReservationsRestaurant" runat="server" style="z-index: 1; left: 792px; top: 289px; position: absolute" Text="View Reservations for My Restaurant" OnClick="btnViewReservationsRestaurant_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 806px; top: 345px; position: absolute"></asp:Label>
            <asp:Label ID="lblCantClick" runat="server" style="z-index: 1; left: 662px; top: 477px; position: absolute; color: #FF0000"></asp:Label>
        </p>
    </form>
</body>
</html>
