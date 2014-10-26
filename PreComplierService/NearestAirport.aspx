<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="True" CodeFile="NearestAirport.aspx.cs" Inherits="NearestAirport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div style="padding-left:50px;">
        
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
             <asp:Label ID="Label19" runat="server" Text="Nearest Airport Service" style="align-self:center;font-size:large;" Font-Bold="True" ></asp:Label><br /><br />
        
            
            <asp:Label ID="Label10" runat="server" Text="Description:  This service returns the Nearest Airport for the given latitude Longitude"></asp:Label>
             <br />
             <br />
            <asp:Label ID="Label20" runat="server" Text="Service URL:  "></asp:Label><a href="http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl" runat="server" id="myLink">http://webstrar39.fulton.asu.edu/Page5/Service1.svc?wsdl</a><br /><br />
            <asp:Label ID="Label21" runat="server" Text="Methods"></asp:Label>
            <asp:BulletedList ID="BulletedList4" runat="server">
                <asp:ListItem>string GetNearestAirport(string latitude, string longitude)</asp:ListItem>
            </asp:BulletedList>
            <asp:Label ID="Label22" runat="server" Text="Latitude  :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label23" runat="server" Text="Longitude :" style="font-size:large;" Font-Bold="True"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button4" runat="server" Text="Button" OnClick ="Button4_Click" Width="120px"/><br /><br />

         <asp:Label ID="Label9" runat="server" Text=""></asp:Label><br /><br />
         <asp:Label ID="Label1" runat="server" Text="Airport: " Visible="false"></asp:Label>&nbsp&nbsp;&nbsp; &nbsp<asp:Label ID="Label2" runat="server" Text="" Visible="false"></asp:Label><br />
         <asp:Label ID="Label3" runat="server" Text="City: " Visible="false"></asp:Label>&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text="" Visible="false"></asp:Label><br />
         <asp:Label ID="Label5" runat="server" Text="State: " Visible="false"></asp:Label>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp<asp:Label ID="Label6" runat="server" Text="" Visible="false"></asp:Label><br />
         <asp:Label ID="Label7" runat="server" Text="Country: " Visible ="false"></asp:Label>&nbsp&nbsp; &nbsp<asp:Label ID="Label8" runat="server" Text="" Visible="false"></asp:Label><br />
            
            

        </div>
    </form>
</body>
</html>
