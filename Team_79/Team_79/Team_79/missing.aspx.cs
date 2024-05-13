using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Team_79
{
    public partial class missing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {

                int id = (int)Session["user_id"];


                SqlCommand cmd = new SqlCommand("Procedures_ViewMS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", (int)Session["user_id"]);


                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();




                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Course ID</th><th>Name</th></tr>");

                //Loop through the data reader
                while (dr.Read())
                {
                    //Get the data from the columns
                    string c = dr["course_id"].ToString();
                    string d = dr["name"].ToString();

                    //Write the data in a table row
                    Response.Write("<tr>");
                    Response.Write("<td>" + c + "</td>");
                    Response.Write("<td>" + d + "</td>");
                    Response.Write("</tr>");
                }

                //Close the data reader
                dr.Close();

                //Close the connection
                conn.Close();
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
    }
    }

