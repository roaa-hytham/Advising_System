<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Team_79.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
    Enter your First Name:</p>
          <p>  <asp:TextBox ID="first" runat="server"></asp:TextBox></p>
            <p>
    Enter your Last Name:</p>
          <p>  <asp:TextBox ID="last" runat="server"></asp:TextBox></p>
            <p>
    Enter your password:</p>
          <p>  <asp:TextBox ID="password" runat="server"></asp:TextBox></p>
            <p>
    Enter your Faculty:</p>
          <p>  <asp:TextBox ID="faculty" runat="server"></asp:TextBox></p>
            <p>
    Enter your Email:</p>
          <p>  <asp:TextBox ID="email" runat="server"></asp:TextBox></p>
            <p>
    Enter your Major:</p>
          <p>  <asp:TextBox ID="major" runat="server"></asp:TextBox></p>
            <p>
    Enter your Current Semester:</p>
          <p>  <asp:TextBox ID="semester" runat="server"></asp:TextBox></p>
        <p><asp:Button ID="Button5" runat="server" Height="29px" OnClick="create" Text="ADD" Width="187px" /></p>
      
        <p><asp:Button ID="Button7" runat="server" Height="29px" OnClick="signout" Text="Signout" Width="187px" /></p>
            </div>
    </form>
</body>
</html>
