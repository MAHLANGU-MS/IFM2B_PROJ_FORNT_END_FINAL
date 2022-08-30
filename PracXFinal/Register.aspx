<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PracXFinal.Register" %>
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
								<h3 class="title">Register</h3>
							</div>
							<div class="form-group" runat="server">
								<input class="input" type="text" name="fname" placeholder="First Name" id="fname" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="text" name="lname" placeholder="Last Name" id="lname" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="email" name="email" placeholder="Email" id="email" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="password" name="pass" placeholder="Password" id="pass" required="required" runat="server">
							</div>
							<div class="form-group">
								<input class="input" type="password" name="repass" placeholder="Re-enter password" id="repass" required="required" runat="server">
							</div>

							<label for="type">Choose a type:</label>
								<select name="type" id="type" required="required" runat="server">
									<option value="Customer">Customer</option>
									<option value="Manager">Manager</option>
								</select>
							
							
						</div>
						<!-- /Billing Details -->

						<!-- <a href="#" class="primary-btn order-submit">Register</a> -->
						<form id="reguser" runat="server">
							
						<asp:Button ID="btnReg" runat="server" Text="Register" href="#" class="primary-btn order-submit" OnClick="btnReg_Click"/>
						</form>
							
						<!-- Already have an account -->
						<div class="row">
					<div class="col-md-12">
						<div class="newsletter">
							<div id="reg_failed" runat="server" visible="false"><p>Could not sign you up.</p></div>
							<p>Already have an account? <strong><a href="login.aspx"><u>Login here</u></a></strong></p>
						</div>
					</div>
				</div>
						<!-- //Already have an account -->

						

						
					</div>

					
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

</asp:Content>
