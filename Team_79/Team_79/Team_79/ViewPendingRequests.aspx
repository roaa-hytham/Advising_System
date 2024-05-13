<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPendingRequests.aspx.cs" Inherits="Team_79.ViewPendingRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter advisor id to view all pending requests: "></asp:Label>
            <asp:TextBox ID="advisorid" runat="server" OnTextChanged="advisorid_TextChanged"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="pendingreq" runat="server" Text="Enter" OnClick="pendingreq_Click" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
    </form>
</body>
</html>
