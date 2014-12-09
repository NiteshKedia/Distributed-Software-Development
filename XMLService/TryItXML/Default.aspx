<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Input XML URL:"></asp:Label>&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Input XSD URL:"></asp:Label>&nbsp&nbsp&nbsp; &nbsp<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Validate XML" OnClick="Button1_Click1" /><br /><br />

        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0033CC"></asp:Label><br /><br />


        <asp:Label ID="Label3" runat="server" Text="Input XML URL:"></asp:Label>&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Input XSL URL:"></asp:Label>&nbsp&nbsp&nbsp; &nbsp<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button2" runat="server" Text="Transform XML & Generate HTML" OnClick="Button2_Click1" /><br /><br />

        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>

        <asp:Button ID="Button3" runat="server" Text="Add data to XML" OnClick="Button3_Click" />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
