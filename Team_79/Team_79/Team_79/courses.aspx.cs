using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Team_79
{
    public partial class courses : System.Web.UI.Page
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
                conn.Open();

                int id = (int)Session["user_id"];
                String credit = (course.Text).ToString();
                String type = "course";
                String comment = (commentt.Text).ToString();
                SqlCommand cmd = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", id);
                cmd.Parameters.AddWithValue("@courseID", credit);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.ExecuteNonQuery();
                Response.Write("Your Request was sent successfully!");
                //<p>Enter the Course Id: </p>
                // < p > < asp:TextBox ID = "course" runat = "server" ></ asp:TextBox ></ p >

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