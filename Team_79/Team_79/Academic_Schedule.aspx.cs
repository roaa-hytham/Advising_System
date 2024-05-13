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
    public partial class AS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }

        protected void View_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                int CourseID = Int16.Parse(Cid.Text);
                int InstructorID = Int16.Parse(Iid.Text);

                SqlCommand cmd = new SqlCommand("select * from dbo.FN_StudentViewSlot(@CourseID, @InstructorID)", conn);
                
                cmd.Parameters.AddWithValue("@CourseID", CourseID);
                cmd.Parameters.AddWithValue("@InstructorID", InstructorID);

                SqlDataReader rdr = cmd.ExecuteReader();

                /*Course.course_id as CourseID , 
                 Course.name As Course, 
                 slot_id int primary key, 
                day varchar(40),
                time varchar(40), 
                location varchar(40), 
                course_id int Foreign key references course(course_id)  on update cascade on delete cascade,
                instructor_id
                Instructor.name as Instructor
                */

                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Course ID</th><th>Course Name</th>" +
                    "<th>Slot ID</th><th>Day</th><th>Time</th><th>Location</th>" +
                    "<th>Instructor ID</th><th>Instructor Name</th></tr>");

                while (rdr.Read())
                {
                    int cID = Int16.Parse(rdr["CourseID"].ToString());
                    string Course = rdr["Course"].ToString();
                    int slot_id = Int16.Parse(rdr["slot_id"].ToString());
                    string day = rdr["day"].ToString();
                    string time = rdr["time"].ToString();
                    string location = rdr["location"].ToString();
                    int instructor_id = Int16.Parse(rdr["instructor_id"].ToString());
                    string Instructor = rdr["Instructor"].ToString();

                    Response.Write("<tr>");
                    Response.Write("<td>" + cID + "</td>");
                    Response.Write("<td>" + Course + "</td>");
                    Response.Write("<td>" + slot_id + "</td>");
                    Response.Write("<td>" + day + "</td>");
                    Response.Write("<td>" + time + "</td>");
                    Response.Write("<td>" + location + "</td>");
                    Response.Write("<td>" + instructor_id + "</td>");
                    Response.Write("<td>" + Instructor + "</td>");
                    Response.Write("</tr>");
                }

                rdr.Close();
                cmd.Dispose();
                conn.Close();
                Response.Write("</table>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}