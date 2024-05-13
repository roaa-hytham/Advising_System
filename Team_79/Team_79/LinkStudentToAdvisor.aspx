<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkStudentToAdvisor.aspx.cs" Inherits="Team_79.LinkStudentToAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Link student to advisor"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Advisor ID"></asp:Label>
            <asp:TextBox ID="advisor_id" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Link" runat="server" Text="Link" OnClick="Link_Click" />
    </form>
</body>
</html>
