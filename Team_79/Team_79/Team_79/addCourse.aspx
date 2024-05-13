<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCourse.aspx.cs" Inherits="Team_79.addCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Add Course"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="course major"></asp:Label>
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="course semester"></asp:Label>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="credit hours"></asp:Label>
            <asp:TextBox ID="credit_hours" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="course name"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="offered in current semester"></asp:Label>
            
        </p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="offered">yes</asp:ListItem>
            <asp:ListItem Value="not offered">no</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Add Course" OnClick="Button1_Click" />
    </form>
</body>
</html>


