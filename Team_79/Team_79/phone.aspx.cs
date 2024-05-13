using Microsoft.SqlServer.Server;
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
    public partial class phone : System.Web.UI.Page
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
            //Response.Write("BEFORE");
            try
            {

                int id = (int)Session["user_id"];
                String phoneN = (number.Text).ToString();
                bool flag = false;
                foreach (char c in phoneN)
                {
                    if (!char.IsDigit(c))
                    {
                        flag = true;
                        Response.Write("Incorrect Format. Try re-entering only integers");
                        break;
                    }

                }
                if (!flag)
                {
                    SqlCommand cmd = new SqlCommand("Procedures_StudentaddMobile", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", id);
                    cmd.Parameters.AddWithValue("@mobile_number", phoneN);

                    //SqlDataReader reader = cmd.ExecuteReader();
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    //Response.Write(reader.Read().ToString());

                    Response.Write("Phone number added!");

                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

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

        public void back(object sender, EventArgs e)
        {
            Response.Redirect("Choices.aspx");
        }
    }
    }
