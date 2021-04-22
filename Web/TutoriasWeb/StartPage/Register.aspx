<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar - Tutorias</title>
    <meta charset="UTF-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>

    <script src="FillTxt.js"></script>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/inete.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
<!--===============================================================================================-->

</head>
<body>
        <div class="limiter">
		<div class="container-login100" style="background-image: url('images/background.jpg');">
			<div class="wrap-login100">
				<form class=""  runat="server">
					<span class="login100-form-logo">
						<img src="images/icons/logo.png" alt="INETE Logo" />
					</span>

					<span class="login100-form-title p-b-34 p-t-27">
						Criar Conta
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Enter username">
                        <asp:TextBox class="input100" ID="txt_username" placeholder="Utilizador*" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Enter name">
                        <asp:TextBox class="input100" ID="txt_nome" placeholder="Nome*" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Enter Turma">
                        <asp:TextBox class="input100" ID="txt_turma" placeholder="Turma*" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Enter Birthdate">
                        <asp:TextBox class="input100 FillDate" ID="txt_dataNasc" placeholder="Data de Nascimento*" OnClick="FillDate()" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf095;"></span>	
					</div>
					

					<div class="wrap-input100 validate-input">
                        <asp:TextBox class="input100 FillPhone" ID="txt_movel" placeholder="Telefone" OnClick="FillPhone()" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf2b9;"></span>
					</div>				
					

					<div class="wrap-input100 validate-input">
                        <asp:TextBox class="input100" ID="txt_morada" placeholder="Morada" runat="server"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<asp:TextBox class="input100" ID="txt_pass" placeholder="Palavra Passe*" runat="server" TextMode="Password"></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf191;"></span>
					</div>

					<!-- Meter um estilo na ddl -->
                    <asp:DropDownList ID="ddl_tipo" runat="server"></asp:DropDownList>


					<div class="container-login100-form-btn">
                        <asp:Button class="login100-form-btn" ID="btn_register" runat="server" Text="Registrar" OnClick="btn_register_Click" />
						<!--<button class="login100-form-btn">
							Login
						</button>-->
					</div>

					<div id="errorOut" runat="server">

					</div>
					<div class="text-center p-t-90">
						<a class="txt1" href="Login.aspx">
							Já tem conta? Efetue o login aqui!
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
</body>
</html>
