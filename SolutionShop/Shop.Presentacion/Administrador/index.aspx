<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shop.Presentacion.Administrador.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Micospore - Administrador </title>
    <link rel="shortcut icon" href="img/logo_micospore_white.jpg">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container fondo">
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-3">
                
                <br />
                <asp:HiddenField ID="hiddenInfo" runat="server" />
               
            </div>
            <div class="col-md-7">

                <%--<iframe  id="iframe1" src="<% = Url %>" width="100%" height="100%"></iframe>--%>


            </div>
        </div>

    </div>
</asp:Content>
