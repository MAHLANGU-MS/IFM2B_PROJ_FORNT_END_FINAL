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

            foreach(ServiceReference1.Product product in prod)
            {
                display += "<div class='product'>";
                display += "<div class='product-img'>";
                display += "<img src='./img/product01.png' alt=''>";
                display += "<div class='product-label'>";
                display += "</div>";
                display += "</div>";
                display += "<div class='product-body'>";
                display += "<p class='product-category'>Category</p>";
                display += "<h3 class='product-name'><a href='#'>product name goes here</a></h3>";
                display += "<h4 class='product-price'>$980.00 <del class='product-old-price'>$990.00</del></h4>";
                display += "<div class='product-btns'>";
                display += "<button class='add-to-wishlist'><i class='fa fa-heart-o'><i><span class='tooltipp'>add to wishlist</span></button>";
                display += "</div>";
                display += "</div>";
                display += "</div>";

            }

            all_prods.InnerHtml = display;
		}
    }
}