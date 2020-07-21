<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="editar-tipo-productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.editar_tipo_productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <script>

        function volver() {
            
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
    </style>

    <div class="container mantenedor">
        <div class="row ">
            
            <div class="col-md-12  rounded">
                <h3 style="color: black;">Editar tipo producto </h3>
                <div>
                    <asp:Label runat="server" ID="lblasda">Nombre tipo producto</asp:Label>
                    <asp:TextBox ID="txtNombreTipoProd"  MaxLength="50" CssClass=" texto" placeholder="Ingrese nombre tipo producto" required="true" runat="server"></asp:TextBox>
                </div>
                <br />                            

                <div>
                    <asp:Label runat="server" ID="Label5">Descripcion</asp:Label>
                   <%-- <asp:TextBox ID="txtDescripcion" CssClass="texto" required="true" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>--%>
                     <asp:TextBox ID="txtDescripcionNuevo" CssClass="texto" required="true" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label runat="server" ID="Label1">Estado</asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="texto">                        
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:Label runat="server" ID="Label4">Imagen Tipo Producto</asp:Label>
                    <asp:FileUpload ID="FileUploadImagen" runat="server" />

                    <asp:HiddenField ID="hdImg" runat="server" />
                    <img src="/<%Response.Write(hdImg.Value.ToString()); %>" width="100px" height="100px" />

                </div>
                <br />
 
                <div>
                    <asp:Button ID="btnActualizar" runat="server" CssClass="botton-register" Text="Guardar" OnClick="btnActualizar_Click" />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>

            </div>
        </div>
    </div>


</asp:Content>
