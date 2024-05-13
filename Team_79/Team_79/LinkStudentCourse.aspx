<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkStudentCourse.aspx.cs" Inherits="Team_79.LinkStudentCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Link student to course and instructor"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Course ID"></asp:Label>
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Instructor ID"></asp:Label>
        <asp:TextBox ID="instructor_id" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Student ID"></asp:Label>
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="Semester Code"></asp:Label>
        <asp:TextBox ID="sem_code" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Link" runat="server" Text="Link" OnClick="Link_Click" />
        </p>
    </form>
</body>
</html>
