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
    public partial class View_GradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Advisors_Graduation_Plan
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection con = new SqlConnection(connStr);

            //Create a SQL command
            SqlCommand cmd = new SqlCommand("select * from Advisors_Graduation_Plan", con);

            //Open the connection
            con.Open();

            //Create a data reader
            SqlDataReader rd = cmd.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Plan ID</th><th>Semester Code</th><th>Semester Credit Hours</th>" +
                "<th>Expected Grade Date</th><th>Advisor ID</th><th>Student ID</th><th>Advisor ID</th><th>Advisor Name</th></tr>");

            //Loop through the data reader
            while (rd.Read())
            {
                //Get the data from the columns
                string PlanID = rd["plan_id"].ToString();
                string semester_code = rd["semester_code"].ToString();
                string semester_credit_hours = rd["semester_credit_hours"].ToString();
                string expected_grad_date = rd["expected_grad_date"].ToString();
                string advisor_id = rd["advisor_id"].ToString();
                string student_id = rd["student_id"].ToString();
                string AdvisorID = rd["AdvisorID"].ToString();
                string advisor_name = rd["advisor_name"].ToString();
             


                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + PlanID + "</td>");
                Response.Write("<td>" + semester_code + "</td>");
                Response.Write("<td>" + semester_credit_hours + "</td>");
                Response.Write("<td>" + expected_grad_date + "</td>");
                Response.Write("<td>" + advisor_id + "</td>");
                Response.Write("<td>" + student_id + "</td>");
                Response.Write("<td>" + AdvisorID + "</td>");
                Response.Write("<td>" + advisor_name + "</td>");
 

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