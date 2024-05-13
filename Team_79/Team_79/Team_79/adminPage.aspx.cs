using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void advisors_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllAdvisors.aspx");

        }

        protected void Students_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllStudents.aspx");
        }
        protected void requests_Click(object sender, EventArgs e)
        {
            Response.Redirect("pendingRequests.aspx");
        }

        protected void Course_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCourse.aspx");
        }

        protected void addSemester_Click(object sender, EventArgs e)
        {
            Response.Redirect("addSemedster.aspx");
        }

        protected void LinkInstructor_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkInstructor.aspx");
        }

        protected void LinkStudentAdvisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkStudentToAdvisor.aspx");
        }

        protected void LinkStudentCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkStudentCourse.aspx");
        }

        protected void Instructors_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetailsInstructor.aspx");
        }

        protected void allSemesters_Click(object sender, EventArgs e)
        {
            Response.Redirect("SemsterOfferedCourses.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("All_admin_pt2.aspx");
        }
    }
}