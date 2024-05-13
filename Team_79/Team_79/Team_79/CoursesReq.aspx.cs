using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Team_79
{
    public partial class CoursesReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int requestId = int.Parse(requestIdTextBox.Text);
            string currentSemesterCode = currentSemesterCodeTextBox.Text;

            // Assuming conn is your SqlConnection object
            using (SqlCommand Procedures_AdvisorApproveRejectCourseRequest = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn))
            {
                Procedures_AdvisorApproveRejectCourseRequest.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Procedures_AdvisorApproveRejectCourseRequest.Parameters.AddWithValue("@requestID", requestId);
                Procedures_AdvisorApproveRejectCourseRequest.Parameters.AddWithValue("@current_semester_code", currentSemesterCode);

                conn.Open();
                Procedures_AdvisorApproveRejectCourseRequest.ExecuteNonQuery();
                Response.Write("Status updated successfully!");
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}