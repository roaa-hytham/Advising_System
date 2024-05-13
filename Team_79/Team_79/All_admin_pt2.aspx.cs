using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class All_admin_pt2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void Add_Exam_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddExam.aspx");
        }

        protected void Delete_c_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete Course.aspx");

        }

        protected void Delete_S_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete_Slot.aspx");

        }

        protected void Stud_Stat_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudStat.aspx");

        }

        protected void Act_Stu_Click(object sender, EventArgs e)
        {
            Response.Redirect("FetchActiveStud.aspx");

        }

        protected void Sem_Cour_Click(object sender, EventArgs e)
        {
            Response.Redirect("FetchSemCou.aspx");

        }

        protected void Issue_Ins_Click(object sender, EventArgs e)
        {
            Response.Redirect("Issue_Installments.aspx");

        }

        protected void Stu_Tran_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Transcript.aspx");

        }

        protected void grad_plan_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_GradPlan.aspx");

        }

        protected void Stud_paym_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Payments.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}