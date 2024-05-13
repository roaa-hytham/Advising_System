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
    public partial class DeleteGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int studentId = int.Parse(studentIdTextBox.Text);
            string semCode = semCodeTextBox.Text;
            int courseId = int.Parse(courseIdTextBox.Text);

            using (SqlCommand Procedures_AdvisorDeleteFromGP = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn))
            {
                Procedures_AdvisorDeleteFromGP.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Procedures_AdvisorDeleteFromGP.Parameters.AddWithValue("@studentID", studentId);
                Procedures_AdvisorDeleteFromGP.Parameters.AddWithValue("@sem_code", semCode);
                Procedures_AdvisorDeleteFromGP.Parameters.AddWithValue("@courseID", courseId);

                conn.Open();
                Procedures_AdvisorDeleteFromGP.ExecuteNonQuery();
                Response.Write("deleted successfully");
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}