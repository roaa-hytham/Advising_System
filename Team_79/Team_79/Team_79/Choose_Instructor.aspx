<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choose_Instructor.aspx.cs" Inherits="Team_79.ChI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Label ID="Label3" runat="server" Text="Enter Instructor ID: "></asp:Label>
            <asp:TextBox ID="Iid" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center">
            <asp:Label ID="Label1" runat="server" Text="Enter Course ID: "></asp:Label>
            <asp:TextBox ID="Cid" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center">
            <asp:Label ID="Label2" runat="server" Text="Enter Current Semester: "></asp:Label>
            <asp:TextBox ID="CurrSem" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center">
            <asp:Button ID="Ch" runat="server" Text="Choose" OnClick="Ch_Click" />
        </div>
        <div style="text-align:center">
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
        </div>
    </form>
</body>
</html>
