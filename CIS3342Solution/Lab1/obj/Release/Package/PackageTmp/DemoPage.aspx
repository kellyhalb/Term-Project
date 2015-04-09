<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoPage.aspx.cs" Inherits="Lab1.DemoPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CIS3342 Lab Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblDisplay" runat="server" style="z-index: 1; left: 504px; top: 76px; position: absolute"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 492px; top: 179px; position: absolute; height: 29px; width: 95px" Text="Click Me" OnClick="btnSubmit_Click" />
        <asp:TextBox ID="txtInput" runat="server" style="z-index: 1; left: 476px; top: 132px; position: absolute"></asp:TextBox>
        <asp:GridView ID="gvPizza" runat="server" OnSelectedIndexChanged="gvPizza_SelectedIndexChanged" style="z-index: 1; left: 152px; top: 261px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:GridView ID="gvPizzaOrder" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 500px; top: 261px; position: absolute; height: 133px; width: 231px; margin-top: 6px">
            <Columns>
                <asp:TemplateField HeaderText="Select Pizza to Order">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PizzaType" HeaderText="Pizza Type" />
                <asp:BoundField DataField="BasePrice" DataFormatString="{0:c}" HeaderText="Price" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
