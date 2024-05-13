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
    public partial class InsertGradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertPlan_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            string semesterCode = SemCode.Text;
            DateTime expectedGraduationDate = DateTime.Parse(GradDate.Text);
            int semCreditHours = int.Parse(CreditHours.Text);
            int advisorId = int.Parse(AdvisorID.Text);
            int studentId = int.Parse(StudentID.Text);

            using (SqlCommand Procedures_AdvisorCreateGP = new SqlCommand("Procedures_AdvisorCreateGP", conn))
            {
                Procedures_AdvisorCreateGP.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Procedures_AdvisorCreateGP.Parameters.AddWithValue("@Semester_code", semesterCode);
                Procedures_AdvisorCreateGP.Parameters.AddWithValue("@expected_graduation_date", expectedGraduationDate);
                Procedures_AdvisorCreateGP.Parameters.AddWithValue("@sem_credit_hours", semCreditHours);
                Procedures_AdvisorCreateGP.Parameters.AddWithValue("@advisor_id", advisorId);
                Procedures_AdvisorCreateGP.Parameters.AddWithValue("@student_id", studentId);

                conn.Open();
                Procedures_AdvisorCreateGP.ExecuteNonQuery();
                conn.Close();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}