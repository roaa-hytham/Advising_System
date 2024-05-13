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
    public partial class InsertCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int studentId = int.Parse(studentIdTextBox.Text);
            string semesterCode = semesterCodeTextBox.Text;
            string courseName = courseNameTextBox.Text;

            using (SqlCommand Procedures_AdvisorAddCourseGP = new SqlCommand("Procedures_AdvisorAddCourseGP", conn))
            {
                Procedures_AdvisorAddCourseGP.CommandType = CommandType.StoredProcedure;

                Procedures_AdvisorAddCourseGP.Parameters.AddWithValue("@student_id", studentId);
                Procedures_AdvisorAddCourseGP.Parameters.AddWithValue("@Semester_code", semesterCode);
                Procedures_AdvisorAddCourseGP.Parameters.AddWithValue("@course_name", courseName);

                conn.Open();
                Procedures_AdvisorAddCourseGP.ExecuteNonQuery();
                Response.Write("Course inserted successfully!");
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}