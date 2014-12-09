<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="True" CodeFile="Default.aspx.cs" Inherits="Elective" %>
<%@ Register TagPrefix = "heading" TagName="description" src="WebUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div style="padding-left:50px;background-color: cornflowerblue;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Tempe Travel Agency" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />

            
            <asp:Label ID="Label1" runat="server" Text="Searh for Nearest Banks/ATMs" style="font-size:large;" Font-Bold="True"></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Service URL:  "></asp:Label><a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
           
            
            Please select atleast one checkbox and provide correct latitude/longitude:<br />
            (Error handling in Global.asax)  <br /><br /><asp:CheckBox ID="CheckBox1" runat="server" Text="Bank" />&nbsp&nbsp<asp:CheckBox ID="CheckBox2" runat="server" Text="ATM" /><br /><br />
            <heading:description ID = "control1" runat="server"/>
            <asp:Button ID="Button1" runat="server" Text="Button" Width="120px" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label><br /><br />
            
        </div>
        <br />
        <div style="padding-left:50px;">
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid" CellPadding="1" CellSpacing="1" GridLines="Both"></asp:Table>
        </div>
        <br /><br />
        
        <br /><br />
        
        <br /><br />
       

    </form>
</body>
</html>