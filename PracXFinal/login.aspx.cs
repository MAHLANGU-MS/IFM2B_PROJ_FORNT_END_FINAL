using PracXFinal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracXFinal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Service1Client sr = new Service1Client();

            

                User result = sr.Login(email.Value, pass.Value);

            if (result != null)
            {
                Session["LoggedInID"] = result.Id;
                Session["AdminValue"] = result.UserType;
                Response.Redirect("index.aspx");
            }
            else
            {
                //show that they dont have an account
            }
        }
    }
}