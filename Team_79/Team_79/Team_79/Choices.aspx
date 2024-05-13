<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choices.aspx.cs" Inherits="Team_79.Choices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Choose the option you want</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Phones" Text="Add phone number" Width="377px" />        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="29px" OnClick="optional" Text="View all optional courses in this semester" Width="377px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Height="29px" OnClick="available" Text= "View all available courses in this semester" Width="377px" />        </p>
        <p>
            <asp:Button ID="Button4" runat="server" Height="29px" OnClick="required" Text="View required courses in this semester" Width="377px" />        </p>
        <p>
            <asp:Button ID="Button5" runat="server" Height="29px" OnClick="missing" Text="View missing courses in this semester" Width="377px" />        </p>
        <p>
            <asp:Button ID="Button6" runat="server" Height="29px" OnClick="courses" Text="Send a course request" Width="376px" />

        </p>
        <p>
            <asp:Button ID="Button7" runat="server" Height="29px" OnClick="credit" Text="Send a credit hour request" Width="377px" />        </p>
        <asp:Button ID="Button9" runat="server" Text="Back" OnClick="Button9_Click" />
        <asp:Button ID="Button8" runat="server" Text="See More" OnClick="Button8_Click" />
    </form>
</body>
</html>