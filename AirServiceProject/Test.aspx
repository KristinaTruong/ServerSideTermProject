<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AirServiceProject.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url("image/550640-airlines-hd.jpg");
            background-size: cover;
            background-attachment: fixed;
            font-family: 'Agency FB';
            font-size: 20px;
        }

        form {
            background-color: white;
            padding: 50px;
            margin: auto;
            margin-top: 0px;
            margin-bottom: 0px;
            opacity: 0.95;
            width: 70%;
            max-width: 100%;
        }

        h2 {
            text-align: center;
        }

        .center {
            text-align: left;
            opacity: 0.95;
            width: 100%;
        }

        .pad {
            padding-right: 50px;
        }
    </style>
</head>

<body>
    <div class="center">
        <form id="form1" runat="server">
            <table style="width: 100%">
                <tr>
                    <th colspan="2" style="text-align: center; font-family: 'Agency FB',Arial; width: 100%; background-color: black; color: white; margin-bottom: 30px;">
                        <h2>VACATION FLIGHT BOOKING</h2>
                    </th>
                </tr>
                <tr></tr>
                <tr style="vertical-align: text-top;">
                    <td>
                        <div class="pad">
                            <br />
                            <br />
                            <br />
 SEARCH FOR A FLIGHT<br />
                            <hr />
                            <br />
                            <asp:Label ID="lblDepCity" runat="server" Text="Departure City:"></asp:Label><br />
                            <asp:TextBox ID="txtDepCity" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblDepState" runat="server" Text="Departure State:"></asp:Label><br />

                            <asp:TextBox ID="txtDepState" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblArrCity" runat="server" Text="Arrival City:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtArrCity" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblArrState" runat="server" Text="Arrival State:"></asp:Label><br />
                            <asp:TextBox ID="txtArrState" runat="server"></asp:TextBox>&nbsp;<br />
                            <br />
                            <br />
                            <asp:RadioButton ID="RbTwo" runat="server" Text="Round Trip" /><br />
                            <asp:RadioButton ID="RbOne" runat="server" Text="One Way" />

                            <br />
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Preferred Class:"></asp:Label><br />
                            <asp:DropDownList ID="ddlClass" runat="server">
                                <asp:ListItem Selected="True">First</asp:ListItem>
                                <asp:ListItem>Economy</asp:ListItem>
                                <asp:ListItem>Business</asp:ListItem>
                                <asp:ListItem>Premium</asp:ListItem>

                            </asp:DropDownList>
                            <br />
                            <br />
 Preferred Number of Stops: Preferred Number of Stops:<br />
                            <asp:TextBox ID="txtStops" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Air Carrier"></asp:Label>

                            <br />

                            <asp:TextBox ID="txtAirCarrier" runat="server"></asp:TextBox>


                            <br />
                            <br />
                            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" UseSubmitBehavior="False" />

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
                        </div>
                    </td>
                    <td>
                        <div class="pad">
                            <div id="reserveSection" runat="server" style="display: inline;">
                                <br />
                                <br />
                                <br />
                                BOOK YOUR FLIGHT           BOOK YOUR FLIGHT<br />
                                <hr />
                                <br />
                                Customer ID<br />
                                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Customer Name<br />
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Customer Phone<br />
                                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Customer Email<br />
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Flight ID<br />
                                <asp:TextBox ID="txtFlightID" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Travel Site ID<br />
                                <asp:TextBox ID="txtTravelID" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                Travel Password<br />
                                <asp:TextBox ID="txtTravelPassword" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="btnReserve" runat="server" Text="Reserve" OnClick="btnReserve_Click" />
                            </div>
                        </div>
                    </td>
                </tr>


            </table>
        </form>
    </div>
</body>
</html>
