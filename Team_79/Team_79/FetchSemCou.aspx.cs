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
    public partial class FetchSemCou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection con = new SqlConnection(connStr);

            //Create a SQL command
            SqlCommand cmd = new SqlCommand("select * from Semster_offered_Courses", con);

            //Open the connection
            con.Open();

            //Create a data reader
            SqlDataReader rd = cmd.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Course ID</th><th>Course Name</th><th>Semester Code</th></tr>");

            //Loop through the data reader
            while (rd.Read())
            {
                //Get the data from the columns
                string course_id = rd["course_id"].ToString();
                string name = rd["name"].ToString();
                string semester_code = rd["semester_code"].ToString();




                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + course_id + "</td>");
                Response.Write("<td>" + name + "</td>");
                Response.Write("<td>" + semester_code + "</td>");


                Response.Write("</tr>");

            }
        }
    }
}