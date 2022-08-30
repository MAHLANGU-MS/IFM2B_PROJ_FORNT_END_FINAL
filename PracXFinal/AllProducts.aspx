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
										E-Books
										<small></small>
									</label>
								</div>
									<div class="input-checkbox">
									<input type="checkbox" id="category-5">
									<label for="category-5">
										<span></span>
										Novels
										<small></small>
									</label>
								</div>
								<div class="input-checkbox">
									<input type="checkbox" id="category-4">
									<label for="category-4">
										<span></span>
										AudioBooks
										<small></small>
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

		

	</div>
	</div> 
		</div>
	</div>
	</div>

</asp:Content>
