<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllProducts.aspx.cs" Inherits="PracXFinal.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="section">

	<div class="container allprods">
		<div class="row">
	
			<div id="aside" class="col-md-3">
						<!-- aside Widget -->
						<div class="aside">
							<h3 class="aside-title">Categories</h3>
							<div class="checkbox-filter">

							

								<div class="input-checkbox">
									<input type="checkbox" id="category-6">
									<label for="category-6">
										<span></span>
										Smartphones
										<small>(740)</small>
									</label>
								</div>
							</div>
						</div>
						<!-- /aside Widget -->
				</div>
	<div id="store" class="col-md-9" >

	<div class="store-filter clearfix">
							<div class="store-sort">
								<label>
									Sort By:
									<select class="input-select">
										<option value="0">Name</option>
										<option value="1">Price</option>
									</select>
								</label>
							</div>
						</div>
	<div class="row" id="all_prods" runat="server" >

		<div  class="col-md-4 col-xs-6">
			<div class="product">
				<div class="product-img">
					<img src="./img/product01.png" alt="">
					<div class="product-label">
						<span class="sale">-30%</span>
						<span class="new">NEW</span>
					</div>
				</div>		
				<div class="product-body">
					<p class="product-category">Category</p>
					<h3 class="product-name"><a href="#">product name goes here</a></h3>
					<h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>
												
					<div class="product-btns">
						<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">add to wishlist</span></button>
						<button class="quick-view"><a href="SingleProduct.aspx"><i class="fa fa-eye"></i><span class="tooltipp">view product</span></a></button>
					</div>
				</div>
				<div class="add-to-cart">
					<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> add to cart</button>
				</div>
			</div>
		</div>

	</div>
	</div> 
		</div>
	</div>
	</div>

</asp:Content>
