<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditHours.aspx.cs" Inherits="Team_79.CreditHours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Accept/Reject Credit hours request:<br />
            <br />
            Request ID:
            <asp:TextBox ID="requestIdTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Current semester code:
            <asp:TextBox ID="currentSemCodeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Accept/Reject" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
