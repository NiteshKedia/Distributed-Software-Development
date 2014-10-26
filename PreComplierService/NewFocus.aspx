<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewFocus.aspx.cs" Inherits="Required" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div style="padding-left:50px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="NEWS Focus Service" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />
                <asp:Label ID="Label7" runat="server" Text="Description : This service returns the current news related to the given topics"></asp:Label><br /><br />

            
            <asp:Label ID="Label2" runat="server" Text="Service URL: "></asp:Label>&nbsp&nbsp<a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Methods"></asp:Label>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>string NewsFocus(string topic);</asp:ListItem>
            </asp:BulletedList>
            <asp:Label ID="Label4" runat="server" Text="Enter a Topic  :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="Button" Width="107px" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label><br /><br />
            <asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines="Both"></asp:Table>
        </div>

    </form>
</body>
</html>
