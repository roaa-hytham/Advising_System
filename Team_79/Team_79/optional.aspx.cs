using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Team_79
{
    public partial class optional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void back(object sender, EventArgs e)
        {
            Response.Redirect("Choices.aspx");
        }
        public void signout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
        public void create(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                
                int id = (int)Session["user_id"];
                String current = (semester.Text).ToString();
                SqlCommand cmd = new SqlCommand("Procedures_ViewOptionalCourse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", (int)Session["user_id"]);
                cmd.Parameters.AddWithValue("@current_semester_code", current);

                conn.Open();
                
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                
                Response.Write("<table border='1'>");
                Response.Write("<tr><th>Course ID</th><th>Name</th></tr>");

                
                while (dr.Read())
                {
                    string c = dr["course_id"].ToString();
                    string d = dr["name"].ToString();

                    Response.Write("<tr>");
                    Response.Write("<td>" +  c + "</td>");
                    Response.Write("<td>" + d + "</td>");
                    Response.Write("</tr>");
                }

                dr.Close();


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

        //Response.Redirect("Login.aspx");

    }
    }
