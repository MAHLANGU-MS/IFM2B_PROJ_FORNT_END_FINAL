using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracXFinal.ServiceReference1;

namespace PracXFinal
{

    public partial class WebForm1 : System.Web.UI.Page
    {
    Service1Client sr = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
			string display = "";

            dynamic prod = sr.getAllProducts().ToList();

            foreach(ServiceReference1.Product p in prod)
            {

                display += "<div class='product'>";
                display += "<div class='product-img'>";
                display += "<img src='" + p.PrImage + "' alt=''>";
                display += "<div class='product-label'>";
                display += "</div>";
                display += "</div>";
                display += "<div class='product-body'>";
                display += "<p class='product-category'>Category</p>";
                display += "<h3 class='product-name'><a href='#'>" + p.PrName + "</a></h3>";
                display += "<h4 class='product-price'> R " + String.Format("{0:0.00}", p.PrPrice) + "<del class='product-old-price'>R " + String.Format("{0:0.00}", p.PrOldPrice) + "</del></h4>";
                display += "<div class='product-rating'>";

                display += "</div>";
                display += "<div class='product-btns'>";
                display += "<button class='add-to-wishlist'><i class='fa fa-heart-o'></i><span class='tooltipp'>add to wishlist</span></button>";
                display += "</div>";
                display += "</div>";
                //display += "<div class='add-to-cart'>";
                //display += "<button class='add-to-cart-btn'><i class='fa fa-shopping-cart'></i> add to cart</button>";
                //display += "</div>";
                display += "</div>";

            }

            all_prods.InnerHtml = display;
        }
    }
}