using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class AllAdvisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewAdvisors= new SqlCommand("Procedures_AdminListAdvisors", conn);
            viewAdvisors.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            viewAdvisors.ExecuteNonQuery();

            //Create a data reader
            SqlDataReader dr = viewAdvisors.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>advisor_id</th><th>advisor_name</th><th>email</th><th>office</th><th>password</th></tr>");

            //Loop through the data reader
            while (dr.Read())
            {
                //Get the data from the columns
                int advisor_id = (int) dr["advisor_id"];
                string advisor_name = dr["advisor_name"].ToString();
                string email = dr["email"].ToString();
                string office = dr["office"].ToString();
                string password = dr["password"].ToString();

                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + advisor_id + "</td>");
                Response.Write("<td>" + advisor_name + "</td>");
                Response.Write("<td>" + email + "</td>");
                Response.Write("<td>" + office + "</td>");
                Response.Write("<td>" + password + "</td>");
                Response.Write("</tr>");
            }

            //Close the data reader
            dr.Close();


            conn.Close();
            //End the table
            Response.Write("</table>");
            
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminPage.aspx");
        }
    }
}