<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_Slot.aspx.cs" Inherits="Team_79.Delete_Slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_delete_slot" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Input bellow the Course ID to Delete Slot "></asp:Label>
           <br />
            <br />
            <asp:TextBox ID="user_delete_slot" runat="server"  placeholder ="Semester Code"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button_delete_slot" runat="server" Text="Delete" OnClick ="button_delete_Slot"/>
        </div>
    </form>
</body>
</html>
