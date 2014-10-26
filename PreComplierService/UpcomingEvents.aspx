<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="True" CodeFile="UpcomingEvents.aspx.cs" Inherits="UpcomingEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-left:50px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Upcoming Event Service" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Description : This service returns upcoming events in the future for the given Latitude Longitude"></asp:Label><br /><br />
            
            <asp:Label ID="Label15" runat="server" Text="Service URL:  "></asp:Label><a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
            <asp:Label ID="Label10" runat="server" Text="Methods"></asp:Label>
            <asp:BulletedList ID="BulletedList3" runat="server">
                <asp:ListItem>string[] getUpcomingEvents(string latitude, string longitude)</asp:ListItem>
            </asp:BulletedList>
            <asp:Label ID="Label16" runat="server" Text="Latitude  :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label17" runat="server" Text="Longitude :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" Width="120px" /><br /><br />
           
            <asp:Label ID="Label18" runat="server" Text=""></asp:Label><br /><br />
            <asp:Table ID="Table3" runat="server" BorderStyle="Solid" GridLines="Both"></asp:Table>

       </div>
    </form>
</body>
</html>
