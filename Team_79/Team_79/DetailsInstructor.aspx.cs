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
    public partial class DetailsInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewInstructors = new SqlCommand("select * from Instructors_AssignedCourses", conn);
            

            conn.Open();
            viewInstructors.ExecuteNonQuery();

            
            SqlDataReader dr = viewInstructors.ExecuteReader();

            
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>instructor ID</th><th>Instructor</th><th>course ID</th><th>Course</th></tr>");

            while (dr.Read())
            {
                //Get the data from the columns
                int instructor_id = (int)dr["instructor_id"];
                string Instructor = dr["Instructor"].ToString();
                string course_id = dr["course_id"].ToString();
                string Course = dr["Course"].ToString();
                

                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + instructor_id + "</td>");
                Response.Write("<td>" + Instructor + "</td>");
                Response.Write("<td>" + course_id + "</td>");
                Response.Write("<td>" + Course + "</td>");
                Response.Write("</tr>");
            }

            
            dr.Close();


            conn.Close();
            //End the table
            Response.Write("</table>");

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminPage.aspx");
        }
    }
}