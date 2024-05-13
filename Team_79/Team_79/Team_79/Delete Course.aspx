<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete Course.aspx.cs" Inherits="Team_79.Delete_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_delete_course" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Input bellow the Course ID to Delete Course"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="deleteCourseID" runat="server" OnTextChanged="deleteCourse_TextChanged" placeholder =" Course ID"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonDeleteCou" runat="server" Text="Delete" OnClick ="deleteCourse_TextChanged" />
        </div>
    </form>
</body>
</html>
