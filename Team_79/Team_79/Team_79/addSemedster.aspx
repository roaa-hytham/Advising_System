<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addSemedster.aspx.cs" Inherits="Team_79.addSemedster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            add Semester</div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please choose the starting date of semester"></asp:Label>
        </p>
        <asp:TextBox ID="start" runat="server" Type="Date"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Please choose the ending date of semester"></asp:Label>
        </p>
            <asp:TextBox ID="end" runat="server"  Type="Date"></asp:TextBox>            
        <p>
            <asp:Label ID="Label3" runat="server" Text="Please enter the semester code"></asp:Label>
                <asp:TextBox ID="semester_code" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addSemester" runat="server" Text="Add Semester" OnClick="addSemester_Click" />
        </p>
    </form>
</body>
</html>
