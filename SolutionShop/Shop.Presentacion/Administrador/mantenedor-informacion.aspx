<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-informacion.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- <div class= "container">
        <div class=" row">
            <div class=" col-12 ">
                 <h3 style="color: white;">Mantenedor producto </h3>
            </div>
        </div>
    </div>--%>



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

    <div class="container  mantenedor">
        <div class="row ">

            <div class="col-md-12 rounded">
                <h3 style="color: black">Mantenedor Información</h3>
                <div>
                    <asp:Label runat="server" ID="lblasda">Nombre </asp:Label>
                    <asp:TextBox ID="txtNombre" placeholder="Nombre información" MaxLength="100" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label6">Título </asp:Label>
                    <asp:TextBox ID="txtTitulo" placeholder="Nombre título" MaxLength="100" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />


                <div>
                    <asp:Label runat="server" ID="Label1">Tipo Información</asp:Label>
                    <asp:DropDownList ID="ddlTipoInfo" runat="server" CssClass="texto"></asp:DropDownList>
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
                    <asp:Label runat="server" ID="Label4">Imagen Información</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />
                </div>
                <br />

                <div>
                    <asp:Button ID="btnGuardarInfo" CssClass="botton-register" runat="server" Text="Guardar" OnClick="btnGuardarInfo_Click" />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>
                <a href="informacion.aspx">volver</a>
            </div>

            
        </div>
    </div>

</asp:Content>
