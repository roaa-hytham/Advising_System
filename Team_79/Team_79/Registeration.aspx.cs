using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }

        protected void FMR_Click(object sender, EventArgs e)
        {
            Response.Redirect("First_MakeUp_Registeration.aspx");
        }

        protected void SMR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Second_MakeUp_Registeration.aspx");
        }
    }
}