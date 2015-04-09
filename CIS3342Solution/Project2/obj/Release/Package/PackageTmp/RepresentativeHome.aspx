<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepresentativeHome.aspx.cs" Inherits="Project2.RepresentativeHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


     <style type="text/css">


        body {
            /*text-align: center;*/
            
            
            background-repeat:repeat;
            background-color:cornsilk;
            background-size:100% auto;
        }



        </style>
        </head>


<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 142px; top: 63px; position: absolute; font-size: xx-large; font-family: Arial, Helvetica, sans-serif" Text="Welcome to Your Account, Restaurant Reviewer"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 359px; top: 231px; position: absolute" Text="View Reservations for a Restauant" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 358px; top: 309px; position: absolute; width: 300px" Text="Add a New Restaurant" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 361px; top: 390px; position: absolute; width: 301px" Text="Search For Restaurants" />
    </form>
</body>
</html>
