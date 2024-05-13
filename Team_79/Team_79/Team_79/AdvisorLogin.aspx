<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorLogin.aspx.cs" Inherits="Team_79.AdvisorLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Advisor Login</div>
        <p>
            User ID:&nbsp;
            <asp:TextBox ID="advisorID" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="advisorPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="advisorsignin" runat="server" OnClick="adlogin" Text="Login" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
    </form>
</body>
</html>
