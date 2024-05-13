<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login admin.aspx.cs" Inherits="Team_79.login_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please enter admin ID</div>
        <p>
            <asp:TextBox ID="adminID" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        password<p>
            <asp:TextBox ID="adminPassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="adminLogin" runat="server" Text="log in" OnClick="adminLogin_Click" />
        </p>
    </form>
</body>
</html>
