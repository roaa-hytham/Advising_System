<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllRequests.aspx.cs" Inherits="Team_79.ViewAllRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="View All Requests: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Advisor ID: "></asp:Label>
            <asp:TextBox ID="advisorID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
