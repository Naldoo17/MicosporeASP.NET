<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="editar-productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.editar_productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>

        function volver() {
            //alert("esta es una alerta de prueba");
            window.history.back();
        }



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

        .auto-style1 {
            width: 30%;
        }

        .auto-style2 {
            width: 70%;
        }
    </style>

    <div class="container mantenedor">

        <div class="row ">
            <br />
   

            <div class="col-md-12 col-lg-12 col-sm-12 ">
                         <h3 >Edición Producto </h3>
                <div class="form-group">
                    <asp:Label runat="server" ID="lblasda">Nombre Producto</asp:Label>
                    <asp:TextBox ID="txtNombrePrododucto" required="true" MaxLength="50" CssClass="texto" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" ID="Label1">Tipo Producto</asp:Label>
                    <asp:DropDownList ID="ddlTipoProducto" runat="server" CssClass="texto"></asp:DropDownList>
                </div>


                <br />
                <%--<div class="col-md-4 col-lg-4 col-sm-12 ">--%>
                <div class="form-group"></div>
                    <asp:Label runat="server" ID="Label3">Valor(precio)</asp:Label>
                    <asp:TextBox ID="txtPrecio" onKeyPress="return soloNumeros(event)" CssClass=" texto" runat="server"></asp:TextBox>
                <%--</div>--%>
                <br />
                <div class="form-group">
                    <asp:Label runat="server" ID="Label5">Descripcion</asp:Label>
                    <asp:TextBox ID="txtDescripcion" CssClass=" texto" required="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <br />
                <div class="form-group">
                    <asp:Label runat="server" ID="Label4">Imagen Producto</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />
                    <asp:HiddenField ID="hdImagen" runat="server" />
                    <img src="/<%Response.Write(hdImagen.Value.ToString()); %>" width="100px" height="100px" />

                </div>
                <br />
                <div class="form-group">
                    <asp:Button ID="btnActualizarProducto" runat="server" Text="Actualizar producto" CssClass="botton-register " OnClick="btnActualizarProducto_Click" />
                     <%--<input type="button" value="volver" onclick="javascript: volver();" class="btn btn-success"></input>--%>
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                </div>
               
            </div>
            <br />
              <%--  <div class="col-md-3 col-lg-3 col-sm-12 ">
            </div>--%>

            <%--<table class="table table-bordered table-hover text-dark text-justify rounded">
                    <tr>
                        <td style="width: 30%">
                            <asp:Label runat="server" ID="lblasda">Nombre Producto</asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:TextBox ID="txtNombrePrododucto" required="true" MaxLength="50" CssClass="texto" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 30%">
                            <asp:Label runat="server" ID="Label1">Tipo Producto</asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:DropDownList ID="ddlTipoProducto" runat="server" CssClass="mydropdownlist"></asp:DropDownList>
                        </td>
                    </tr>


                    <tr>
                        <td style="width: 30%">
                            <asp:Label runat="server" ID="Label3">Valor(precio)</asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:TextBox ID="txtPrecio" CssClass=" texto" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style1">
                            <asp:Label runat="server" ID="Label5">Descripcion</asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtDescripcion" CssClass=" texto" required="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>



                    <tr>
                        <td style="width: 30%">
                            <asp:Label runat="server" ID="Label4">Imagen Producto</asp:Label>
                        </td>
                        <td style="width: 70%">
                            <asp:FileUpload ID="FileUploadImagen" runat="server" />
                            <asp:HiddenField ID="hdImagen" runat="server" />
                            <img src="/<%Response.Write(hdImagen.Value.ToString()); %>" width="100px" height="100px"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnActualizarProducto" runat="server" Text="Actualizar producto" CssClass="btn btn-success" OnClick="btnActualizarProducto_Click" />
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>          

            <%--</div>--%>
        </div>
    </div>

</asp:Content>
