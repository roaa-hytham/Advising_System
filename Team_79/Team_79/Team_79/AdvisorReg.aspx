<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorReg.aspx.cs" Inherits="Team_79.AdvisorReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Advisor Registration:<br />
            <br />
            Name:<asp:TextBox ID="advisorNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:<asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:<asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Office:<asp:TextBox ID="officeTextBox" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
