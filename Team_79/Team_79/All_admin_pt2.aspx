<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All_admin_pt2.aspx.cs" Inherits="Team_79.All_admin_pt2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Admin Pages"></asp:Label>
            </p>
            <p>
                <asp:Button ID="Add_Exam" runat="server" Text="Add Exam" OnClick="Add_Exam_Click" />
            </p>
                        <p>
                            <asp:Button ID="Delete_c" runat="server" Text="Delete Course" OnClick="Delete_c_Click" />
            </p>            <p>
                <asp:Button ID="Delete_S" runat="server" Text="Delete Slots" OnClick="Delete_S_Click" />
            </p>            <p>
                <asp:Button ID="Stud_Stat" runat="server" Text="Update Student Status" OnClick="Stud_Stat_Click" />
            </p>            <p>
                <asp:Button ID="Act_Stu" runat="server" Text="Fetch Active Students" OnClick="Act_Stu_Click" />
            </p>            <p>
                <asp:Button ID="Sem_Cour" runat="server" Text="Fetch Semseter Courses" OnClick="Sem_Cour_Click" />
            </p>
                       <p>
                           <asp:Button ID="Issue_Ins" runat="server" Text="Issue Students Installments" OnClick="Issue_Ins_Click" />
            </p>            <p>
                <asp:Button ID="Stu_Tran" runat="server" Text="Students Transcrips" OnClick="Stu_Tran_Click" />
            </p>            <p>
                <asp:Button ID="grad_plan" runat="server" Text="View Students Graduation Plan" OnClick="grad_plan_Click" />
            </p>            <p>
                <asp:Button ID="Stud_paym" runat="server" Text="View Students Payments" OnClick="Stud_paym_Click" />
            </p>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Sign Out" OnClick="Button2_Click" />
    </form>
</body>
</html>
