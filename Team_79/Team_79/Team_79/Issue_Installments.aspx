<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue_Installments.aspx.cs" Inherits="Team_79.Issue_Installments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_issue_ins" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Issue Installment"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Student's Payment ID: "></asp:Label>
            <asp:TextBox ID="paym_id" runat="server" placeholder ="Payment ID"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button_issue_inst" runat="server" Text="Done" OnClick="Button_issue_inst_Click" />
        </div>
    </form>
</body>
</html>
