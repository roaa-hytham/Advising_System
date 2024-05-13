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
    public partial class SMR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RSM_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean flag = false;
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                int StudentID= Int16.Parse(Session["user_id"].ToString());
                int courseID = Int16.Parse(Cid.Text);
                String studentCurr_sem = CurrSem.Text;

               SqlCommand cmd = new SqlCommand("select dbo.FN_StudentCheckSMEligibility(@CourseID,@StudentID) as out", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseID);
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Boolean check = rdr.GetBoolean(rdr.GetOrdinal("out"));
                    if (check == true)
                    {
                        flag= true;
                    }
                    else
                    {
                        Response.Write("Registeration unavailable!");
                    }
                }
                rdr.Close();
                cmd.Dispose();
                conn.Close();

                if (flag == true)
                {
                    SqlCommand cmdr = new SqlCommand("Procedures_StudentRegisterSecondMakeup", conn);
                    cmdr.CommandType = CommandType.StoredProcedure;

                    /*@StudentID int, 
                     * @courseID int, 
                     * @studentCurr_sem varchar(40)*/

                    cmdr.Parameters.Add(new SqlParameter("@StudentID", StudentID));
                    cmdr.Parameters.Add(new SqlParameter("@courseID", courseID));
                    cmdr.Parameters.Add(new SqlParameter("@studentCurr_sem", studentCurr_sem));

                    conn.Open();
                    cmdr.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Registeration Accepted!");
                }
            }catch(Exception ex)
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