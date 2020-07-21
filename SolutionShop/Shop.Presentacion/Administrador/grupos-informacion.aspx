<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="grupos-informacion.aspx.cs" Inherits="Shop.Presentacion.Administrador.grupos_informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <% List<Shop.DTO.GrupoInfoDTO> grupos = Shop.Negocio.GrupoInfoNegocio.ObtenerGruposInfoJoinInfo(); %>

<script>

    function redirect(){
        location.href = "mantenedor-grupo.aspx";
    }
</script>
    <div class="container mantenedor" style="background-color: white">

        <h1>Grupos de Información</h1>
        <div class="row py-3">


            <div class="col-lg-12">

                <br />
                 <%--<a href="mantenedor-grupo.aspx">Agregar</a>--%>
                <input type="button" id="btnAgregar" value="Crear grupo" onclick="redirect()" class="botton-register" /> 
                <br />
                <br />
                <table class="table table-bordered table-hover" style="background-color: white">
                    <thead>
                        <tr>
                            <td><b>Nombre Grupo</b></td>
                            <td><b>Título</b></td>
                            <td><b>Módulo Información</b></td>
                            <td><b>Descripción</b></td>
                            <td><b>Estado</b></td>
                            <td><b>Imagen</b></td>
                            <td style="width: 80px"><b>Acciones</b></td>
                        </tr>
                    </thead>

                    <tbody>

                        <%foreach (var aux in grupos)
                            {
                        %>

                        <tr>
                            <td>
                                <%--<a href="Productos.aspx?idTipo=<%Response.Write(aux.idTipoProducto); %>">
                                    <%Response.Write(aux.nombreProducto); %>
                                </a>--%>
                                <a href="">
                                    <% Response.Write(aux.Nombre); %>
                                </a>
                            </td>
                            <td>
                                <%--<%Response.Write(aux.descripcion); %>--%>
                                <%Response.Write(aux.Titulo); %>

                            </td>

                            <td>
                                <%Response.Write(aux.nombreTipoInfo); %>
                                <%--<%Response.Write(Shop.Negocio.TipoProductoNegocio.TipoToString(aux.activo)); %>--%>

                            </td>

                            <td>
                                <%Response.Write(aux.Descripcion); %>
                                <%--<img src="/<% Response.Write(aux.img); %>" width="50" height="50" />--%>
                            </td>
                            <td>



                                <%Response.Write(Shop.Negocio.GrupoInfoNegocio.TipoToString(aux.Estado)); %>
                            </td>
                            <td>
                                <img src="/<% Response.Write(aux.Img); %>" width="50" height="50" />
                            </td>
                            <td>
                                <a href="#">
                                    <a href="editar-grupo-info.aspx?idGrupo=<%Response.Write(aux.Id); %>">Editar</a>
                                </a>
                                <a href="#">
                                    <%--<a href="" onclick="Confirmar(<%Response.Write(aux.idTipoProducto); %>)">Eliminar</a>--%>
                                    <a href="">Eliminar</a>
                                </a>
                            </td>



                        </tr>
                        <%} %>
                    </tbody>

                </table>

            </div>


        </div>


    </div>
</asp:Content>
