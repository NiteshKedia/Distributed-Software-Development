<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="True" CodeFile="TouristAttractions.aspx.cs" Inherits="TouristAttractions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-left:50px;">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Tourist Attraction Service" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Description : This service returns the nearest tourist attractions for the given Latitude Logitude"></asp:Label><br /><br />
       
            <asp:Label ID="Label9" runat="server" Text="Service URL:  "></asp:Label><a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
            <asp:Label ID="Label11" runat="server" Text="Methods"></asp:Label>
            <asp:BulletedList ID="BulletedList2" runat="server">
                <asp:ListItem>string[] getTouristAttraction(string latitude, string longitude)</asp:ListItem>
            </asp:BulletedList>
            <asp:Label ID="Label12" runat="server" Text="Latitude  :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label13" runat="server" Text="Longitude :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="Button" OnClick ="Button2_Click" Width="120px"/><br /><br />
            
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label><br /><br />
            <asp:Table ID="Table2" runat="server" BorderStyle="Solid" GridLines="Both"></asp:Table>
        </div>
    </form>
</body>
</html>
