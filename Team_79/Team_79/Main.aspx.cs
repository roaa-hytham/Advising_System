using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class Main1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Student_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Advisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorLogin.aspx");
        }

        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login admin.aspx");
        }
    }
}