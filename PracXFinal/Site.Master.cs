using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracXFinal
{
    public partial class shop1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String admin = Convert.ToString(Session["AdminValue"]);
            int trigger = Convert.ToInt32(Request.QueryString["logoutid"]);

            if (trigger == -1)
            {
                Session["LoggedInId"] = null;
            }



            if (Session["LoggedInId"] != null)
            {
                logout.Visible = true;
                login.Visible = false;
                signup.Visible = false;

                if (admin.Equals("Manager"))
                {
                    add.Visible = true;
                    edit.Visible = true;
                    remove.Visible = true;
                }


            }
        }
    }
}