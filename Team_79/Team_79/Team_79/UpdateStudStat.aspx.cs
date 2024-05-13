using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class UpdateStudStat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_upd_stud_stat_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                int student_id = Int16.Parse(stud_id.Text);

                SqlCommand update_stat_proc = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
                update_stat_proc.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@student_id", student_id);
                update_stat_proc.Parameters.Add(p);

                conn.Open();
                update_stat_proc.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }
    }
}