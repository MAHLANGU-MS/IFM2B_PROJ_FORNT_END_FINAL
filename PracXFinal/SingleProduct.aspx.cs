using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracXFinal.ServiceReference1;

namespace PracXFinal
{
    public partial class SingleProduct : System.Web.UI.Page
    {
        int id ;
		Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        { 

			string display = "";

			id = Convert.ToInt32(Request.QueryString["Id"]);

			var p = sr.getProduct(id);

            display += "<div class='col-md-6'>";
            display += "<div id='product-main-img'>";
            display += "<div class='product-preview sing_prod'>";
            display += "<img src='" + p.PrImage + "' alt=''>";
            display += "</div>";

            //display += "<div class='product-preview'>";
            //display += "<img src='./img/product03.png' alt=''>";
            //display += "</div>";

            //display += "<div class='product-preview'>";
            //display += "<img src='./img/product06.png' alt=''>";
            //display += "</div>";

            ////				<div class="product-preview">
            ////					<img src = "./img/product08.png" alt="">
            ////				</div>
            display += "</div>";
            display += "</div>";

            display += "<div class='col-md-6 sing_prod'>";
            display += "<div class='product-details'>";
            display += "<h2 class='product-name'>"+p.PrName+"</h2>";
            display += "<div>";
            display += "<div class='product-rating'>";

            display += "</div>";

            display += "</div>";
            display += "<div>";
            display += "<h3 class='product-price'> R " + Math.Round(p.PrPrice,2) + "<del class='product-old-price'>" + p.PrOldPrice + "</del></h3>";
            display += "<span class='product-available'>In Stock</span>";
            display += "</div>";
            display += "<p>" + p.PrDescription + "</p>";

            display += "<div class='product-options'>";

            display += "</div>";

            display += "<div class='add-to-cart'>";
            display += "<div class='qty-label'>";
            display += "Qty";
            display += "<div class='input-number'>";
            display += "<input type='number'>";
            display += "<span class='qty-up'>+</span>";
            display += "<span class='qty-down'>-</span>";
            display += "</div>";
            display += "</div>";
            display += "<button class='add-to-cart-btn'><i class='fa fa-shopping-cart'></i> add to cart</button>";
            display += "</div>";

            display += "<ul class='product-btns'>";
            display += "<li><a href='#'><i class='fa fa-heart-o'></i> add to wishlist</a></li>";
            display += "</ul>";
            display += "</div>";
            display += "</div>";

            single_prod.InnerHtml = display;

            if (Session["AdminValue"] != null)
            {
                if (Session["AdminValue"].Equals("Manager"))
                {
                    btnEditP.Visible = true;
                }
                else
                {
                    btnEditP.Visible = false;
                }
            }
        }

        protected void btnEditP_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProduct.aspx?Id="+id);
        }
    }
}