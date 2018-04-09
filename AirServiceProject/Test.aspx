<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AirServiceProject.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-image: url(image/maxresdefault.jpg);
            background-size:cover;
            background-attachment:fixed;
        }
        form{
            background-color:white;
            padding:50px;
            margin:auto;
            opacity:0.95;
            width:500px;
            max-width:500px;
        }
        h2{
            text-align:center;
        }
        .center{
            text-align:center;
            opacity:0.95;
            width:100%;
        }
        
    </style>
</head>
    
<body>
    <div class="center">
    <form id="form1" runat="server" >
    <div>
    
    </div>
     <h2>Book Your Flight</h2>
        <br />
        <asp:Label ID="lblDepCity" runat="server" Text="Departure City:"></asp:Label><br />
        <asp:TextBox ID="txtDepCity" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblDepState" runat="server"  Text="Departure State:"></asp:Label><br />
        
        <asp:TextBox ID="txtDepState" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblArrCity" runat="server" Text="Arrival City:"></asp:Label>
        <br />
        
        
        
        <asp:TextBox ID="txtArrCity" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblArrState" runat="server" Text="Arrival State:"></asp:Label><br />
        <asp:TextBox ID="txtArrState" runat="server" ></asp:TextBox><br />
        <br />
        
        <input type="date" />
        
        <br />
        <br />
        <asp:Calendar ID="gvCalender" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399"
             Height="200px" ShowGridLines="True" style="width:100%;">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White"/>
        </asp:Calendar>
        <br />
        <asp:RadioButton ID="RbTwo" runat="server" Text="Round Trip" /><br />
        <asp:RadioButton ID="RbOne" runat="server"  Text="One Way" />

        <br />

        <br />
        <asp:Label ID="Label1" runat="server" Text="Preferred Class:"></asp:Label><br />
        <asp:DropDownList ID="ddlClass" runat="server" >
            <asp:ListItem>Choose</asp:ListItem>
            <asp:ListItem>First</asp:ListItem>
            <asp:ListItem>Economy</asp:ListItem>
            <asp:ListItem>Business</asp:ListItem>
            <asp:ListItem>Premium</asp:ListItem>
       
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"  Text="Air Carrier"></asp:Label>
        <br />
        <p>
            <asp:TextBox ID="txtAirCarrier" runat="server" ></asp:TextBox>
        </p>
        <p>
            <br />
        <asp:Button ID="btnSearch" runat="server"  Text="Search" />
        </p>
    </form>
        </div>
</body>
</html>
