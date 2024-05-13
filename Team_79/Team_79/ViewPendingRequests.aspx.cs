using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class ViewPendingRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void advisorid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void pendingreq_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int advisor_Id = Int16.Parse(advisorid.Text);

            SqlCommand Procedures_AdvisorViewPendingRequests = new SqlCommand("Procedures_AdvisorViewPendingRequests", conn);
            Procedures_AdvisorViewPendingRequests.CommandType = System.Data.CommandType.StoredProcedure;
            Procedures_AdvisorViewPendingRequests.Parameters.Add(new SqlParameter("@Advisor_ID", advisor_Id));

            conn.Open();

            using (SqlDataReader reader = Procedures_AdvisorViewPendingRequests.ExecuteReader())
            {
                while (reader.Read())
                {
                    int requestId = Convert.ToInt32(reader["request_id"]);
                    string type = reader["type"].ToString();
                    string comment = reader["comment"] == DBNull.Value ? null : reader["comment"].ToString();
                    string status = reader["status"].ToString();

                    // Check for DBNull before conversion
                    int creditHours = reader["credit_hours"] == DBNull.Value ? 0 : Convert.ToInt32(reader["credit_hours"]);
                    int courseId = reader["course_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["course_id"]);
                    int studentId = reader["student_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["student_id"]);
                    int advisorId = reader["advisor_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["advisor_id"]);

                    // Process the data as needed
                    // Example: 
                    Response.Write($"Request ID: {requestId}, Type: {type}, Comment: {comment}, Status: {status}, Credit Hours: {creditHours}, Course ID: {courseId}, Student ID: {studentId}, Advisor ID: {advisorId}<br>");
                }
            }

            Procedures_AdvisorViewPendingRequests.ExecuteNonQuery();

            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}