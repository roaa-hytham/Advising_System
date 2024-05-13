<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Team_79.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Admin Page"></asp:Label>
        </div>
        <asp:Button ID="advisors" runat="server" Text="Advisors" OnClick="advisors_Click" />
        <p>
            <asp:Button ID="Students" runat="server" Text="Sudents with their advisors" OnClick="Students_Click" />
        </p>
        <asp:Button ID="requests" runat="server" Text="Pending Requests" OnClick="requests_Click" />
        <p>
        <asp:Button ID="Course" runat="server" Text="Add Course" OnClick="Course_Click" />
            <asp:Button ID="addSemester" runat="server" Text="Add Semester" style="margin-bottom: 2px" OnClick="addSemester_Click" />
        </p>
        <p>
            <asp:Button ID="LinkInstructor" runat="server" Text=" Link instructor to a course in a specific slot" OnClick="LinkInstructor_Click" />
        </p>
        <asp:Button ID="LinkStudentAdvisor" runat="server" Text="Link a student to an advisor" OnClick="LinkStudentAdvisor_Click" />
        <p>
            <asp:Button ID="LinkStudentCourse" runat="server" Text="Link a student to a course with a specific instructor" OnClick="LinkStudentCourse_Click" />
        </p>
        <asp:Button ID="Instructors" runat="server" Text="all details of instructors with their assigned courses" OnClick="Instructors_Click" />
        <p>
            <asp:Button ID="allSemesters" runat="server" Text="all semesters along with their offered courses." OnClick="allSemesters_Click" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="See More" OnClick="Button1_Click" />
    </form>
</body>
</html>
