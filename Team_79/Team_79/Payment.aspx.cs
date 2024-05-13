using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr= WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection= new SqlConnection(connStr);
            connection.Open();
            try
            {
                int student_ID= Int16.Parse(Session["user_id"].ToString());
                DateTime date= DateTime.Now;
                var com = connection.CreateCommand();
                com.CommandText = "select dbo.FN_StudentUpcoming_installment (@student_ID) as out";
                com.Parameters.AddWithValue("@student_ID", student_ID);
                SqlDataReader rdr= com.ExecuteReader();

                while (rdr.Read())
                {
                    date = rdr.GetDateTime(rdr.GetOrdinal("out"));
                    Response.Write("Last unpaid installment deadline is on ");
                    Response.Write(date);
                }

                rdr.Close();
                com.Dispose();
                connection.Close();
            }
            catch(Exception ex)
            {
                Response.Write("All Paid!");
            }
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }
    }
}