<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="blog-info.aspx.cs" Inherits="Shop.Presentacion.blog_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link rel="shortcut icon" href="img/logo_micospore_white.jpg">--%>
    <title>Micospore - Blog</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <div class="products">
        <div class="container">
            <div class="row">
                <div class="col-md-4 products-left">
                    <div class="categories">
                        <h2>Blog</h2>
                        <ul class="cate">
                            <%-- <li><a href="products.html"><i class="fa fa-arrow-right" aria-hidden="true"></i>Contaminaciones</a>
                                <li>
                                    <ul>
                                        <li><a href="products.html"><i class="fa fa-arrow-right" aria-hidden="true"></i>Contaminantes</a></li>
                                    </ul>
                                </li>
                            </li>
                            <li><a href="products.html"><i class="fa fa-arrow-right" aria-hidden="true"></i>Cuts & Sprouts</a></li>
                            <li><a href="products.html"><i class="fa fa-arrow-right" aria-hidden="true"></i>Grocery & Staples</a></li>
                            <li><a href="products.html"><i class="fa fa-arrow-right" aria-hidden="true"></i>PersonalCare</a></li>--%>


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
                    <div class="">

                        <div class=" column">
                            <div class="blog">
                                <div class="agile_top_brand_left_grid">

                                    <img src="img/img-blog.jpeg" />
                                    <h3>Infórmate en nuestro blog

                                    </h3>
                                    <p>
                                        <%--Ex officia enim aliqua do culpa officia nisi eiusmod in. Sint ullamco ex occaecat duis occaecat esse sint consectetur. Ullamco incididunt tempor dolor sit ut id nostrud. Voluptate dolore ullamco est in ut sit tempor.--%>
                                        Bienvenido a nuestro blog donde te informaremos de todo lo relacionado con hongos Psycodélicos, tambien aprenderas sus variedades, efectos, cultivo, 
                                        contaminantes y muchos mas. Visita nuestro blog si necesitas orientación en tu cosecha o contáctanos vía email en <a href="mailto:contacto@micospore.cl">contacto@micospore.cl</a>.
                                        Hecha un vistazo a lo que tenemos preparado para ti.
                                        

                                    </p>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>


    </div>


    <div>


        <div class="row">

            <div class="container blog-container">

                <% List<Shop.DTO.InformacionDTO> listaInfo = Shop.Negocio.InformacionNegocio.ObtenerInformacionAllNegocio().Where(p => p.Estado == 1).OrderBy(p => p.Nombre).ToList();  %>

                <% foreach (var aux in listaInfo)
                    {
                %>

                <div class="col-md-4 column-blog"  style="padding: 4px 7px 2px">
                    <div class=" column">
                        <div class="blog">
                            <div class="agile_top_brand_left_grid">

                                <img src="<%Response.Write(aux.Img); %>" />
                                <h3><%Response.Write(aux.Titulo); %></h3>
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
