using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracXFinal
{
    public partial class Login : System.Web.UI.Page
    {

        //connect service here
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            if(pass.Value == repass.Value)
            {
                //sr has not been created yet 
                /*bool result = sr.register(fname.Value, lname.Value, email.Value, pass.Value);

                if(result == true)
                {
                    Response.Redirect("login.aspx");

                }*/
            }
        }
    }
}