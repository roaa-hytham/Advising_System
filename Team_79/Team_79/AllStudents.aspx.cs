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
    public partial class AllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewStudents = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            viewStudents.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            viewStudents.ExecuteNonQuery();

            //Create a data reader
            SqlDataReader dr = viewStudents.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>student id</th><th>first name</th><th>last name</th><th>advisor ID</th><th>advisor name</th></tr>");

            //Loop through the data reader
            while (dr.Read())
            {
                //Get the data from the columns
                int student_id = (int)dr["student_id"];
                string f_name = dr["f_name"].ToString();
                string l_name = dr["l_name"].ToString();
                string advisor_id = dr["advisor_id"].ToString();
                string advisor_name = dr["advisor_name"].ToString();

                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + student_id + "</td>");
                Response.Write("<td>" + f_name + "</td>");
                Response.Write("<td>" + l_name + "</td>");
                Response.Write("<td>" + advisor_id + "</td>");
                Response.Write("<td>" + advisor_name + "</td>");
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