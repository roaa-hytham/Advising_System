using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class AdvisorMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudents.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPendingRequests.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAssignedStudents.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllRequests.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertGradPlan.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertCourses.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateGradDate.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteGP.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreditHours.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursesReq.aspx");
        }

        protected void Button10_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CoursesReq.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}