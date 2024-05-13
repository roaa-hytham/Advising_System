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
    public partial class Student_Transcript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection con = new SqlConnection(connStr);

            //Create a SQL command
            SqlCommand cmd = new SqlCommand("select * from Students_Courses_transcript", con);

            //Open the connection
            con.Open();

            //Create a data reader
            SqlDataReader rd = cmd.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Student ID</th><th>First Name</th><th>Last Name</th>" +
                "<th>Course Name</th><th>Exam Type</th><th>Grade</th><th>Semester Code</th></tr>");

            //Loop through the data reader
            while (rd.Read())
            {
                //Get the data from the columns
                string student_id = rd["student_id"].ToString();
                string FirstName = rd["f_name"].ToString();
                string LastName = rd["l_name"].ToString();
                string name = rd["name"].ToString();
                string exam_type = rd["exam_type"].ToString();
                string grade = rd["grade"].ToString();
                string semester_code = rd["semester_code"].ToString();


                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + student_id + "</td>");
                Response.Write("<td>" + FirstName + "</td>");
                Response.Write("<td>" + LastName + "</td>");
                Response.Write("<td>" + name + "</td>");
                Response.Write("<td>" + exam_type + "</td>");
                Response.Write("<td>" + grade + "</td>");
                Response.Write("<td>" + semester_code + "</td>");

                Response.Write("</tr>");
            }

            //Close the data reader
            rd.Close();

            //Close the connection
            con.Close();

            //End the table
            Response.Write("</table>");
        }
    }
}