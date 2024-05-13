
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phone.aspx.cs" Inherits="Team_79.phone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div></div>
        <p>
            Enter your phone number:</p>
        <p><asp:TextBox ID="number" runat="server"></asp:TextBox></p>
        <p><asp:Button ID="Button5" runat="server" Height="29px" OnClick="create" Text="ADD" Width="187px" /></p>
        <p><asp:Button ID="Button6" runat="server" Height="29px" OnClick="back" Text="Back" Width="187px" /></p>
        <p><asp:Button ID="Button7" runat="server" Height="29px" OnClick="signout" Text="Signout" Width="187px" /></p>
       
    </form>
</body>
</html>
