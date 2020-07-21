<%@ Page Title="Productos" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="lista-productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.lista_productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--<title>Micospore - Productos</title>--%>
    <script>
        function Confirmar(id) {

            if (confirm("¿Está seguro de eliminar este tipo de producto?. Esto eliminara los productos asociados a este")) {
                location.href = "ejecutar.aspx?ejecutar=2&idTipo=" + id;
            }
        }



        function SelectAllCheckboxes(spanChk) {
            var xState = spanChk.checked;
            var theBox = spanChk;
            var elm = theBox.form.elements;
            for (i = 0; i < elm.length; i++)
                if (elm[i].type == "radio" && elm[i].id != theBox.id) {
                    elm[i].checked = false;
                }
        }
    </script>
    <script src="~/scripts/jquery-1.10.2.js"></script>


    <link rel="stylesheet" type="text/css" href="//cdn.datatables.net/1.10.12/css/jquery.dataTables.min.css" />
    <script src="//cdn.datatables.net/1.10.12/js/jquery.dataTables.min.js"></script>

    <style>
        .imagenProducto {
            width: 75px;
            height: 75px;
            color: red;
            /*background-color:red;*/
        }
    </style>

    <% List<Shop.DTO.TipoProductoDTO> listaTipoProd = Shop.Negocio.TipoProductoNegocio.ObtenerTipoProductosAll();%>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>--%>
    <%--<script src="../js/table.js"></script>--%>

    <%--<br />--%>

    <%--    <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="panel1" runat="server">

        <ContentTemplate>--%>

    <div>

        <div class="container">

            <h3>Buscar por: </h3>
            <asp:DropDownList ID="ddlTipos" CssClass="texto" runat="server" OnSelectedIndexChanged="ddlTipos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
        <br />
        <div class="container " style="background-color: white">

            <div  class="icon-box col-md-3 col-sm-4">
                <%--<div class="icon-box col-md-3 col-sm-4"><a class="agile-icon" href="#plus-square-o"><i class="fa fa-plus-square-o"></i> fa-plus-square-o</a></div>--%>
                <a class="agile-icon" href="mantenedor-tipos-productos.aspx"><i class="fa fa-plus-square-o"></i>Agregar Tipo</a> &nbsp; &nbsp;
                
            </div>

            <div  class="icon-box col-md-3 col-sm-4">  

                <a class="agile-icon" href="mantenedor-productos.aspx"><i class="fa fa-plus-square-o"></i>Agregar Producto</a>
            </div>

            <asp:GridView ID="gvTipoProductos" class="table table-bordered table-hover" AutoGenerateColumns="False" runat="server" PageSize="10" DataKeyNames="idTipoProducto" OnPageIndexChanging="gvProductos_PageIndexChanging" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" ForeColor="Black">
                <Columns>

                    <asp:HyperLinkField
                        DataNavigateUrlFields="idTipoProducto"
                        DataNavigateUrlFormatString="Productos.aspx?idTipo={0}"
                        DataTextField="nombreProducto"
                        HeaderText="Nombre"
                        SortExpression="Nombre" />
                    <asp:BoundField HeaderText="Descripción" DataField="descripcion" />
                    <asp:BoundField HeaderText="Estado" DataField="nombreEstado" />

                    <asp:ImageField DataImageUrlField="img" HeaderText="Imagen" DataImageUrlFormatString="/{0}">
                        <%--<ItemStyle CssClass="imagenProducto" />--%>
                        <ControlStyle CssClass="imagenProducto" />
                    </asp:ImageField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="linkEditar" runat="server" CommandArgument='<%# Eval("idTipoProducto") %>' OnClick="linkEditar_Click">Editar</asp:LinkButton>
                            <asp:LinkButton ID="linkEliminar" runat="server" CommandArgument='<%# Eval("idTipoProducto") %>' OnClientClick="return confirm('¿Desea eliminar este tipo? Esta acción eliminará todos los productos asociados');" OnClick="linkEliminar_Click">Eliminar</asp:LinkButton>

                        </ItemTemplate>

                        <ItemStyle VerticalAlign="Middle" />
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#8904B1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </div>

    <%-- </ContentTemplate>
    </asp:UpdatePanel>--%>
    <br />

</asp:Content>
