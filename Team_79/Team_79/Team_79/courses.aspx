﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="Team_79.courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form14" runat="server">
        <div>             <p>Enter the Course ID: </p>
<p> <asp:TextBox ID="course" runat="server"></asp:TextBox></p>
            <p>Enter your Comment:</p>
            <p><asp:TextBox ID="commentt" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="Button1" runat="server" Height="29px" OnClick="create" Text="Send!" Width="187px" /></p>
<p><asp:Button ID="Button2" runat="server" Height="29px" OnClick="signout" Text="Sign Out" Width="187px" /></p>
<p><asp:Button ID="Button3" runat="server" Height="29px" OnClick="back" Text="Back" Width="187px" /></p>
        </div>
    
    </form>
</body>
</html>
