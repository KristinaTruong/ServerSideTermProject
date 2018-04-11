<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AirServiceProject.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url(image/550640-airlines-hd.jpg);
            background-size: cover;
            background-attachment: fixed;
        }
        form{
            background-color:white;
            padding:50px;
            margin:50px;
            opacity:0.95;
            width:500px;
            max-width:100%;
        }
        h2{
            text-align:center;
        }
        .center{
            text-align:left;
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
        <asp:TextBox ID="txtArrState" runat="server" ></asp:TextBox>&nbsp;<br />
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
        Preferred Number of Stops:<br />
        <asp:TextBox ID="txtStops" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"  Text="Air Carrier"></asp:Label>

            <br />

            <asp:TextBox ID="txtAirCarrier" runat="server" ></asp:TextBox>

        <p>
            <br />
        <asp:Button ID="btnSearch" runat="server"  Text="Search" OnClick="btnSearch_Click" />
            <asp:GridView ID="gvFlights" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </p>
    </form>
        </div>
</body>
</html>
