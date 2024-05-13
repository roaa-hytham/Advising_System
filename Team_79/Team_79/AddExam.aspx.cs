using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class AddExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button_add_exam(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                string type_exam = type.Text;
                DateTime date_exam = DateTime.Parse(date.Text);
                int courseID = Int16.Parse(course.Text);

                if(type_exam.Equals("Normal") || type_exam.Equals("First_makeup") || type_exam.Equals("Second_makeup"))
                {
                    SqlCommand add_exam_proc = new SqlCommand("Procedures_AdminAddExam", conn);
                    add_exam_proc.CommandType = CommandType.StoredProcedure;

                    add_exam_proc.Parameters.Add(new SqlParameter("@Type", type_exam));
                    add_exam_proc.Parameters.Add(new SqlParameter("@date", date_exam));
                    add_exam_proc.Parameters.Add(new SqlParameter("@courseID", courseID));

                    conn.Open();
                    add_exam_proc.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Exam is Added");
                }
                else
                {
                    Response.Write("Invalid exam type! Exam type should be either Normal, First_makeup or Second_makeup");
                }
                

            }

            catch (Exception ex)
            {
                    Response.Write(ex.Message);
                
            }
                        

         
            


        }
    }
}