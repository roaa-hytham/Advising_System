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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Button2_Click(object sender, EventArgs e)
        {

        }
        public void register(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");

        }
        public void login(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();

                int id = Int32.Parse(userID.Text);
                string pass = password.Text;
                Session["user_id"] = id;
                int success;
                SqlCommand command = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password) ", conn);
                command.Connection = conn;

             
                command.Parameters.AddWithValue("@Student_id", id);
                command.Parameters.AddWithValue("@password", pass);

                
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string str = dt.Rows[0][0].ToString();
               // Response.Write(str.ToString());                             
                if (str == "True")
                {
                    Response.Redirect("Choices.aspx");
                }
                else
                {
                    Response.Write("Incorrect password or User ID. Please try again.");
                }
                command.Dispose();


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

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }


}
    



