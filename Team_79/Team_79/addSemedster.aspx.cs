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
    public partial class addSemedster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addSemester_Click(object sender, EventArgs e)
        {
            try 
            { 
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                DateTime start_d = DateTime.Parse(start.Text);
                DateTime end_d = DateTime.Parse(end.Text);
                String sem_code = semester_code.Text;

                SqlCommand addSem = new SqlCommand("AdminAddingSemester", conn);
                addSem.CommandType = CommandType.StoredProcedure;
                addSem.Parameters.Add("@start_date", start_d);
                addSem.Parameters.Add("@end_date", end_d);
                addSem.Parameters.Add("@semester_code", sem_code);


                conn.Open();
                addSem.ExecuteNonQuery();
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