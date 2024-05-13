using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Common;
using System.Drawing;

namespace Team_79
{
    public partial class CPD : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from view_Course_prerequisites", conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                /*course_id int primary key identity, 
                name varchar(40),
                major varchar(40), 
                is_offered bit, 
                credit_hours int,
                semester int
                C2.course_id as preRequsite_course_id
                C2.name as preRequsite_course_name*/

                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Course ID</th><th>Course Name</th>" +
                    "<th>Major</th><th>Offered</th><th>Credit Hours</th><th>Semester</th>" +
                    "<th>Pre-requsite Course ID</th><th>Pre-requsite Course Name</th></tr>");

                while (rdr.Read())
                {
                    int course_id = Int16.Parse(rdr["course_id"].ToString());
                    string name = rdr["name"].ToString();
                    string major = rdr["major"].ToString();
                    Boolean is_offered = Boolean.Parse(rdr["is_offered"].ToString());
                    int credit_hours = Int16.Parse(rdr["credit_hours"].ToString());
                    int semester = Int16.Parse(rdr["semester"].ToString());
                    int preRequsite_course_id = Int16.Parse(rdr["preRequsite_course_id"].ToString());
                    string preRequsite_course_name = rdr["preRequsite_course_name"].ToString();

                    Response.Write("<tr>");
                    Response.Write("<td>" + course_id + "</td>");
                    Response.Write("<td>" + name + "</td>");
                    Response.Write("<td>" + major + "</td>");
                    Response.Write("<td>" + is_offered + "</td>");
                    Response.Write("<td>" + credit_hours + "</td>");
                    Response.Write("<td>" + semester + "</td>");
                    Response.Write("<td>" + preRequsite_course_id + "</td>");
                    Response.Write("<td>" + preRequsite_course_name + "</td>");
                    Response.Write("</tr>");
                }

                rdr.Close();
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