<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PedirApoio.aspx.cs" Inherits="DashboardAdmin_CriarUtilizador" %>

<!DOCTYPE html>

<html class="no-js" lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Pedir Apoio - Tutorias</title>
    <meta name="description" content="Apoios - Tutorias">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="apple-touch-icon" href="apple-icon.png">
    <link rel="shortcut icon" href="favicon.ico">


    <link rel="stylesheet" href="vendors/bootstrap/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="vendors/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="vendors/themify-icons/css/themify-icons.css">
    <link rel="stylesheet" href="vendors/flag-icon-css/css/flag-icon.min.css">
    <link rel="stylesheet" href="vendors/selectFX/css/cs-skin-elastic.css">

    <link rel="stylesheet" href="assets/css/style.css">

    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800' rel='stylesheet' type='text/css'>
</head>
<body>
    <!-- Left Panel -->

    <aside id="left-panel" class="left-panel">
        <nav class="navbar navbar-expand-sm navbar-default">

            <div class="navbar-header">
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#main-menu" aria-controls="main-menu" aria-expanded="false" aria-label="Toggle navigation">
                    <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand" href="#">
                    <img src="images/logo.png" alt="Logo"></a>
                <a class="navbar-brand hidden" href="#">
                    <img src="images/logo1.png" alt="Logo"></a>
            </div>

            <div id="main-menu" class="main-menu collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li>
                        <a href="Dashboard.aspx"> <i class="menu-icon fa fa-dashboard"></i>Inicio </a>
                    </li>
                    <h3 class="menu-title">Gest&#227o</h3><!-- /.menu-title -->

                    <li class="menu-item-has-children dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"> <i class="menu-icon fa fa-info-circle"></i>Apoios</a>
                        <ul class="sub-menu children dropdown-menu">
                            <li><i class="menu-icon fa fa-info-circle active"></i><a href="PedirApoio.aspx">Pedir</a></li>
                            <li><i class="menu-icon fa fa-info-circle"></i><a href="HistoricoApoios.aspx">Hist&#243rico/Avaliar</a></li>
                            <li><i class="menu-icon fa fa-info-circle"></i><a href="AnularPedido.aspx">Anular</a></li>
                            <li><i class="menu-icon fa fa-info-circle"></i><a href="AceitarApoio.aspx">Aceitar</a></li>
                        </ul>
                    </li>
                    
                </ul>
            </div>
        </nav>
    </aside>
    <!-- /#left-panel -->

    <!-- Left Panel -->

    <!-- Right Panel -->

    <div id="right-panel" class="right-panel">

        <!-- Header-->
        <header id="header" class="header">

            <div class="header-menu">

                <div class="col-sm-7">
                    <a id="menuToggle" class="menutoggle pull-left"><i class="fa fa fa-tasks"></i></a>
                    <div class="header-left">
                        <!-- Codigo lixo que nao se pode eliminar por causa da estrutura-->
                        <div class="dropdown for-message">

                            <div class="dropdown-menu" aria-labelledby="message">
                                <p class="red">You have 4 Mails</p>
                                <a class="dropdown-item media bg-flat-color-1" href="#">
                                    <span class="photo media-left">
                                        <img alt="avatar" src="images/avatar/1.jpg"></span>
                                    <span class="message media-body">
                                        <span class="name float-left">Jonathan Smith</span>
                                        <span class="time float-right">Just now</span>
                                        <p>Hello, this is an example msg</p>
                                    </span>
                                </a>
                                <a class="dropdown-item media bg-flat-color-4" href="#">
                                    <span class="photo media-left">
                                        <img alt="avatar" src="images/avatar/2.jpg"></span>
                                    <span class="message media-body">
                                        <span class="name float-left">Jack Sanders</span>
                                        <span class="time float-right">5 minutes ago</span>
                                        <p>Lorem ipsum dolor sit amet, consectetur</p>
                                    </span>
                                </a>
                                <a class="dropdown-item media bg-flat-color-5" href="#">
                                    <span class="photo media-left">
                                        <img alt="avatar" src="images/avatar/3.jpg"></span>
                                    <span class="message media-body">
                                        <span class="name float-left">Cheryl Wheeler</span>
                                        <span class="time float-right">10 minutes ago</span>
                                        <p>Hello, this is an example msg</p>
                                    </span>
                                </a>
                                <a class="dropdown-item media bg-flat-color-3" href="#">
                                    <span class="photo media-left">
                                        <img alt="avatar" src="images/avatar/4.jpg"></span>
                                    <span class="message media-body">
                                        <span class="name float-left">Rachel Santos</span>
                                        <span class="time float-right">15 minutes ago</span>
                                        <p>Lorem ipsum dolor sit amet, consectetur</p>
                                    </span>
                                </a>
                            </div>
                        </div>
                        <!-- Fim do codigo lixo-->
                    </div>
                </div>

                <div class="col-sm-5">
                    <div class="user-area dropdown float-right">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            <div id="LoginTextOut" runat="server">
                                
                            </div> 
                        </a>

                        <div class="user-menu dropdown-menu">
                            <a class="nav-link" href="EditPerfil.aspx"><i class="fa fa-cog"></i> Defini&#231&#245es</a>
                            <a class="nav-link" href="../StartPage/Login.aspx"><i class="fa fa-power-off"></i> Sair</a>
                        </div>
                    </div>

                </div>
        </header>
        <!-- /header -->
        <!-- Header-->

        <div class="breadcrumbs">
            <div class="col-sm-4">
                <div class="page-header float-left">
                    <div class="page-title">
                        <h1>Pedir Apoio</h1>
                    </div>
                </div>
            </div>
            <div class="col-sm-8">
                <div class="page-header float-right">
                    <div class="page-title">
                        <ol class="breadcrumb text-right">
                            <li><a href="#">Inicio</a></li>
                            <li><a href="#">Apoios</a></li>
                            <li class="active">Pedir</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>

        <div class="content mt-3">
            <div class="animated fadeIn">
                <div class="card">
                    <div class="card-body card-block">
                        <form runat="server">

                            <div class="form-group">
                                <div id="OutNomeDDL" runat="server"></div>
                                <!--<label class=" form-control-label">Sigla<a style="color:red">*</a></label>-->
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-book"></i></div>
                                    <!--colocar class="form-control-sm form-control" para ocupar o ecra todo-->
                                    <asp:DropDownList ID="ddl_user" runat="server" class="form-control-sm form-control"></asp:DropDownList>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class=" form-control-label">Sigla<a style="color:red">*</a></label>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-book"></i></div>
                                    <!--colocar class="form-control-sm form-control" para ocupar o ecra todo-->
                                    <asp:DropDownList ID="ddl_disc" runat="server" class="form-control-sm form-control"></asp:DropDownList>
                                </div>
                            </div>                            
                                                        
                            <div class="form-group">
                                <label class=" form-control-label">Data do Apoio<a style="color:red">*</a></label>
                                    <div class="input-group">
                                        <div class="input-group-addon"><i class="fa fa-calendar"></i></div>
                                        <asp:TextBox ID="txt_reqDate" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <small class="form-text text-muted">Formato: dd/mm/yyyy</small>
                                </div>

                            <div class="form-group">
                                <label class=" form-control-label">Local<a style="color:red">*</a></label>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-home"></i></div>
                                    <asp:TextBox ID="txt_local" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <small class="form-text text-muted">Ex: Escola, Sala 12</small>
                            </div>                           

                            <div class="form-group">
                                <label class=" form-control-label">Descri&#231&#227o</label>
                                    <div class="input-group">
                                        <div class="input-group-addon"><i class="fa fa-pencil"></i></div>
                                        <asp:TextBox ID="txt_desc" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <small class="form-text text-muted">Ex: Este apoio ir&#225 falar sobre o m&#243dulo 3 de PSI</small>
                                </div>                                                      

                            

                            <br />
                            <div class="form-actions form-group">
                                <asp:Button ID="btn_submit" class="btn btn-success btn-sm" runat="server" Text="Pedir" OnClick="btn_submit_Click"/>
                            </div>

                            <div runat="server" id="ErrorOut">

                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <!-- .animated -->
        </div>
        <!-- .content -->
    </div>
    <!-- /#right-panel -->
    <!-- Right Panel -->


    <script src="vendors/jquery/dist/jquery.min.js"></script>
    <script src="vendors/popper.js/dist/umd/popper.min.js"></script>

    <script src="vendors/jquery-validation/dist/jquery.validate.min.js"></script>
    <script src="vendors/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>

    <script src="vendors/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="assets/js/main.js"></script>
</body>
</html>
