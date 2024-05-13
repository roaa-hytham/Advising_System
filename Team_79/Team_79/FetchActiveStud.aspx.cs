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
    public partial class FetchActiveStud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //view_Students
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection con = new SqlConnection(connStr);

            //Create a SQL command
            SqlCommand cmd = new SqlCommand("select * from view_Students", con);

            //Open the connection
            con.Open();

            //Create a data reader
            SqlDataReader rd = cmd.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Student ID</th><th>First Name</th><th>Last Name</th>" +
                "<th>Password</th><th>GPA</th><th>Faculty</th><th>Email</th><th>Major</th>" +
                "<th>Financial Status</th><th>Acquired Hours</th><th>Assigned Hours</th><th>Advisor ID</th></tr>");

            //Loop through the data reader
            while (rd.Read())
            {
                //Get the data from the columns
                string StudentID = rd["student_id"].ToString();
                string FirstName = rd["f_name"].ToString();
                string LastName = rd["l_name"].ToString();
                string password = rd["password"].ToString();
                string gpa = rd["gpa"].ToString();
                string faculty = rd["faculty"].ToString();
                string email = rd["email"].ToString();
                string major = rd["major"].ToString();
                string financial_status = rd["financial_status"].ToString();
                string semester = rd["semester"].ToString();
                string acquired_hours = rd["acquired_hours"].ToString();
                string assigned_hours = rd["assigned_hours"].ToString();
                string advisor_id = rd["advisor_id"].ToString();



                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + StudentID + "</td>");
                Response.Write("<td>" + FirstName + "</td>");
                Response.Write("<td>" + LastName + "</td>");
                Response.Write("<td>" + password + "</td>");
                Response.Write("<td>" + gpa + "</td>");
                Response.Write("<td>" + faculty + "</td>");
                Response.Write("<td>" + email + "</td>");
                Response.Write("<td>" + major + "</td>");
                Response.Write("<td>" + financial_status + "</td>");
                Response.Write("<td>" + acquired_hours + "</td>");
                Response.Write("<td>" + assigned_hours + "</td>");
                Response.Write("<td>" + advisor_id + "</td>");

                Response.Write("</tr>");
            }
        }
    }
}