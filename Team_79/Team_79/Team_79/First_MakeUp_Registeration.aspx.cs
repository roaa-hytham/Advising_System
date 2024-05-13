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
    public partial class FMR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RFM_Click(object sender, EventArgs e)
        {
            //Response.Redirect("First_Register_Approval.aspx");
            //Response.Redirect("First_Register_Rejection.aspx");
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                /*@StudentID int, 
                 * @courseID int, 
                 * @studentCurr_sem varchar(40)*/

                int StudentID = Int16.Parse(Session["user_id"].ToString());
                int courseID = Int16.Parse(Cid.Text);
                String studentCurr_sem = CurrSem.Text;
                String exam = "";

                SqlCommand cmd = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                cmd.Parameters.Add(new SqlParameter("@courseID", courseID));
                cmd.Parameters.Add(new SqlParameter("@studentCurr_sem", studentCurr_sem));

                cmd.ExecuteNonQuery();
                conn.Close();
                /*if (rows == 0)
                {
                    Response.Write("No rows were updated");
                }
                else
                {
                    Response.Write("Rows were updated");
                }*/

                conn.Open();
                SqlCommand check = new SqlCommand("select exam_type from Student_Instructor_Course_take where student_id =@StudentID", conn);
                check.Parameters.AddWithValue("@StudentID", StudentID);
                SqlDataReader rdr = check.ExecuteReader();

                while (rdr.Read())
                {
                    exam = rdr.GetString(rdr.GetOrdinal("exam_type"));
                }

                if (exam.Equals("first_makeup"))
                {
                    Response.Write("Registeration Accepted!");
                }
                else
                {
                    Response.Write("Registeration Failed. ");
                    Response.Write("You are not eligible for make-up registeration.");
                }

                rdr.Close();
                check.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }
    }
}