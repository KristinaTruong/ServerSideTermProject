<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AirServiceProject.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body style="background-image:url(image/maxresdefault.jpg)">
    <form id="form1" runat="server">
    <div>
    
    </div>
     <center><h2>Book Your Flight</h2></center>
        <asp:Label ID="lblDepState" runat="server" style="z-index: 1; left: 70px; top: 86px; position: absolute; width: 115px" Text="Departure State:"></asp:Label>
        <asp:RadioButton ID="RbTwo" runat="server" style="z-index: 1; left: 33px; top: 514px; position: absolute" Text="Round Trip" />
        <asp:Label ID="lblDepCity" runat="server" style="z-index: 1; left: 333px; top: 87px; position: absolute; height: 19px" Text="Departure City:"></asp:Label>
        <asp:Label ID="lblArrState" runat="server" style="z-index: 1; left: 71px; top: 134px; position: absolute; height: 25px" Text="Arrival State:"></asp:Label>
        <asp:Label ID="lblArrCity" runat="server" style="z-index: 1; left: 341px; top: 131px; position: absolute" Text="Arrival City:"></asp:Label>
        <asp:TextBox ID="txtDepState" runat="server" style="z-index: 1; left: 176px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtArrState" runat="server" style="position: absolute; z-index: 1; left: 156px; top: 131px"></asp:TextBox>
        <asp:TextBox ID="txtDepCity" runat="server" style="z-index: 1; left: 437px; top: 86px; position: absolute; height: 18px"></asp:TextBox>
        <asp:TextBox ID="txtArrCity" runat="server" style="z-index: 1; left: 426px; top: 128px; position: absolute; height: 19px"></asp:TextBox>
        <asp:Calendar ID="gvCalender" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" style="z-index: 1; left: 18px; top: 255px; position: absolute; height: 188px; width: 259px; right: 558px;" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <asp:RadioButton ID="RbOne" runat="server" style="z-index: 1; left: 35px; top: 486px; position: absolute; right: 435px; height: 15px;" Text="One Way" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 336px; top: 420px; position: absolute" Text="Preferred Class:"></asp:Label>
        <asp:DropDownList ID="ddlClass" runat="server" style="z-index: 1; left: 448px; top: 417px; position: absolute; height: 17px">
            <asp:ListItem>Choose</asp:ListItem>
            <asp:ListItem>First</asp:ListItem>
            <asp:ListItem>Economy</asp:ListItem>
            <asp:ListItem>Business</asp:ListItem>
            <asp:ListItem>Premium</asp:ListItem>
           
        </asp:DropDownList>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 291px; top: 532px; position: absolute; right: 311px;" Text="Search" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 75px; top: 198px; position: absolute" Text="Air Carrier"></asp:Label>
        <p>
            <asp:TextBox ID="txtAirCarrier" runat="server" style="z-index: 1; left: 157px; top: 198px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
