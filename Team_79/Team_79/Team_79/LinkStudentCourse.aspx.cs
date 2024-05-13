using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class LinkStudentCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link_Click(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int Course = Int16.Parse(course_id.Text);
                int Instructor = Int16.Parse(instructor_id.Text);
                int Student = Int16.Parse(student_id.Text);
                String semester_code = sem_code.Text;

                SqlCommand cmd = new SqlCommand("Procedures_AdminLinkStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cours_id", Course);
                cmd.Parameters.Add("@instructor_id", Instructor);
                cmd.Parameters.Add("@studentID", Student);
                cmd.Parameters.Add("@semester_code", semester_code);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("adminPage.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}