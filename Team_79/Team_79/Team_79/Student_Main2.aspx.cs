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
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registeration.aspx");
        }

        protected void CPD_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses_Details.aspx");

        }

        protected void CSID_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses_Schedule.aspx");
        }

        protected void AS_Click(object sender, EventArgs e)
        {
            Response.Redirect("Academic_Schedule.aspx");
        }

        protected void ChI_Click(object sender, EventArgs e)
        {
            Response.Redirect("Choose_Instructor.aspx");
        }

        protected void ESch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Exam_Schedule.aspx");
        }

        protected void Pay_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void GP_Click(object sender, EventArgs e)
        {
            Response.Redirect("Graduation_Plan.aspx");
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Choices.aspx");            
        }

        protected void LO_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}