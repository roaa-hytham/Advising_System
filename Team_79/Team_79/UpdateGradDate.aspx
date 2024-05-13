<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateGradDate.aspx.cs" Inherits="Team_79.UpdateGradDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update expected graduation date in a certain graduation plan:<br />
            <br />
            Expected grad date:<asp:TextBox ID="expectedGradDateTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Student ID:
            <asp:TextBox ID="studentIdTextBox" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" style="height: 26px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
    </form>
</body>
</html>
