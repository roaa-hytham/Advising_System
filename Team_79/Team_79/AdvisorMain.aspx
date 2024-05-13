<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorMain.aspx.cs" Inherits="Team_79.AdvisorMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hello, Advisor!"></asp:Label>
        </div>
        <asp:Button ID="Button2" runat="server" Text="Insert Graduation Plan" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Insert Courses for Grad Plan" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Update expected graduation date" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Delete course from a grad plan" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="View all students assigned" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Text="View all requests" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="View all pending requests" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" Text="Approve/ reject extra credit hours request" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" Text="Approve/ reject extra courses request" OnClick="Button10_Click1" />
        <p>
            <asp:Button ID="Button11" runat="server" Text="Sign Out" OnClick="Button11_Click" />
        </p>
    </form>
</body>
</html>
