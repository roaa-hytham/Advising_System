using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using Microsoft.SqlServer.Server;

namespace Team_79
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        public void signout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
        public void create(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                
                int semester1 = Int32.Parse(semester.Text);
                String major1 = (major.Text).ToString();
                String password1 = (password.Text).ToString();
                String faculty1 = (faculty.Text).ToString();
                String last1 = (last.Text).ToString();
                String first1 = (first.Text).ToString();
                String email1 = (email.Text).ToString();

                SqlCommand cmd = new SqlCommand("Procedures_StudentRegistration", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@first_name", first1);
                cmd.Parameters.AddWithValue("@last_name", last1);
                cmd.Parameters.AddWithValue("@password", password1);
                cmd.Parameters.AddWithValue("@faculty", faculty1);
                cmd.Parameters.AddWithValue("@email", email1);
                cmd.Parameters.AddWithValue("@major", major1);
                cmd.Parameters.AddWithValue("@Semester", semester1);
                cmd.Parameters.Add("@Student_id", SqlDbType.Int);
                cmd.Parameters["@Student_id"].Direction = ParameterDirection.Output;

                //SqlDataReader reader = cmd.ExecuteReader();
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                // Storing the output parameters' values in three different variables.
                String s_id = Convert.ToString(cmd.Parameters["@Student_id"].Value);
                //Response.Write(reader.Read().ToString());
                Response.Write("This is your ID: ");

                Response.Write(s_id);
                Session["user_id"] = s_id;
              

                cmd.Dispose();
                conn.Close();

            }

        
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {

                    conn.Close();
                }
            }
        }

    }
}