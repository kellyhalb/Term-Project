<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantSearch.aspx.cs" Inherits="Project2.RestaurantSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>



<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 319px; top: 12px; position: absolute; font-size: 40pt; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; height: 95px; width: 319px;" Text="Restaurants"></asp:Label>
        <asp:Button ID="btnReturnHomeFromRestaurants" runat="server" Text="Return to Account Home Page" OnClick="btnReturnHomeFromRestaurants_Click" />
        <asp:GridView ID="gvRestaurants" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 55px; top: 346px; position: absolute; height: 207px; width: 886px">
            <Columns>
                <asp:TemplateField HeaderText="What Would You Like to Do?">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlRestaurantAction" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Add a Review</asp:ListItem>
                            <asp:ListItem>Make a Reservation</asp:ListItem>
                            <asp:ListItem>View Reviews</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Restaurant Name" DataField="Name" />
                <asp:BoundField HeaderText="Cuisine Type" DataField="Cuisine" />
                <asp:BoundField HeaderText="Restaurant Address" DataField="Address" />
                <asp:BoundField HeaderText="Restaurant Price Rating" DataField="PriceRating" />
                <asp:BoundField HeaderText="Restauarnt Quality Rating" DataField="QualityRating" />
            </Columns>
        </asp:GridView>
        <asp:DropDownList ID="ddlCuisineSearch" runat="server" style="z-index: 1; left: 421px; top: 154px; position: absolute">
            <asp:ListItem>Italian</asp:ListItem>
            <asp:ListItem>Mexican</asp:ListItem>
            <asp:ListItem>Contemporary American</asp:ListItem>
            <asp:ListItem>Japanese</asp:ListItem>
            <asp:ListItem>Chinese</asp:ListItem>
            <asp:ListItem>Medditeranean</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 193px; top: 148px; position: absolute; margin-top: 5px;" Text="Select a Cuisine Type to Search by:"></asp:Label>
        <p>
            <asp:Button ID="btnSearchByQuality" runat="server" OnClick="btnSearchByQuality_Click" style="z-index: 1; left: 599px; top: 244px; position: absolute; width: 157px" Text="Search By Quality Rating" />
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 62px; top: 307px; position: absolute" Text="Select a Restaurant and a desired action then: "></asp:Label>
        <p>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 364px; top: 303px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
        <asp:Button ID="btnSearchCuisine" runat="server" OnClick="btnSearchCuisine_Click" style="z-index: 1; top: 154px; position: absolute; left: 595px" Text="Search by Cuisine" />
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 450px; top: 301px; position: absolute; color: #FF0000; right: 605px"></asp:Label>
        <asp:DropDownList ID="ddlPriceRating" runat="server" style="z-index: 1; left: 423px; top: 198px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 182px; top: 199px; position: absolute; width: 219px" Text="Select a Price Level to Search by:"></asp:Label>
        <asp:Button ID="btnSearchByPrice" runat="server" OnClick="btnSearchByPrice_Click" style="z-index: 1; left: 597px; top: 197px; position: absolute; width: 158px" Text="Search by Price Level" />
        <asp:DropDownList ID="ddlQualityRating" runat="server" style="z-index: 1; left: 423px; top: 241px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblPriceLevelTitle" runat="server" style="z-index: 1; left: 178px; top: 240px; position: absolute; width: 232px" Text="Select a Quality Level to Search by:"></asp:Label>
    </form>
</body>
</html>
