<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_productos" %>

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
            
            <div class="col-md-12  rounded">
                <h3 >Mantenedor Productos </h3>
                <div>
                    <asp:Label runat="server" ID="Label0">Nombre Producto</asp:Label>
                    <asp:TextBox ID="txtNombrePrododucto"  MaxLength="50" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />


                <div>

                    <asp:Label runat="server" ID="Label1">Tipo Producto</asp:Label>
                    <asp:DropDownList ID="ddlTipoProducto" runat="server" CssClass="texto"></asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label2">Stock </asp:Label>
                    <asp:TextBox ID="txtStock" onKeyPress="return soloNumeros(event)" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label3">Valor(precio)</asp:Label>
                    <asp:TextBox ID="txtPrecio" onKeyPress="return soloNumeros(event)" CssClass=" texto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label5">Descripcion</asp:Label>
                    <asp:TextBox ID="txtDescripcion" CssClass="texto" required="true" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label4">Imagen Producto</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />
                </div>
                <br />

                <div>
                    <asp:Button ID="btnGuardarProducto" runat="server" Text="Guardar producto" CssClass="botton-register" OnClick="btnGuardarProducto_Click" />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
