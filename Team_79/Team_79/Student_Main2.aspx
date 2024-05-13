<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Main2.aspx.cs" Inherits="Team_79.Main" %>

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
            <asp:Button ID="CPD" runat="server" Text="Courses Details" OnClick="CPD_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="CSID" runat="server" Text="Courses Schedule" OnClick="CSID_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="AS" runat="server" Text="Academic Schedule" OnClick="AS_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="ChI" runat="server" Text="Choose Instructor" OnClick="ChI_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="ESch" runat="server" Text="Exam Schedule" OnClick="ESch_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="Reg" runat="server" Text="Make-up Registeration" OnClick="Reg_Click" />
        </div>
        <p>

        </p>

        <div style="text-align:center">
            <asp:Button ID="Pay" runat="server" Text="Payment" OnClick="Pay_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
            <asp:Button ID="GP" runat="server" Text="Graduation Plan" OnClick="GP_Click" />
        </div>
        <p>
        </p>

        <div style="text-align:center">
              <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
        </div>
        <p>
        </p>
        <div style="text-align:center">
            <asp:Button ID="LO" runat="server" Text="Log Out" OnClick="LO_Click" style="height: 35px" />
        </div>
    </form>
</body>
</html>
