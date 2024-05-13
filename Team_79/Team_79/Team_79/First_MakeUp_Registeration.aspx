<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First_MakeUp_Registeration.aspx.cs" Inherits="Team_79.FMR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Label ID="Label1" runat="server" Text="Enter Course ID: "></asp:Label>
            <asp:TextBox ID="Cid" runat="server"></asp:TextBox>
        </div>
        <p>

        </p>
        <div style="text-align:center">
            <asp:Label ID="Label2" runat="server" Text="Enter Current Semester: "></asp:Label>
            <asp:TextBox ID="CurrSem" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center">
            <asp:Button ID="RFM" runat="server" Text="Register" OnClick="RFM_Click" />
        </div>
        <div style="text-align:center">
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
        </div>
    </form>
</body>
</html>
