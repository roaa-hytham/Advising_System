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
    public partial class AdvisorReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string advisorName = advisorNameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            string office = officeTextBox.Text;

            // Assuming conn is your SqlConnection object
            using (SqlCommand Procedures_AdvisorRegistration = new SqlCommand("Procedures_AdvisorRegistration", conn))
            {
                Procedures_AdvisorRegistration.CommandType = CommandType.StoredProcedure;

                // Add parameters
                SqlParameter advisorNameParam = Procedures_AdvisorRegistration.Parameters.Add("@advisor_name", SqlDbType.VarChar, 20);
                advisorNameParam.Value = advisorName;

                SqlParameter passwordParam = Procedures_AdvisorRegistration.Parameters.Add("@password", SqlDbType.VarChar, 20);
                passwordParam.Value = password;

                SqlParameter emailParam = Procedures_AdvisorRegistration.Parameters.Add("@email", SqlDbType.VarChar, 50);
                emailParam.Value = email;

                SqlParameter officeParam = Procedures_AdvisorRegistration.Parameters.Add("@office", SqlDbType.VarChar, 20);
                officeParam.Value = office;

                // Output parameter
                SqlParameter advisorIdParam = Procedures_AdvisorRegistration.Parameters.Add("@Advisor_id", SqlDbType.Int);
                advisorIdParam.Direction = ParameterDirection.Output;

                conn.Open();
                Procedures_AdvisorRegistration.ExecuteNonQuery();

                // Retrieve the output parameter value after execution
                int advisorId = (int)advisorIdParam.Value;

                Response.Write("Registered!");

                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorMain.aspx");
        }
    }
}