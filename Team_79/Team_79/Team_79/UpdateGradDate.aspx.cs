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
    public partial class UpdateGradDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            DateTime expectedGradDate = DateTime.Parse(expectedGradDateTextBox.Text);
            int studentId = int.Parse(studentIdTextBox.Text);

            // Assuming conn is your SqlConnection object
            using (SqlCommand Procedures_AdvisorUpdateGP = new SqlCommand("Procedures_AdvisorUpdateGP", conn))
            {
                Procedures_AdvisorUpdateGP.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Procedures_AdvisorUpdateGP.Parameters.AddWithValue("@expected_grad_date", expectedGradDate);
                Procedures_AdvisorUpdateGP.Parameters.AddWithValue("@studentID", studentId);

                conn.Open();
                Procedures_AdvisorUpdateGP.ExecuteNonQuery();
                Response.Write("Grad date updated successfully!");
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}