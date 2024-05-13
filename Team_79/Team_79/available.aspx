<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="available.aspx.cs" Inherits="Team_79.available" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form3" runat="server">
        <p>
    Enter your current semester:</p>
<p>
    <asp:TextBox ID="semester" runat="server"></asp:TextBox></p>
    
    <p><asp:Button ID="Button3" runat="server" Height="29px" OnClick="create" Text="Done!" Width="187px" /></p>
    <p><asp:Button ID="Button4" runat="server" Height="29px" OnClick="signout" Text="Sign Out" Width="187px" /></p>
    <p><asp:Button ID="Button8" runat="server" Height="29px" OnClick="back" Text="back" Width="187px" /></p>

    </form>
</body>
</html>
