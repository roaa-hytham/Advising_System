<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertGradPlan.aspx.cs" Inherits="Team_79.InsertGradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert Graduation Plan:<br />
            <br />
            Semester code:
            <asp:TextBox ID="SemCode" runat="server" ></asp:TextBox>
            <br />
            Expected graduation date:
            <asp:TextBox ID="GradDate" runat="server"></asp:TextBox>
            <br />
            Semester credit hours:
            <asp:TextBox ID="CreditHours" runat="server"></asp:TextBox>
            <br />
            Advisor id:
            <asp:TextBox ID="AdvisorID" runat="server"></asp:TextBox>
            <br />
            Student id:
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="InsertPlan" runat="server" Text="Insert" OnClick="InsertPlan_Click" style="height: 26px" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
