using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class ChI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }

        protected void Ch_Click(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection connection = new SqlConnection(connStr);
                int StudentID = Int16.Parse(Session["user_id"].ToString());
                int instrucorID = Int16.Parse(Iid.Text.ToString());
                int CourseID = Int16.Parse(Cid.Text.ToString());
                String current_semester_code = CurrSem.Text.ToString();
                SqlCommand Chooseinstructor = new SqlCommand("Procedures_Chooseinstructor", connection);
                Chooseinstructor.CommandType = CommandType.StoredProcedure;
                Chooseinstructor.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                Chooseinstructor.Parameters.Add(new SqlParameter("@instrucorID", instrucorID));
                Chooseinstructor.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                Chooseinstructor.Parameters.Add(new SqlParameter("@current_semester_code", current_semester_code));
                connection.Open();
                Chooseinstructor.ExecuteNonQuery();
                connection.Close();
                Response.Write("Done");
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}