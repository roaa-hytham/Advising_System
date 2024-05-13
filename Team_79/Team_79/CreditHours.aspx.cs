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
    public partial class CreditHours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int requestId = int.Parse(requestIdTextBox.Text);
            string currentSemCode = currentSemCodeTextBox.Text;

            // Assuming conn is your SqlConnection object
            using (SqlCommand Procedures_AdvisorApproveRejectCHRequest = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn))
            {
                Procedures_AdvisorApproveRejectCHRequest.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Procedures_AdvisorApproveRejectCHRequest.Parameters.AddWithValue("@requestID", requestId);
                Procedures_AdvisorApproveRejectCHRequest.Parameters.AddWithValue("@current_sem_code", currentSemCode);

                conn.Open();
                Procedures_AdvisorApproveRejectCHRequest.ExecuteNonQuery();
                Response.Write("Updated status successfully.");
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}