<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Team_79.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login
        </div>
        <p>
            Enter User ID:</p>
        <p>
            <asp:TextBox ID="userID" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Password:</p>
        <p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="signin" runat="server" Height="29px" OnClick="login" Text="log in" Width="187px" />
        </p>
        <p>
    <asp:Button ID="Button1" runat="server" Height="29px" OnClick="register" Text="Register" Width="187px" />
</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click1" />
        </p>
    </form>
</body>
</html>
