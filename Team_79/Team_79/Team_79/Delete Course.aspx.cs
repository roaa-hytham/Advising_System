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
    public partial class Delete_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deleteCourse_TextChanged(object sender, EventArgs e)
        {
            try{
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int courseID = Int16.Parse(deleteCourseID.Text);

            SqlCommand delete_course_proc = new SqlCommand("Procedures_AdminDeleteCourse", conn);
            delete_course_proc.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@courseID", courseID);
            delete_course_proc.Parameters.Add(p);

            conn.Open();
            delete_course_proc.ExecuteNonQuery();
            conn.Close();
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }

        }
    }
}