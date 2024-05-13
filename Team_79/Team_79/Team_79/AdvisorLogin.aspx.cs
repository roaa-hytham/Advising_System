using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class AdvisorLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adlogin(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int advisor_Id = Int16.Parse(advisorID.Text);
            String password = advisorPassword.Text;
            Boolean success = false;

            SqlCommand FN_AdvisorLogin = new SqlCommand("select dbo.FN_AdvisorLogin (@advisor_Id, @password) as out", conn);
            FN_AdvisorLogin.Parameters.Add(new SqlParameter("@advisor_Id", advisor_Id));
            FN_AdvisorLogin.Parameters.Add(new SqlParameter("@password", password));

            conn.Open();
            SqlDataReader rdr = FN_AdvisorLogin.ExecuteReader();

            while (rdr.Read())
            {
                success = rdr.GetBoolean(rdr.GetOrdinal("out"));
            }

            rdr.Close();
            FN_AdvisorLogin.Dispose();

            conn.Close();

            if (success == true)
            {
                Response.Write("logged in");
                Response.Redirect("AdvisorMain.aspx");
            }
            else if (success == false)
            {
                Response.Write("wrong username or password. Try again");
            }
            else
            {
                Response.Write("idk bro");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}