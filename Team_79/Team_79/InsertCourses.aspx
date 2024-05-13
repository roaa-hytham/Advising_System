<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertCourses.aspx.cs" Inherits="Team_79.InsertCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add course inside certain plan for certin student:<br />
            <br />
            Student ID:<asp:TextBox ID="studentIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester code:<asp:TextBox ID="semesterCodeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Course name:<asp:TextBox ID="courseNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
