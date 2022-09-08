using PracXFinal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracXFinal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString!=null && Request.QueryString.Count>0)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                pid.Value = "" + id;
            }
            
        }

        protected void btnFindProduct_Click(object sender, EventArgs e)
        {

            if (pid.Value!=null)
            {
            int id = Convert.ToInt32(pid.Value);
            var p = sr.getProduct(id);

                pname.Value = "" + p.PrName;
                pdesc.Value = "" + p.PrDescription;
                pcat.Value = "" + p.PrCategory;
                prat.Value = "" + p.PrRating;
                pquant.Value = "" + p.PrQuantity;
                pprice.Value = "" + p.PrPrice;
                poprice.Value = "" + p.PrOldPrice;
                pstatus.Value = "" + p.PrStatus;
                imagelink.Value = "" + p.PrImage;


                pname.Visible = true;
                pdesc.Visible = true;
                pcat.Visible = true;
                prat.Visible = true;
                pquant.Visible = true;
                pprice.Visible = true;
                poprice.Visible = true;
                pstatus.Visible = true;
                imagelink.Visible = true;
                btnEditP.Visible = true;


            }
            else
            {
                error.Text = "Please enter an Product ID";
            }
            


        }
    }
}