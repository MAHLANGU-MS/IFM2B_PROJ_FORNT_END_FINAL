<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="PracXFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		 <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

		<title>Book Mart</title>

		<!-- Google font -->
		<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

		<!-- Bootstrap -->
		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>

		<!-- Slick -->
		<link type="text/css" rel="stylesheet" href="css/slick.css"/>
		<link type="text/css" rel="stylesheet" href="css/slick-theme.css"/>

		<!-- nouislider -->
		<link type="text/css" rel="stylesheet" href="css/nouislider.min.css"/>

		<!-- Font Awesome Icon -->
		<link rel="stylesheet" href="css/font-awesome.min.css">

		<!-- Custom stlylesheet -->
		<link type="text/css" rel="stylesheet" href="css/style.css"/>

		<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body>
	<form id="form1" runat="server">

	<!-- HEADER -->
		<header>
			<!-- TOP HEADER -->
			<div id="top-header">
				<div class="container">
					<ul class="header-links pull-left">
						<li><a href="#"><i class="fa fa-phone"></i> +27 234 567 890</a></li>
						<li><a href="#"><i class="fa fa-envelope-o"></i> bookmart@bookmart.com</a></li>
						<li><a href="#"><i class="fa fa-map-marker"></i> 1734 BookMart Road</a></li>
					</ul>
					<ul class="header-links pull-right">
						<li><a href="#"><i class="fa fa-user-o"></i>Login/Sign Up</a></li>
					</ul>
				</div>
			</div>
			<!-- /TOP HEADER -->

			<!-- MAIN HEADER -->
			<div id="header">
				<!-- container -->
				<div class="container">
					<!-- row -->
					<div class="row">
						<!-- LOGO -->
						<div class="col-md-3">
							<div class="header-logo">
								<a href="index.aspx" class="logo">
									<img src="./img/newnewnewlogo.png" alt="">
								</a>
							</div>
						</div>
						<!-- /LOGO -->

						
					</div>
					<!-- row -->
				</div>
				<!-- container -->
			</div>
			<!-- /MAIN HEADER -->
		</header>
		<!-- /HEADER -->

		<!-- BREADCRUMB -->
		<div id="breadcrumb" class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<div class="col-md-12">
						<h3 class="breadcrumb-header">Register</h3>
						<ul class="breadcrumb-tree">
							<li><a href="#">Home</a></li>
							<li class="active">Log In/Register</li>
						</ul>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /BREADCRUMB -->

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
						
						<asp:Button ID="btnReg" runat="server" Text="Register" href="#" class="primary-btn order-submit" OnClick="btnReg_Click"/>
							
						<!-- Already have an account -->
						<div class="row">
					<div class="col-md-12">
						<div class="newsletter">
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

    
        
    </form>
</body>
</html>
