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
    public partial class addCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String cmajor = major.Text;
                String csemester= semester.Text;
                String creditHours = credit_hours.Text;
                String cnmae = name.Text;
                Boolean offered = RadioButtonList1.SelectedValue == "offered" ;
                int is_offered;
                //Response.Write(offered);
                if (offered)
                    is_offered = 1;
                else
                    is_offered = 0;
                SqlCommand addCourse = new SqlCommand("Procedures_AdminAddingCourse", conn);
                addCourse.CommandType = CommandType.StoredProcedure;
                addCourse.Parameters.Add("@major", cmajor);
                addCourse.Parameters.Add("@semester", csemester);
                addCourse.Parameters.Add("@credit_hours", creditHours);
                addCourse.Parameters.Add("@name", cnmae);
                addCourse.Parameters.Add("@is_offered", ""+is_offered);


                if (!offered && RadioButtonList1.SelectedValue != "not offered")
                    Response.Write("please choose offered or not");
                else
                {
                    conn.Open();
                    addCourse.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("adminPage.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}