using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class LinkStudentToAdvisor : System.Web.UI.Page
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

                int Student = Int16.Parse(student_id.Text);
                int Advisor = Int16.Parse(advisor_id.Text);

                SqlCommand cmd = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@studentID", Student);
                cmd.Parameters.Add("@advisorID", Advisor);
                


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