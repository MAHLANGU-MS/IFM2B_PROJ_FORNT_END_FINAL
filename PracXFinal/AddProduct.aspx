<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="PracXFinal.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row" runat="server">

					<div class="col-md-7" runat="server">
						<!-- Billing Details -->
						<div class="billing-details" runat="server">
							<div class="section-title">
								<h3 class="title">Add Product</h3>
							</div>
							<div class="form-group">
								<input class="input" type="text" name="pname" placeholder="Product Name" id="pname" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="imagelink" placeholder="Product Description" id="pdesc" required="required" runat="server">
							</div>
							<div class="form-group" runat="server">
								<input class="input" type="text" name="pid" placeholder="Product Category" id="pcat" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="pname" placeholder="Product Rating" id="prat" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="imagelink" placeholder="Product Quantity" id="pquant" required="required" runat="server">
							</div>
							<div class="form-group" runat="server">
								<input class="input" type="text" name="pid" placeholder="Product Price" id="pprice" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="pname" placeholder="Product Old Price" id="poprice" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="imagelink" placeholder="Product Status" id="pstatus" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="imagelink" placeholder="Image link" id="imagelink" required="required" runat="server">
							</div>
							
							
							
						</div>
						<!-- /Billing Details -->

						<!-- <a href="#" class="primary-btn order-submit">Register</a> -->
						
						<asp:Button ID="btnAddP" runat="server" Text="Add product" href="#" class="primary-btn order-submit"/>
							
						
					</div>

					
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

</asp:Content>
