<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TemperatureWeb._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Celcius to fahrenheit : "></asp:Label>
        <asp:TextBox ID="c2f" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="c2fresult" runat="server"></asp:Label>

        <p>

        <asp:Label ID="TextBox1" runat="server" Text="fahrenheit to Celcius : "></asp:Label>
        <asp:TextBox ID="f2c" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <asp:Label ID="f2cresult" runat="server"></asp:Label>

        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
