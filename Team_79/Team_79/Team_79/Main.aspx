<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Team_79.Main1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Student" runat="server" Text="Student" OnClick="Student_Click" />
        </div>
        <asp:Button ID="Advisor" runat="server" Text="Advisor" OnClick="Advisor_Click" />
        <p>
            <asp:Button ID="Admin" runat="server" Text="Admin" OnClick="Admin_Click" />
        </p>
    </form>
</body>
</html>
