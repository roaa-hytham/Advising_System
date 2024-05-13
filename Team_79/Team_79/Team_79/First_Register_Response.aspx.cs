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
    public partial class First_Register_Response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from FN_StudentViewGP(@student_ID)", conn);
                cmd.Parameters.AddWithValue("@student_ID", Session["user_id"]);
                SqlDataReader rdr = cmd.ExecuteReader();

                /*Student.f_name +' '+ Student.l_name as Student_name 
                plan_id int not null identity(1,1),
                semester_code varchar(40) not null, 
                semester_credit_hours int,
                expected_grad_date date,
                advisor_id int,
                student_id int,
                GradPlan_Course.course_id, 
                Course.name
                */

                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Student Name</th><th>Plan ID</th>" +
                    "<th>Semester</th><th>Semester Credit Hours</th>" +
                    "<th>Expected Graduation Date</th><th>Advisor ID</th>" +
                    "<th>Student ID</th><th>Course ID</th><th>Course Name</th></tr>");

                while (rdr.Read())
                {
                    string Student_name = rdr["Student_name"].ToString();
                    int plan_id = Int16.Parse(rdr["plan_id"].ToString());
                    string semester_code = rdr["semester_code"].ToString();
                    int semester_credit_hours = Int16.Parse(rdr["semester_credit_hours"].ToString());
                    DateTime expected_grad_date = DateTime.Parse(rdr["expected_grad_date"].ToString());
                    int advisor_id = Int16.Parse(rdr["advisor_id"].ToString());
                    int student_id = Int16.Parse(rdr["student_id"].ToString());
                    int course_id = Int16.Parse(rdr["course_id"].ToString());
                    string name = rdr["name"].ToString();

                    Response.Write("<tr>");
                    Response.Write("<td>" + Student_name + "</td>");
                    Response.Write("<td>" + plan_id + "</td>");
                    Response.Write("<td>" + semester_code + "</td>");
                    Response.Write("<td>" + semester_credit_hours + "</td>");
                    Response.Write("<td>" + expected_grad_date + "</td>");
                    Response.Write("<td>" + advisor_id + "</td>");
                    Response.Write("<td>" + student_id + "</td>");
                    Response.Write("<td>" + course_id + "</td>");
                    Response.Write("<td>" + name + "</td>");
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