<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Width="363px" Text ="http://www.public.asu.edu/~nkedia1/hotel_template.xml"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp        <asp:Button ID="Button1" runat="server" Text="Get XML Data" OnClick="Button1_Click" />
    </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 160px">
            <asp:Table ID="Table1" runat="server" Height="25px">
            </asp:Table>
        </div>
    </form>
</body>
</html>
