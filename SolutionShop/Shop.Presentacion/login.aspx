<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Shop.Presentacion.login" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <title>Micospore - Login</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
   <%-- <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="img/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="css/util.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">--%>
    <!--===============================================================================================-->
</head>
 
        
    
<body>
        <div>
        </div>
        <div class="limiter">
            <div class="container-login100">
                <div class="wrap-login100">
                    <form class="login100-form validate-form" runat="server">
                        <span class="login100-form-title p-b-34">Cuenta MICOSPORE
                        </span>

                        <div class="wrap-input100 rs1-wrap-input100 validate-input m-b-20" data-validate="Type user name">
                            <asp:TextBox ID="txtusername" class="input100" runat="server" type="text" placeholder="Nombre "></asp:TextBox>
                            <span class="focus-input100"></span>
                        </div>
                        <div class="wrap-input100 rs2-wrap-input100 validate-input m-b-20" data-validate="Type password">
                            <asp:TextBox ID="txtpass" class="input100" runat="server" type="password" placeholder="Contraseña "></asp:TextBox>
                            <span class="focus-input100"></span>
                        </div>

                        <div class="container-login100-form-btn">

                            <asp:Button ID="btnLoginIngresar" class="login100-form-btn" runat="server" Text="Ingresar" OnClick="btnLoginIngresar_Click" />
                            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </div>

                        <div class="w-full text-center p-t-27 p-b-239">
                            <span class="txt1">Olvidaste
                            </span>

                            <a href="#" class="txt2">Usuario / Constrase&ntilde;a
                            </a>
                        </div>

                        <div class="w-full text-center">
                            <a href="#" class="txt3">Sign Up
                            </a>
                        </div>
                       
                    </form>

                    <div class="login100-more" style="background-image: url('img/img-login-1.jpg');" onclick="javascript:redireccion();"></div>
                   
                </div>
            </div>
        </div>


        <div id="dropDownSelect1"></div>

      <%--  <!--===============================================================================================-->
        <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
        <!--===============================================================================================-->
        <script src="vendor/animsition/js/animsition.min.js"></script>
        <!--===============================================================================================-->
        <script src="vendor/bootstrap/js/popper.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
        <!--===============================================================================================-->
        <script src="vendor/select2/select2.min.js"></script>--%>
<%--        <script>
            $(".selection-2").select2({
                minimumResultsForSearch: 20,
                dropdownParent: $('#dropDownSelect1')
            });

            function redireccion() {
                window.location.href = "index.aspx";
            }
        </script>--%>
        <!--===============================================================================================-->
        <script src="vendor/daterangepicker/moment.min.js"></script>
        <script src="vendor/daterangepicker/daterangepicker.js"></script>
        <!--===============================================================================================-->
        <script src="vendor/countdowntime/countdowntime.js"></script>
        <!--===============================================================================================-->
        <script src="js/main.js"></script>
</body>
</html>
