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
    public partial class ViewAssignedStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int advisor_Id = Int16.Parse(advisorID.Text);
            string major = majorTextBox.Text;

            SqlCommand Procedures_AdvisorViewAssignedStudents = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
            Procedures_AdvisorViewAssignedStudents.CommandType = System.Data.CommandType.StoredProcedure;
            Procedures_AdvisorViewAssignedStudents.Parameters.Add(new SqlParameter("@AdvisorID", advisor_Id));
            Procedures_AdvisorViewAssignedStudents.Parameters.Add(new SqlParameter("@major", major));

            conn.Open();

            using (SqlDataReader reader = Procedures_AdvisorViewAssignedStudents.ExecuteReader())
            {
                while (reader.Read())
                {
                    int studentId = Convert.ToInt32(reader["student_id"]);
                    string studentName = reader["Student_name"].ToString();
                    string studentMajor = reader["major"].ToString();
                    string courseName = reader["Course_name"].ToString();

                    // Process the data as needed
                    // Example: 
                    Response.Write($"Student ID: {studentId}, Student Name: {studentName}, Major: {studentMajor}, Course Name: {courseName}<br>");
                }
            }

            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}