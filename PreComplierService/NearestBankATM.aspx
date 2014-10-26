<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="True" CodeFile="NearestBankATM.aspx.cs" Inherits="Elective" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div style="padding-left:50px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Nearest Bank ATM Service" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />

            <asp:Label ID="Label8" runat="server" Text="Description : This service returns the nearest Bank ATM for the given Latitude Longitude"></asp:Label><br />
            
            <br />
            <asp:Label ID="Label2" runat="server" Text="Service URL:  "></asp:Label><a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Methods"></asp:Label>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>string[] getNearestBankAtm(string latitude, string longitude, string Type)</asp:ListItem>
            </asp:BulletedList>
            <asp:Label ID="Label4" runat="server" Text="Latitude  :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp&nbsp <asp:CheckBox ID="CheckBox1" runat="server" Text="Bank" />&nbsp&nbsp<asp:CheckBox ID="CheckBox2" runat="server" Text="ATM" /><br /><br />
            <asp:Label ID="Label5" runat="server" Text="Longitude :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="Button" Width="120px" OnClick="Button1_Click" /><br /><br />
            
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label><br /><br />
            <asp:Table ID="Table1" runat="server" BorderStyle="Solid" CellPadding="1" CellSpacing="1" GridLines="Both"></asp:Table>
        </div>
        <br /><br />
        
        <br /><br />
        
        <br /><br />
       

    </form>
</body>
</html>
