<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudStat.aspx.cs" Inherits="Team_79.UpdateStudStat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_upd_stu_sta" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Update a Student's Financial Status"></asp:Label>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
            <br />
            <asp:TextBox ID="stud_id" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button_upd_stud_stat" runat="server" Text="Update" OnClick="Button_upd_stud_stat_Click" />
        </div>
    </form>
</body>
</html>
