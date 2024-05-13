using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class View_Payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection con = new SqlConnection(connStr);

                //Create a SQL command
           SqlCommand cmd = new SqlCommand("select * from Student_Payment", con);

            //Open the connection
            con.Open();

            //Create a data reader
            SqlDataReader rd = cmd.ExecuteReader();

            //Display the data in an HTML table
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Student ID</th><th>First Name</th><th>Last Name</th>" +
                "<th>Payment ID</th><th>Amount</th><th>Start date</th><th>deadline</th><th>No. of installemnts</th>" +
                "<th>Fund percentage</th><th>Status</th><th>Student ID</th><th>Semester Code</th></tr>");

            //Loop through the data reader
            while (rd.Read())
            {
                //Get the data from the columns
                string StudentID = rd["StudentID"].ToString();
                string FirstName = rd["f_name"].ToString();
                string LastName = rd["l_name"].ToString();
                string PaymentID = rd["payment_id"].ToString();
                string Amount = rd["amount"].ToString();
                string Start_date = rd["startdate"].ToString();
                string deadline = rd["deadline"].ToString();
                string n_installments = rd["n_installments"].ToString();
                string fund_percentage = rd["fund_percentage"].ToString();
                string status = rd["status"].ToString();
                string student_id = rd["student_id"].ToString();
                string semester_code = rd["semester_code"].ToString();


                //Write the data in a table row
                Response.Write("<tr>");
                Response.Write("<td>" + StudentID + "</td>");
                Response.Write("<td>" + FirstName + "</td>");
                Response.Write("<td>" + LastName + "</td>");
                Response.Write("<td>" + PaymentID + "</td>");
                Response.Write("<td>" + Amount + "</td>");
                Response.Write("<td>" + Start_date + "</td>");
                Response.Write("<td>" + deadline + "</td>");
                Response.Write("<td>" + n_installments + "</td>");
                Response.Write("<td>" + fund_percentage + "</td>");
                Response.Write("<td>" + status + "</td>");
                Response.Write("<td>" + student_id + "</td>");
                Response.Write("<td>" + semester_code + "</td>");

                Response.Write("</tr>");
            }

            //Close the data reader
            rd.Close();

            //Close the connection
            con.Close();

            //End the table
            Response.Write("</table>");
        }

        //protected void Button_stud_paym_Click(object sender, EventArgs e)
        //{
            //string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            //using (SqlConnection conn = new SqlConnection(connStr))
           // {

               // SqlCommand viewPaym = new SqlCommand("Select * from Student_Payment", conn);
                //conn.Open();

               // viewPaym.CommandType = CommandType.Text;

               // SqlDataReader reader = viewPaym.ExecuteReader();

               // while (reader.Read())
                //{
               //     Console.WriteLine(reader.GetString(1));
                //}

           // }
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
        //}
    }
}