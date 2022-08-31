using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracXFinal.ServiceReference1;

namespace PracXFinal
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {

            Service1Client sr = new Service1Client();

            if (pass.Value == repass.Value)
            {

                if (pass.Value == repass.Value)
                {

                    var newUser = new User
                    {
                        Name = fname1.Value + " " + lname.Value,
                        Email = email.Value,
                        Password = pass.Value,
                        UserType = type.Value
                    };

                    int result = sr.register(newUser);

                    if (result == 1)
                    {
                        Response.Redirect("login.aspx");

                    }
                    else if (result == -1)
                    {
                        //user not added 
                        //    reg_failed.Visible = true;
                    }
                    else if (result == 0)
                    {
                        //user already exists
                        //
                    }
                }


                //int result = sr.register(fname1.Value, lname.Value, email.Value, pass.Value, type.Value);

                //    if (result == 1)
                //    {
                //        Response.Redirect("login.aspx");

                //    }
                //    else if (result == -1)
                //    {

                //        //user not added 

                //    }

                }
        }

    }
}