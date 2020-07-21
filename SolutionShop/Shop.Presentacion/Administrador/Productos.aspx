<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Shop.Presentacion.Administrador.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <% int idTipo = int.Parse(Request.QueryString["idTipo"].ToString()); %>
    <%List<Shop.DTO.ProductoDTO> listaProd = Shop.Negocio.ProductoNegocio.ObtenerProductosAllFiltroTipoProd(idTipo); %>
    <div class="container" style="background-color: white">




        <div class="row py-3">
            <h1>Listado productos por categoria</h1>

            <div class="col-lg-12">

                <table class="table table-bordered table-hover" style="background-color: white">


                    <%if (listaProd.Count() > 0)
                        {
                    %>

                    <thead>
                        <tr>
                            <td><b>Nombre Producto</b></td>
                            <td><b>Descripción</b></td>
                            <td><b>Imagen</b></td>
                            <td><b>Precio</b></td>
                            <td style="width: 80px"><b>Acciones</b></td>
                        </tr>
                    </thead>

                    <tbody>


                        <%foreach (var aux in listaProd)
                            {
                        %>

                        <tr>
                            <td>
                                <a >
                                    <%Response.Write(aux.NombreProducto); %>
                                </a>
                            </td>
                            <td><%Response.Write(aux.Descripcion); %></td>
                            <td style="text-align:center">
                                <img src="/<% Response.Write(aux.Img); %>" width="50" height="50" />
                            </td>


                            <%--<td style="text-align:center"><%Response.Write("$"+ aux.Precio.ToString("G")); %></td>--%>
                            <td style="text-align:center"><%Response.Write("$" + Shop.Negocio.ProductoNegocio.FormateoPrecio((int)aux.Precio)); %></td>

                            <td>
                                <a href="editar-productos.aspx?idProd=<%Response.Write(aux.IdProducto); %>">
                                    <span class="glyphicon glyphicon-edit "></span>editar
                                </a>
                                <a href="ejecutar.aspx?ejecutar=1&idProd=<%Response.Write(aux.IdProducto); %>&idTipo=<%Response.Write(idTipo); %>">
                                    <span class="glyphicon glyphicon-edit "></span>eliminar
                                </a>
                            </td>


                        </tr>
                        <%} %>
                    </tbody>
                    <% }
                        else
                        { %>



                    <thead>
                        <tr>
                            <td><b></b></td>

                        </tr>
                    </thead>

                    <tbody>

                        <tr style="text-align: center">
                            <td>No hay productos
                            </td>
                        </tr>

                    </tbody>


                    <%} %>
                </table>
                <a href="lista-productos.aspx">volver</a>
            </div>


        </div>



    </div>

</asp:Content>
