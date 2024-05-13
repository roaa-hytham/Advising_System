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
    public partial class SemsterOfferedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewSemester = new SqlCommand("select * from Semster_offered_Courses", conn);


            conn.Open();
            viewSemester.ExecuteNonQuery();


            SqlDataReader dr = viewSemester.ExecuteReader();

            //Course.course_id, Course.name, Semester.semester_code
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>offered course Id</th><th>Offered Course Name</th><th>Semester Code</th></tr>");

            while (dr.Read())
            {
                //Get the data from the columns
                int course_id = (int)dr["course_id"];
                string name = dr["name"].ToString();
                string semester_code = dr["semester_code"].ToString();


                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + course_id + "</td>");
                Response.Write("<td>" + name + "</td>");
                Response.Write("<td>" + semester_code + "</td>");
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