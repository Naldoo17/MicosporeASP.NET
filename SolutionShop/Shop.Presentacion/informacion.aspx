<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="informacion.aspx.cs" Inherits="Shop.Presentacion.informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="shortcut icon" href="img/logo_micospore_white.jpg">
    <title>Micospore - Información</title>
    <style>
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
        int id = 0;
        if (Request.QueryString["idInfo"]!=null)
        {
             id = int.Parse(Request.QueryString["idInfo"]);
        }
         %>

    <% List<Shop.DTO.GrupoInfoDTO> listaGrupos = Shop.Negocio.GrupoInfoNegocio.ObtenerGrupoInfoFilterInfo(id).Where(p=>p.Estado==1).ToList(); %>

       
    <br />
    <div class="products">
        <div class="container">
            <div class="row">
                <div class="col-md-4 products-left">
                    <div class="categories">
                        <h2>Blog</h2>
                        <ul class="cate">

                            <%foreach (var aux in Shop.Negocio.InformacionNegocio.ObtenerInformacionAllNegocio().Where(p=>p.Estado==1).ToList())
                                {
                            %>

                           <li><a href="informacion.aspx?idInfo=<%Response.Write(aux.Id); %>"><i class="fa fa-arrow-right" aria-hidden="true"></i><%Response.Write(aux.Nombre); %></a>
                                <li>


                                    <%foreach (var aux2 in Shop.Negocio.GrupoInfoNegocio.ObtenerGrupoInfoFilterInfo(aux.Id).Where(p=>p.Estado==1).ToList())
                                        {
                                    %>

                                    <ul>
                                        <li><a href="products.html"><i class="fa fa-arrow-right-2" aria-hidden="true"></i><%Response.Write(aux2.Nombre); %></a></li>
                                    </ul>

                                    <%    } %>

                              
                                </li>
                            </li>


                            <% } %>
                        </ul>
                    </div>
                </div>


                <div class="col-md-8 blog-1">
                    <div class="categories">

                        <div class=" column">
                            <div class="blog">
                                <div class="agile_top_brand_left_grid">

                                    <img src="img/img-blog.jpeg" />
                                    <h3>Informate en nuestro blog

                                    </h3>
                                    <p>
                                        Ex officia enim aliqua do culpa officia nisi eiusmod in. Sint ullamco ex occaecat duis occaecat esse sint consectetur. Ullamco incididunt tempor dolor sit ut id nostrud. Voluptate dolore ullamco est in ut sit tempor.


                                    </p>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>


    </div>



    <div class=" ">


        <div class="row">

            <div class="container blog-container">

                <%--<% List<Shop.DTO.InformacionDTO> listaInfo = Shop.Negocio.InformacionNegocio.ObtenerInformacionAllNegocio().Where(p => p.Estado == 1).OrderBy(p => p.Nombre).ToList();  %>--%>


                <% foreach (var aux in listaGrupos)
                    {
                %>

                <div class="col-md-4" style="padding: 4px 7px 2px 4px;">
                    <div class=" column">
                        <div class="blog">
                            <div class="agile_top_brand_left_grid">

                                <img src="<%Response.Write(aux.Img); %>" />
                                <h3><%Response.Write(aux.Nombre); %></h3>
                                <p>
                                    <%Response.Write(aux.Descripcion); %>
                                </p>
                            </div>
                        </div>
                    </div>

                </div>

                <%} %>
            </div>
        </div>
    </div>


</asp:Content>
