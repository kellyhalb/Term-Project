<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeReservation.aspx.cs" Inherits="Project2.MakeReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblMakeReservationTitle" runat="server" style="z-index: 1; left: 384px; top: 52px; position: absolute; font-size: x-large" Text="Make a Reservation"></asp:Label>
        <asp:Button ID="btnReturnHome" runat="server" OnClick="btnReturnHome_Click" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Return Home" />
        <p>
            <asp:Label ID="lblRestaurantTitle" runat="server" style="z-index: 1; left: 245px; top: 179px; position: absolute" Text="Restaurant:"></asp:Label>
        </p>
        <asp:Label ID="lblRestaurantName" runat="server" style="z-index: 1; left: 332px; top: 179px; position: absolute"></asp:Label>
        <asp:Label ID="lblResTimeChoice" runat="server" style="z-index: 1; left: 153px; top: 295px; position: absolute" Text="Desired Reservation Time:"></asp:Label>
        <asp:Label ID="lblDesiredResDate" runat="server" style="z-index: 1; left: 153px; top: 249px; position: absolute; margin-top: 0px" Text="Desired Reservation Date:"></asp:Label>
        <asp:Button ID="btnBookReservation" runat="server" OnClick="btnBookReservation_Click" style="z-index: 1; left: 388px; top: 410px; position: absolute; height: 26px" Text="Book Reservation" />
        <asp:DropDownList ID="ddlResTime" runat="server" style="z-index: 1; left: 335px; top: 294px; position: absolute">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>5:00PM</asp:ListItem>
            <asp:ListItem>5:30PM</asp:ListItem>
            <asp:ListItem>6:00PM</asp:ListItem>
            <asp:ListItem>6:30PM</asp:ListItem>
            <asp:ListItem>7:00PM</asp:ListItem>
            <asp:ListItem>7:30PM</asp:ListItem>
            <asp:ListItem>8:00PM</asp:ListItem>
            <asp:ListItem>8:30PM</asp:ListItem>
            <asp:ListItem>9:00PM</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSearchNew" runat="server" OnClick="btnSearchNew_Click" style="z-index: 1; left: 300px; top: 458px; position: absolute; margin-top: 0px" Text="Search for a new Restaurant Instead" />
        <asp:Label ID="lblAddressTitle" runat="server" style="z-index: 1; left: 256px; top: 216px; position: absolute" Text="Location:"></asp:Label>
        <p>
            <asp:Label ID="lblRestaurantAddress" runat="server" style="z-index: 1; left: 331px; top: 214px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 209px; top: 382px; position: absolute; color: #FF0000"></asp:Label>
        <asp:Label ID="lblPartySize" runat="server" style="z-index: 1; left: 239px; top: 336px; position: absolute" Text="Party Size:"></asp:Label>
        <asp:DropDownList ID="ddlPartySize" runat="server" style="z-index: 1; left: 334px; top: 337px; position: absolute">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlMonth" runat="server" style="z-index: 1; left: 333px; top: 249px; position: absolute">
            <asp:ListItem>Month</asp:ListItem>
            <asp:ListItem>January</asp:ListItem>
            <asp:ListItem>February</asp:ListItem>
            <asp:ListItem>March</asp:ListItem>
            <asp:ListItem>April</asp:ListItem>
            <asp:ListItem>May</asp:ListItem>
            <asp:ListItem>June</asp:ListItem>
            <asp:ListItem>July</asp:ListItem>
            <asp:ListItem>August</asp:ListItem>
            <asp:ListItem>September</asp:ListItem>
            <asp:ListItem>October</asp:ListItem>
            <asp:ListItem>November</asp:ListItem>
            <asp:ListItem>December</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlDay" runat="server" style="z-index: 1; left: 439px; top: 248px; position: absolute; right: 612px">
            <asp:ListItem>Day</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>26</asp:ListItem>
            <asp:ListItem>27</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>29</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>31</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlYear" runat="server" style="z-index: 1; top: 248px; position: absolute; left: 509px">
            <asp:ListItem>Year</asp:ListItem>
            <asp:ListItem>2015</asp:ListItem>
            <asp:ListItem>2016</asp:ListItem>
            <asp:ListItem>2017</asp:ListItem>
            <asp:ListItem>2018</asp:ListItem>
            <asp:ListItem>2019</asp:ListItem>
            <asp:ListItem>2020</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
