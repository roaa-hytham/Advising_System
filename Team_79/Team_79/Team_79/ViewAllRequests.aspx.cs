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
    public partial class ViewAllRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int advisor_Id = Int16.Parse(advisorID.Text);

            SqlCommand FN_Advisors_Requests = new SqlCommand("FN_Advisors_Requests", conn);
            //FN_Advisors_Requests.CommandType = System.Data.CommandType.StoredProcedure;
            FN_Advisors_Requests.Parameters.Add(new SqlParameter("@advisor_id", advisor_Id));

            // Use a SqlDataAdapter for the function call
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FN_Advisors_Requests(@advisor_id)", conn);
            da.SelectCommand.Parameters.AddWithValue("@advisor_id", advisor_Id);


            DataTable dt = new DataTable();

            conn.Open();

            da.Fill(dt);

            // Check if there are rows
            if (dt.Rows.Count > 0)
            {
                // Process the results row by row
                foreach (DataRow row in dt.Rows)
                {
                    // Access columns by name or index
                    int requestId = Convert.ToInt32(row["request_id"]);
                    string type = row["type"].ToString();
                    string comment = row["comment"] == DBNull.Value ? null : row["comment"].ToString();
                    string status = row["status"].ToString();
                    int creditHours = row["credit_hours"] == DBNull.Value ? 0 : Convert.ToInt32(row["credit_hours"]);
                    int courseId = row["course_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["course_id"]);
                    int studentId = row["student_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["student_id"]);
                    int advisorId = row["advisor_id"] == DBNull.Value ? 0 : Convert.ToInt32(row["advisor_id"]);

                    // Process the data as needed
                    Response.Write($"Request ID: {requestId}, Type: {type}, Comment: {comment}, Status: {status}, Credit Hours: {creditHours}, Course ID: {courseId}, Student ID: {studentId}, Advisor ID: {advisorId}<br>");
                }
            }
            else
            {
                // Handle the case where there are no rows
                Response.Write("No results found.");
            }

            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
            

    
}