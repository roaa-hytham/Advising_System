<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExam.aspx.cs" Inherits="Team_79.AddExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_add_exam" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Add an Exam"></asp:Label>
            <br /><br />            
            <asp:Label ID="Label2" runat="server" Text="Exam type"></asp:Label>
            <br />
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Exam Date"></asp:Label>
            <br />
            <asp:TextBox ID="date" runat="server" Type="Date" placeholder="YYYY/MM/DD"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Exam Course"></asp:Label>
            <br />
            <asp:TextBox ID="course" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button_add_exam" />
        </div>
    </form>
</body>
</html>
