using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_79
{
    public partial class Choices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        public void Phones(object sender, EventArgs e) {
            Response.Redirect("phone.aspx");

        }
        public void optional(object sender, EventArgs e)
            {
            Response.Redirect("optional.aspx");
        }
        public void available(object sender, EventArgs e)
            {
            Response.Redirect("available.aspx");

        }
        public void required(object sender, EventArgs e)
            {
            Response.Redirect("required.aspx");

        }
        public void missing (object sender, EventArgs e)
            {
            Response.Redirect("missing.aspx");

        }
        public void courses(object sender, EventArgs e)
            {
            Response.Redirect("courses.aspx");

        }
        public void credit(object sender, EventArgs e)
                {
            Response.Redirect("credit.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Main2.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}