<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-tipos-productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_tipos_productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
    <%--<link href="../css/style.css" rel="stylesheet" />--%>
    <div class="container mantenedor" style="padding-top: 2em; padding-bottom: 2em;">
        <div class="row ">
            <h3 style="color: black;">Mantenedor tipo producto </h3>
            <div class="col-md-12  rounded">

                <div>
                    <asp:Label runat="server" ID="lblasda">Nombre tipo producto</asp:Label>
                    <asp:TextBox ID="txtNombreTipoProd" MaxLength="50" CssClass=" texto" placeholder="Ingrese nombre tipo producto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label5">Descripcion</asp:Label>
                    <asp:TextBox ID="txtDescripcion" CssClass="texto" required="true" placeholder="Ingrese descripción máximo 500 carácteres" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label runat="server" ID="Label1">Estado</asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="texto">
                    </asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label4">Imagen Tipo Producto</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />
                </div>
                <br />

                <div>
                    <asp:Button ID="btnAgregar" runat="server" CssClass="botton-register" Text="Guardar" OnClick="btnAgregar_Click" />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
