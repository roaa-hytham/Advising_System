using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class LinkInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link_Click(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int course = Int16.Parse(course_id.Text);
                int Instructor = Int16.Parse(Instructor_id.Text);
                int slot = Int16.Parse(slot_id.Text);

                SqlCommand cmd = new SqlCommand("Procedures_AdminLinkInstructor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cours_id", course);
                cmd.Parameters.Add("@instructor_id", Instructor);
                cmd.Parameters.Add("@slot_id", slot);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("adminPage.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}