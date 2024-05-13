<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkInstructor.aspx.cs" Inherits="Team_79.LinkInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Link instructor to course on specific slot"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="course ID"></asp:Label>
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Instructor ID"></asp:Label>
            <asp:TextBox ID="Instructor_id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="slot ID"></asp:Label>
            <asp:TextBox ID="slot_id" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Link" runat="server" Text="Link" OnClick="Link_Click" />
    </form>
</body>
</html>
