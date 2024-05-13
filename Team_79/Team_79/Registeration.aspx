<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="Team_79.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        </p>
        <div style="text-align:center">
            <asp:Button ID="FMR" runat="server" Text="First Makeup Registeration" OnClick="FMR_Click" />
        </div>
        <p>
        </p>
        <div style="text-align:center">
            <asp:Button ID="SMR" runat="server" Text="Second Makeup Registeration" OnClick="SMR_Click" />
        </div>
        <p>
        </p>
        <div style="text-align:center">
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
        </div>
    </form>
</body>
</html>
