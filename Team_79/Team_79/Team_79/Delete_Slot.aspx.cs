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
    public partial class Delete_Slot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deleteSlot(object sender, EventArgs e)//can i just change from Delete_Slot to deleteSlot
        {

        }

        protected void button_delete_Slot(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                string current_semester = user_delete_slot.Text;

                SqlCommand delete_slot_proc = new SqlCommand("Procedures_AdminDeleteSlots", conn);
                delete_slot_proc.CommandType = CommandType.StoredProcedure;


                SqlParameter p = new SqlParameter("@current_semester", current_semester);
                delete_slot_proc.Parameters.Add(p);

                conn.Open();
                delete_slot_proc.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }
    }
}