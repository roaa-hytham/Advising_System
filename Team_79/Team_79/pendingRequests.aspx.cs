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
    public partial class pendingRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewRequests = new SqlCommand("select * from all_Pending_Requests", conn);
            //viewAdvisors.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            viewRequests.ExecuteNonQuery();

            //Create a data reader
            SqlDataReader dr = viewRequests.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>request id</th><th>type</th><th>comment</th><th>status</th><th>credit_hours</th>" +
                "<th>course_id</th><th>student_id</th><th>advisor_id</th></tr>");
            
            //Loop through the data reader
            while (dr.Read())
            {
                //Get the data from the columns
                int request_id = (int)dr["request_id"];
                string type = dr["type"].ToString();
                string comment = dr["comment"].ToString();
                string status = dr["status"].ToString();
                string credit_hours = dr["credit_hours"].ToString();
                string course_id = dr["credit_hours"].ToString();
                string student_id = dr["student_id"].ToString();
                string advisor_id = dr["advisor_id"].ToString();

                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + request_id + "</td>");
                Response.Write("<td>" + type + "</td>");
                Response.Write("<td>" + comment + "</td>");
                Response.Write("<td>" + status + "</td>");
                Response.Write("<td>" + credit_hours + "</td>");
                Response.Write("<td>" + course_id + "</td>");
                Response.Write("<td>" + student_id + "</td>");
                Response.Write("<td>" + advisor_id + "</td>");
                Response.Write("</tr>");
            }

            //Close the data reader
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