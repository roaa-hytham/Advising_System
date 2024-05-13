using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class ESch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Courses_MakeupExams", conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                /*exam_id int primary key identity,
                date date,
                type varchar(40), 
                course_id int Foreign key references course(course_id)  on update cascade on delete cascade
                 Course.name,
                 Course.semester
                */

                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Exam ID</th><th>Date</th>" +
                    "<th>Type</th><th>Course ID</th><th>Course Name</th><th>Course Semester</th></tr>");

                while (rdr.Read())
                {
                    int exam_id = Int16.Parse(rdr["exam_id"].ToString());
                    DateTime date = DateTime.Parse(rdr["date"].ToString());
                    string type = rdr["type"].ToString();
                    int course_id = Int16.Parse(rdr["course_id"].ToString());
                    string name = rdr["name"].ToString();
                    string semester = rdr["semester"].ToString();

                    Response.Write("<tr>");
                    Response.Write("<td>" + exam_id + "</td>");
                    Response.Write("<td>" + date + "</td>");
                    Response.Write("<td>" + type + "</td>");
                    Response.Write("<td>" + course_id + "</td>");
                    Response.Write("<td>" + name + "</td>");
                    Response.Write("<td>" + semester + "</td>");
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
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }
    }
}