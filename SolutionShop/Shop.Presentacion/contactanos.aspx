<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contactanos.aspx.cs" Inherits="Shop.Presentacion.contactanos" %>

<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- <link rel="icon" type="image/png" href="img/icons/favicon.ico" />
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
    <link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
    <link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
    <link rel="stylesheet" type="text/css" href="css/util.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <link rel="shortcut icon" href="img/logo_micospore_white.jpg">--%>



    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- font-awesome icons -->
    <link href="css/font-awesome.css" rel="stylesheet">
    <!-- //font-awesome icons -->
    <!-- js -->
    <script src="js/jquery-1.11.1.min.js"></script>
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Raleway:400,100,100italic,200,200italic,300,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <!-- start-smoth-scrolling -->
    <script type="text/javascript" src="js/move-top.js"></script>
    <script type="text/javascript" src="js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
    </script>
    <title>Micospore - Contacto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- <style>
        .fondo {
            
        }

        .fondo2 {
            background-color: white;
        }
    </style>
    
    <div class="container py-2 fondo">

        <div class="row ">
            <div class="col-lg-4 col-md-3">
            </div>
            <div class="col-lg-4 col-md-6 border border-dark rounded py-1 fondo2">
                <br />
                <div class="form-group">
                    <label for="exampleFormControlInput1">Nombre</label><br />
                    <asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="Ingrese nombre completo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Favor ingrese nombre" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlInput1">Email</label>
                    <asp:TextBox ID="txtEmail" class="form-control" TextMode="Email" runat="server" placeholder="Ingrese correo electrónico"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Favor ingrese correo electrónico" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>

                <div class="form-group">
                    <label for="exampleFormControlInput1">Fecha de Nacimiento</label>
                    <asp:TextBox ID="txtFechaNacimiento" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfFecha" runat="server" ForeColor="Red" ErrorMessage="Favor ingrese fecha de nacimiento" ControlToValidate="txtFechaNacimiento"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label for="exampleFormControlTextarea1">Realiza tus consultas</label>
                    <asp:TextBox ID="txtComentarios" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfComentarios" runat="server" ErrorMessage="Favor ingrese comentario" ControlToValidate="txtComentarios" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group" style="text-align: center">
                    <asp:Button ID="btnEnviar" CssClass="login100-form-btn" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Purple"></asp:Label>
                </div>

            </div>
            <div class="col-lg-4 col-md-3">
            </div>
        </div>


    </div>--%>


    <div class="breadcrumbs">
        <%--<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Contacto</li>
			</ol>
		</div>--%>
    </div>
    <!-- //breadcrumbs -->
    <!-- contact -->
    <div class="about">
        <div class="w3_agileits_contact_grids">

            <div class="col-md-12 w3_agileits_contact_grid_right">
                <h2 class="w3_agile_header"><span>Contáctanos</span></h2>

                <span class="input input--ichiro">
                    <label for="exampleFormControlInput1">Nombre completo</label>
                    <asp:TextBox ID="txtNombre" class="form-control" runat="server" CssClass="contactanos" placeholder="Nombre completo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Favor ingrese nombre" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                </span>
                <span class="input input--ichiro">
                    <label for="exampleFormControlInput1">Email</label>
                    <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="contactanos" runat="server" placeholder="E-mail"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Favor ingrese correo electrónico" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                </span>

                <span class="input input--ichiro">
                    <label for="exampleFormControlInput1">Fecha de Nacimiento</label>
                    <asp:TextBox ID="txtFechaNacimiento" CssClass="contactanos" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfFecha" runat="server" ForeColor="Red" ErrorMessage="Favor ingrese fecha de nacimiento" ControlToValidate="txtFechaNacimiento"></asp:RequiredFieldValidator>
                </span>
                <%--<span class="input input--ichiro">
                    <input class="input__field input__field--ichiro" type="email" id="input-26" name="Email" placeholder=" " required="true" />
                    <label class="input__label input__label--ichiro" for="input-26">
                        <span class="input__label-content input__label-content--ichiro">Your Email</span>
                    </label>
                </span>--%>
                <%--<textarea name="Message" placeholder="Your message here..." required=""></textarea>--%>
                  <asp:TextBox ID="txtComentarios" runat="server" CssClass="contactanos" placeholder="Tu mensaje aquí..."  TextMode="MultiLine" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfComentarios" runat="server" ErrorMessage="Favor ingrese comentario" ControlToValidate="txtComentarios" ForeColor="Red"></asp:RequiredFieldValidator>
                <%--<input type="submit" value="Enviar">--%>

                <%--<asp:Button ID="btnEnviar" CssClass="login100-form-btn" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />--%>
                <asp:Button ID="btnEnviar" CssClass="button" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Purple"></asp:Label>

            </div>
            <div class="clearfix"></div>
        </div>
    </div>
    <!-- contact -->
</asp:Content>
