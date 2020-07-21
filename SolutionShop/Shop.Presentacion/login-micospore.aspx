<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login-micospore.aspx.cs" Inherits="Shop.Presentacion.login_micospore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Micospore - Login</title>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%

       if (Session["user"] != null && Session["rutUser"] != null && Session["idTipoUser"] != null)
                {
                    string user = (string)Session["user"];
                    string rutUser = (string)Session["rutUser"];
                    string idTipoUser = Session["idTipoUser"].ToString();
                    Redireccionar(user, rutUser, idTipoUser);
                }

        %>

    <div class="login">
        <div class="container">
            <h2>Bienvenido</h2>

            <div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">
                <form>
                    <%--<input type="email" placeholder="Email Address" required=" ">--%>
                    <asp:TextBox ID="txtCorreo"  TextMode="Email" runat="server" placeholder="Correo electrónico" required="true"></asp:TextBox>
                    <%--<input type="password" placeholder="Password" required=" ">--%>
                     <asp:TextBox ID="txtPass" TextMode="Password" runat="server" placeholder="Contraseña" required="true"></asp:TextBox>
                    <div class="forgot">
                        <%--<a href="#">Forgot Password?</a>--%>
                    </div>
                     <asp:Button ID="btnLogin" CssClass="login100-form-btn" runat="server" Text="Ingresar" OnClick="btnLogin_Click"  />
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Purple"></asp:Label>
                    <br />
                    <%--<input type="submit" value="Login">--%>
                </form>
            </div>
            <%--<h4>For New People</h4>--%>
            <%--<p><a href="registered.html">Register Here</a> (Or) go back to <a href="index.html">Home<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>--%>
        </div>
    </div>

</asp:Content>
