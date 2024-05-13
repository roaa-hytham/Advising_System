using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Drawing;

namespace Team_79
{
    public partial class available : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void signout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
        public void create(object sender, EventArgs e)
        {
            //Response.Write("BEFORE");

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            //Response.Write("BEFORE");
            
            try
            {

                string courses = semester.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FN_SemsterAvailableCourses(@semstercode)", conn);
                // cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@semstercode", courses);
                 //Open the connection
                conn.Open(); //Create a data reader

                //Create a data reader
                SqlDataReader dr = cmd.ExecuteReader();

                //Display the data in an HTML table
                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Course Name</th><th>Course ID</th></tr>");

                //Loop through the data reader
                while (dr.Read())
                {
                    //Get the data from the columns
                    string name = dr["name"].ToString();
                    string idd = dr["course_id"].ToString();

                    //Write the data in a table row
                    Response.Write("<tr>");
                    Response.Write("<td>" + name + "</td>");
                    Response.Write("<td>" + idd + "</td>");
                   
                    Response.Write("</tr>");
                }

                //Close the data reader
                dr.Close();
                cmd.Dispose();
                //Close the connection

                //End the table
                Response.Write("</table>");


            }
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {

                    conn.Close();
                }
            }
        }



        public void back(object sender, EventArgs e)
        {
            Response.Redirect("Choices.aspx");
        }
    }
}
