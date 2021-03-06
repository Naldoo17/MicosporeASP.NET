﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="editar-grupo-info.aspx.cs" Inherits="Shop.Presentacion.Administrador.editar_grupo_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   

     <script>
        function soloNumeros(e) {

            var key = window.Event ? e.which : e.keyCode

            return (key >= 48 && key <= 57)

        }
    </script>
    <style>
        .productos {
            background-color: white;
            height: auto;
            width: auto;
        }

        .mydropdownlist {
            color: #fff;
            font-size: 20px;
            padding: 5px 10px;
            border-radius: 5px;
            background-color: #CC2EFA;
            font-weight: bold;
        }
    </style>

    <div class="container mantenedor">
        <div class="row ">

            <div class="col-md-12 rounded">
                <h3 style="color: black">Edición Grupos</h3>
                <div>
                    <asp:Label runat="server" ID="lblasda">Nombre </asp:Label>
                    <asp:TextBox ID="txtNombre" placeholder="Nombre grupo" MaxLength="100" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label6">Título </asp:Label>
                    <asp:TextBox ID="txtTitulo" placeholder="Nombre título" MaxLength="100" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />


                <div>
                    <asp:Label runat="server" ID="Label1">Elija módulo de Información</asp:Label>
                    <asp:DropDownList ID="ddlTipoModuloInfo" runat="server" CssClass="texto"></asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label2">Estado</asp:Label>
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="texto"></asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label5">Descripción</asp:Label>
                    <asp:TextBox ID="txtDescripcion" CssClass="texto" placeholder="Ingrese descripción máximo 500 carácteres" required="true" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label4">Imagen Grupo</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />
                     <asp:HiddenField ID="hdImg" runat="server" />
                    <img src="/<%Response.Write(hdImg.Value.ToString()); %>" width="100px" height="100px" />
                </div>
                <br />

                <div>
                    <asp:Button ID="btnGuardarGrupo" CssClass="botton-register " runat="server" Text="Guardar" OnClick="btnGuardarGrupo_Click"  />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>

            </div>

            <div class="col-md-6">

                <%--<asp:GridView ID="gvInformacion" CssClass="table table-bordered table-hover"  runat="server" AutoGenerateColumns="true" Width="600px" Height="600px"></asp:GridView>--%>
            </div>
        </div>
    </div>

</asp:Content>
