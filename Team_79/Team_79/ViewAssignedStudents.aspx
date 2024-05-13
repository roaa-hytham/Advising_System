<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignedStudents.aspx.cs" Inherits="Team_79.ViewAssignedStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="View all assigned students from a certain major along with their taken courses: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Advisor ID: "></asp:Label>
            <asp:TextBox ID="advisorID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Major: "></asp:Label>
            <asp:TextBox ID="majorTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
