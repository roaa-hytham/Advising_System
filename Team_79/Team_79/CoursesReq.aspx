<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoursesReq.aspx.cs" Inherits="Team_79.CoursesReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Approve/Reject courses request based on the student’s assigned credit hours:<br />
            <br />
            RequestID:
            <asp:TextBox ID="requestIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Current Semester Code:
            <asp:TextBox ID="currentSemesterCodeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Approve/Reject" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
