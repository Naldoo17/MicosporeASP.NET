<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="informacion.aspx.cs" Inherits="Shop.Presentacion.Administrador.informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <% List<Shop.DTO.InformacionDTO> listaInfo = Shop.Negocio.InformacionNegocio.ObtenerInformacionAllJoinTipoInfoNegocio().OrderBy(p=>p.Nombre).ToList(); %>

    <script>

        function redirect() {
            location.href = "mantenedor-informacion.aspx";
        }
    </script>
    <div class="container" style="background-color: white">

    
        <div class="row py-3">
                <h1>Información</h1>

            <div class="col-lg-12">
                <div>
                    <br />
                    <input type="button" id="btnAgregar" value="Crear módulo información" onclick="redirect()" class="botton-register" />
                </div>
                
                <br />
                <table class="table table-bordered table-hover" style="background-color: white">
                    <thead>
                        <tr>
                            <td><b>Nombre Información</b></td>
                            <td><b>Título</b></td>
                            <td><b>Tipo</b></td>
                            <td><b>Descripción</b></td>
                            <td><b>Estado</b></td>
                            <td><b>Imagen</b></td>
                            <td style="width: 80px"><b>Acciones</b></td>
                        </tr>
                    </thead>

                    <tbody>

                        <%foreach (var aux in listaInfo)
                            {
                        %>
                        <tr>
                            <td>
                                <a href="informacion-grupo.aspx?idInfo=<%Response.Write(aux.Id); %>">
                                    <% Response.Write(aux.Nombre); %>
                                </a>
                            </td>
                            <td>

                                <%Response.Write(aux.Titulo); %>

                            </td>
                            <td>
                                <%Response.Write(aux.NombreTipo); %>
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
                                    <a href="editar-informacion.aspx?idInfo=<%Response.Write(aux.Id); %>">Editar</a>
                                </a>
                                <a href="#">

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
