<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaOrder.aspx.cs" Inherits="Project1.PizzaOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">

        body {
            /*text-align: center;*/
            
            background-image: url("pizzapepperoni.png");
            background-repeat:repeat;
            background-color:white;
            background-size:100% auto;
        }



        </style>

</head>
<body>
    <form id="form1" runat="server">


    <div>
    
    </div>
        <asp:GridView ID="gvOrder" runat="server" style="z-index: 1; left: 221px; top: 324px; position: absolute; height: 186px; width: 581px; right: 710px; font-family: Arial, Helvetica, sans-serif;" AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelectPizza" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Pizza Type" DataField="PizzaType" />
                <asp:TemplateField HeaderText="Size">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlSize" runat="server">
                            <asp:ListItem>Small</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Large</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Height="28px"></asp:TextBox>
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:SqlDataSource ID="Pizza" runat="server"></asp:SqlDataSource>
        <asp:Label ID="lblAddressSum" runat="server" style="z-index: 1; left: 168px; top: 753px; position: absolute; width: 100px; text-align: right;" Text="Address:" Visible="False"></asp:Label>
        <asp:Label ID="lblPhoneSum" runat="server" style="z-index: 1; left: 144px; top: 718px; position: absolute; width: 129px; text-align: right;" Text="Phone Number:" Visible="False"></asp:Label>
        <asp:Label ID="lblNameEntered" runat="server" style="z-index: 1; left: 292px; top: 687px; position: absolute; width: 339px;"></asp:Label>
        <asp:Label ID="lblSummary" runat="server" style="z-index: 1; left: 299px; top: 617px; position: absolute; font-size: xx-large; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif" Text="Your Order Summary:" Visible="False"></asp:Label>
        <asp:TextBox ID="txtboxName" runat="server" style="z-index: 1; left: 285px; top: 114px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" style="z-index: 1; left: 443px; top: 284px; position: absolute"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 233px; top: 114px; position: absolute; bottom: 532px; font-family: Arial, Helvetica, sans-serif;" Text="Name:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 218px; top: 191px; position: absolute; font-family: Arial, Helvetica, sans-serif; bottom: 456px;" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtboxAddress" runat="server" style="z-index: 1; left: 284px; top: 191px; position: absolute; width: 277px"></asp:TextBox>
        <asp:TextBox ID="txtboxPhone" runat="server" style="z-index: 1; left: 285px; top: 152px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 220px; top: 152px; position: absolute; right: 1233px; text-align: right; font-family: Arial, Helvetica, sans-serif;" Text="Phone:"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" style="font-size: 48pt; font-family: Forte; z-index: 1; left: 50px; top: 15px; position: absolute" Text="Welcome to Kelly's Pizza Palace"></asp:Label>
        <asp:DropDownList ID="PickUpDelivery" runat="server" style="z-index: 1; left: 284px; top: 237px; position: absolute">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Pick Up</asp:ListItem>
            <asp:ListItem>Delivery</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblpickupordelivery" runat="server" style="z-index: 1; left: 143px; top: 239px; position: absolute; font-family: Arial, Helvetica, sans-serif;" Text="Pick Up or Delivery"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 437px; top: 543px; position: absolute" Text="Submit Order" />
        <asp:GridView ID="gvOrderOutput" runat="server" AutoGenerateColumns="False" ShowFooter="true" style="z-index: 1; left: 196px; top: 832px; position: absolute; height: 164px; width: 599px">
            <Columns>
                <asp:BoundField HeaderText="Pizza Type" DataField="type" />
                <asp:BoundField HeaderText="Size" DataField="size" />
                <asp:BoundField HeaderText="Quantity" DataField="quantity" />
                <asp:BoundField HeaderText="Price" DataField="totalperpizza" />
                <asp:BoundField HeaderText="Total Cost" DataField="total" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblNameSum" runat="server" style="z-index: 1; left: 147px; top: 688px; position: absolute; height: 18px; right: 1243px; text-align: right;" Text="Your Name:" Visible="False"></asp:Label>
        <asp:Label ID="lblPhoneEntered" runat="server" style="z-index: 1; left: 292px; top: 716px; position: absolute; width: 300px;"></asp:Label>
        <asp:Label ID="lblAddressEntered" runat="server" style="z-index: 1; left: 292px; top: 751px; position: absolute; margin-bottom: 5px; width: 354px;"></asp:Label>
        <p>
        <asp:Button ID="btnManager" runat="server" OnClick="btnManager_Click" style="z-index: 1; left: 14px; top: 97px; position: absolute; width: 119px" Text="Managers Report" />
        </p>
        <asp:Label ID="lblThanks" runat="server" style="z-index: 1; left: 263px; top: 1179px; position: absolute; right: 890px; height: 25px" Text="Thank you for your Order!" Visible="False" Font-Names="Vladimir Script" Font-Size="X-Large"></asp:Label>
    </form>
</body>
</html>
