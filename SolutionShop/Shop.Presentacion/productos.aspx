<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="Shop.Presentacion.Productos.productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 


    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>--%>

    <br />
    <div class="products">
        <div class="container">
            <div class="row">
                <div class="col-md-4 products-left">
                    <div class="categories">
                        <h2>catálogo</h2>
                        <ul class="cate">

                            <%foreach (var aux in Shop.Negocio.TipoProductoNegocio.ObtenerTipoProductosActivosAll())
                                {
                            %>

                            <li><a href="producto.aspx?idTipo=<%Response.Write(aux.idTipoProducto); %>"><i class="fa fa-arrow-right" aria-hidden="true"></i><%Response.Write(aux.nombreProducto); %></a>
                            </li>


                            <% } %>
                        </ul>
                    </div>
                </div>
                <div class="col-md-8 blog-1 py-2">
                    <div class="">
                        <div class=" column">
                            <div class="blog">
                                <div class="agile_top_brand_left_grid">
                                    <img src="img/img-blog.jpeg" />
                                    <h3>Encuentra todo lo que necesitas para tu cultivo fungi

                                    </h3>
                                    <p>
                                        <%--Ex officia enim aliqua do culpa officia nisi eiusmod in. Sint ullamco ex occaecat duis occaecat esse sint consectetur. Ullamco incididunt tempor dolor sit ut id nostrud. Voluptate dolore ullamco est in ut sit tempor.--%>
                                        Encuentra lo que necesitas para llevar a cabo tu cultivo fungi. Visita nuestro blog <a href="blog-info.aspx">aquí</a> para obtener toda la información que necesites para guiarte en tu propio cultivo.

                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>



    
    <div class="newproducts-w3agile">
        <div class="container">
            <h3>Consulta nuestro catálogo</h3>
            <div class="agile_top_brands_grids">





                <%int contador = 0; %>
                <%foreach (var aux in Shop.Negocio.TipoProductoNegocio.ObtenerTipoProductosActivosAll().GetRange(0,3).ToList())
                    {

                        contador = contador + 1; ;
                %>
                <div class="col-md-4 top_brand_left">
                    <div class="hover14 column">
                        <div class="agile_top_brand_left_grid">
                            <div class="agile_top_brand_left_grid_pos">
                            </div>
                            <div class="agile_top_brand_left_grid1">
                                <figure>
                                    <div class="snipcart-item block">
                                        <div class="snipcart-thumb">
                                            <a href="producto.aspx?idTipo=<%Response.Write(aux.idTipoProducto); %>">
                                                <%--<img title=" " alt=" " src="img/1.png" />--%>
                                                <img title=" " alt=" " class="imagenProducto-2" src="<%Response.Write(aux.img); %>" />
                                            </a>
                                            <%-- <p>Tata-salt</p>--%>
                                            <p><%Response.Write(aux.nombreProducto); %></p>
                                            <%--<div class="stars">
                                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                                <i class="fa fa-star gray-star" aria-hidden="true"></i>
                                                            </div>--%>
                                            <%--<h4>$20.99 <span>$35.00</span></h4>--%>
                                            <%--    <h4>$<%Response.Write(Shop.Negocio.ProductoNegocio.FormateoPrecio((int)aux.descripcion)); %></h4>--%>
                                        </div>

                                    </div>
                                </figure>
                            </div>
                        </div>
                    </div>

                    <% if (contador == 3)
                        {
                    %>

                    <h1 style="visibility: hidden">space</h1>

                    <%
                        } %>
                </div>


                <% } %>

                <div class="clearfix"></div>
            </div>

            <%-- <div class="row">

                    <%
                        int contador = 1;
                        foreach (var aux in Shop.Negocio.TipoProductoNegocio.ObtenerTipoProductosAll().Where(p => p.activo == 1).ToList())
                        {
                            contador = contador + 1;
                    %>


                    <div class="col-md-4 " style="padding-bottom: 2em;">
                        <div class=" column">
                            <div class="agile_top_brand_left_grid">     
                                <div class="agile_top_brand_left_grid1">
                                    <figure>
                                        <div class="snipcart-item block">
                                            <div class="snipcart-thumb">
                                                <a href="products.html">
                                          
                                                    <img title=" " alt=" " src="<%Response.Write(aux.img); %>">
                                                </a>
                                          
                                                <p><%Response.Write(aux.nombreProducto); %></p>
                                                <div class="stars">
                                                    <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                    <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                    <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                    <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                    <i class="fa fa-star gray-star" aria-hidden="true"></i>
                                                </div>
                                      
                                            </div>
                                            <p><%Response.Write(aux.descripcion); %></p>
                                            
                                            <button value="<%Response.Write(aux.idTipoProducto); %>"  class="btn btn-success"  name="btnPrueba">pruebaa</button>
                                           
                                        </div>
                                    </figure>
                                </div>
                            </div>
                        </div>
                    </div>--%>

            <%--   <%if (contador == 3)
                        {
                            contador = 0;
                           
                    %>
                    <h1 style="visibility:hidden">space</h1>

                    <%} %>

                    <%
                        }

                    %>
                </div>--%>
        </div>
    </div>


    <script>
        $(document).ready(function () {

            $('button[name=btnPrueba]').click(function (e) {

                e.preventDefault();
                var id = $(this).val();
                alert("El id es: " + id);




            });
        });



    </script>


</asp:Content>
