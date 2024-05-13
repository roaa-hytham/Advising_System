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
    public partial class Issue_Installments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_issue_inst_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                int payment_id = Int16.Parse(paym_id.Text);

                SqlCommand issue_installment_proc = new SqlCommand("Procedures_AdminIssueInstallment", conn);
                issue_installment_proc.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@payment_id", payment_id);
                issue_installment_proc.Parameters.Add(p);

                conn.Open();
                issue_installment_proc.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }
    }
}