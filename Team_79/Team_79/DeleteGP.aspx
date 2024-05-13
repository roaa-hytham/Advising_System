<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteGP.aspx.cs" Inherits="Team_79.DeleteGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Delete certain course from certain graduation plan of certain student:<br />
            <br />
            Student ID:
            <asp:TextBox ID="studentIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester code:
            <asp:TextBox ID="semCodeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID:
            <asp:TextBox ID="courseIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
