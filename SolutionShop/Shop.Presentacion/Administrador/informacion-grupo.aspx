<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="informacion-grupo.aspx.cs" Inherits="Shop.Presentacion.Administrador.informacion_grupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%  int idInfo = int.Parse(Request.QueryString["idInfo"]); %>

    <%List<Shop.DTO.GrupoInfoDTO> listaGrupo = Shop.Negocio.GrupoInfoNegocio.ObtenerGruposInfoXInfo(idInfo); %>
    <script>

        function redirect() {
            location.href = "mantenedor-grupo.aspx";
        }
    </script>
    <div class="container" style="background-color: white">




        <div class="row py-3">
            <h1>Grupos por Información</h1>

            <div class="col-lg-12">
                <div>
                    <input type="button" id="btnAgregar" value="Crear grupo" onclick="redirect()" class="btn btn-primary" />
                </div>
                <br />
                <table class="table table-bordered table-hover" style="background-color: white">


                    <%if (listaGrupo.Count() > 0)
                        {
                    %>

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

                        <%foreach (var aux in listaGrupo)
                            {
                        %>

                        <tr>
                            <td>

                                <a href="">
                                    <% Response.Write(aux.Nombre); %>
                                </a>
                            </td>
                            <td>
                                <%Response.Write(aux.Titulo); %>

                            </td>

                            <td>
                                <%Response.Write(aux.nombreTipoInfo); %>

                            </td>

                            <td>
                                <%Response.Write(aux.Descripcion); %>
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
                            <td>No hay grupos asociados
                            </td>
                        </tr>

                    </tbody>


                    <%} %>
                </table>
                <a href="informacion.aspx">volver</a>
            </div>


        </div>



    </div>


</asp:Content>
