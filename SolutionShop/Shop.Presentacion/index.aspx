<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shop.Presentacion.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- <link rel="shortcut icon" href="img/logo_micospore_white.jpg">
    <title>Micospore - Index</title>
    <style>
        .info {
            background: white;
            height: auto;
            margin-top: 25px;
            margin-bottom: auto;
        }
    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- font-awesome icons -->
    <link href="css/font-awesome.css" rel="stylesheet">
    <!-- //font-awesome icons -->
    <!-- js -->
    <script src="js/jquery-1.11.1.min.js"></script>
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Raleway:400,100,100italic,200,200italic,300,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <!-- start-smoth-scrolling -->
    <script type="text/javascript" src="js/move-top.js"></script>
    <script type="text/javascript" src="js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
    </script>
    <!-- start-smoth-scrolling -->


    <ul id="demo1">
        <li>
            <img src="img/inicio-5.jpeg" alt="" />
            <!--Slider Description example-->
            <div class="slide-desc">

                <h3>Consulta nuestra tienda, tenemos lo que buscas</h3>
            </div>
        </li>
        <li>
            <img src="img/inicio-2.jpg" alt="" />
            <div class="slide-desc">
                <h3>La mejor calidad en productos</h3>
            </div>
        </li>

        <li>
            <img src="img/inicio-4.jpg" alt="" />
            <div class="slide-desc">
                <h3>Aprende sobre el mundo fungi y conoce toda la variedad que te espera</h3>
            </div>
        </li>
    </ul>


    <div class="top-brands">
        <div class="container">
            <h2>Consulta nuestra tienda</h2>
            <div class="grid_3 grid_5">
                <div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
                    <%--<ul id="myTab" class="nav nav-tabs" role="tablist">
                        <li role="presentation" class="active"><a href="#expeditions" id="expeditions-tab" role="tab" data-toggle="tab" aria-controls="expeditions" aria-expanded="true">Ofertas de esta semana
                        </a></li>
                        <li role="presentation"><a href="#tours" role="tab" id="tours-tab" data-toggle="tab" aria-controls="tours">Variedad de productos</a></li>
                    </ul>--%>
                    <div id="myTabContent" class="tab-content">
                        <div role="tabpanel" class="tab-pane fade in active" id="expeditions" aria-labelledby="expeditions-tab">
                            <div class="agile-tp">
                              
                                <h5>Sustrato</h5>
                                <p class="w3l-ad">Como equipo de Micospore nos encargamos de entregarte los mejores productos de calidad.</p>
                            </div>
                            <div class="agile_top_brands_grids">
                                <%int contador = 0; %>
                                <%foreach (var aux in Shop.Negocio.ProductoNegocio.ObtenerProductosAllNegocio().Where(p=>p.TipoProducto==3).ToList())
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
                                                            <a href="products.html">
                                                                <img title=" " class="imagenProductoInicio-1" alt=" " src="<%Response.Write(aux.Img); %>" />
                                                            </a>
                                                            <p><%Response.Write(aux.NombreProducto); %></p>
                                                           
                                                            <h4>$<%Response.Write(Shop.Negocio.ProductoNegocio.FormateoPrecio((int)aux.Precio)); %></h4>
                                                        </div>
                                                        <div class="snipcart-details top_brand_home_details">
                                                                <fieldset>
                                                                    <input type="hidden" name="cmd" value="_cart" />
                                                                    <input type="hidden" name="add" value="1" />
                                                                    <input type="hidden" name="business" value=" " />
                                                                    <input type="hidden" name="item_name" value="Fortune Sunflower Oil" />
                                                                    <input type="hidden" name="amount" value="20.99" />
                                                                    <input type="hidden" name="discount_amount" value="1.00" />
                                                                    <input type="hidden" name="currency_code" value="USD" />
                                                                    <input type="hidden" name="return" value=" " />
                                                                    <input type="hidden" name="cancel_return" value=" " />
                                                                </fieldset>
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

                        </div>
                       <%-- <div role="tabpanel" class="tab-pane fade" id="tours" aria-labelledby="tours-tab">
                            <div class="agile-tp">
                                <h5>Vermiculita</h5>
                                <p class="w3l-ad">Consigue tu vermiculita de mejor calidad al mejor precio. Consulta nuestra tienda aquí</p>
                            </div>
                            <div class="agile_top_brands_grids">
                                <% contador = 0; %>
                                <%foreach (var aux in Shop.Negocio.ProductoNegocio.ObtenerProductosAllNegocio().Where(p => p.TipoProducto == 2).ToList())
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
                                                            <a href="products.html">
                                                              
                                                                <img title=" " alt=" " class="imagenProductoInicio-1" src="<%Response.Write(aux.Img); %>" />
                                                            </a>
                                                       
                                                            <p><%Response.Write(aux.NombreProducto); %></p>
                                         
                                                           
                                                            <h4>$<%Response.Write(Shop.Negocio.ProductoNegocio.FormateoPrecio((int)aux.Precio)); %></h4>
                                                        </div>
                                                        <div class="snipcart-details top_brand_home_details">
                                               
                                                                <fieldset>
                                                                    <input type="hidden" name="cmd" value="_cart" />
                                                                    <input type="hidden" name="add" value="1" />
                                                                    <input type="hidden" name="business" value=" " />
                                                                    <input type="hidden" name="item_name" value="Fortune Sunflower Oil" />
                                                                    <input type="hidden" name="amount" value="20.99" />
                                                                    <input type="hidden" name="discount_amount" value="1.00" />
                                                                    <input type="hidden" name="currency_code" value="USD" />
                                                                    <input type="hidden" name="return" value=" " />
                                                                    <input type="hidden" name="cancel_return" value=" " />
                                                                </fieldset>
                                             
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
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- new -->
    <div class="newproducts-w3agile">
        <div class="container">
            <h3>Nuestros Productos</h3>
            <div class="agile_top_brands_grids">


                <%
                    foreach (var aux in Shop.Negocio.TipoProductoNegocio.ObtenerTipoProductosAll().GetRange(0,3).Where(p=>p.activo==1).ToList())
                    {
                        %>

                    
                <div class="col-md-4 top_brand_left-1">
                    <div class="hover14 column">
                        <div class="agile_top_brand_left_grid">
                            <div class="agile_top_brand_left_grid_pos">
                                <%--<img src="img/offer.png" alt=" " class="img-responsive">--%>
                            </div>
                            <div class="agile_top_brand_left_grid1">
                                <figure>
                                    <div class="snipcart-item block">
                                        <div class="snipcart-thumb">
                                            <a href="#">
                                                <%--<img title=" " alt=" " src="img/14.png">--%>
                                                <img title=" " alt=" " class="imagenProductoInicio-2" src="<%Response.Write(aux.img); %>">

                                            </a>
                                            <%--<p>Fried-gram</p>--%>
                                            <p><%Response.Write(aux.nombreProducto); %></p>
                                           <%-- <div class="stars">
                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                <i class="fa fa-star blue-star" aria-hidden="true"></i>
                                                <i class="fa fa-star gray-star" aria-hidden="true"></i>
                                            </div>--%>
                                            <%--<h4>$35.99 <span>$55.00</span></h4>--%>
                                        </div>
                                        <div class="snipcart-details top_brand_home_details">
                                           <%-- <form action="#" method="post">--%>
                                                <fieldset>
                                                    <input type="hidden" name="cmd" value="_cart">
                                                    <input type="hidden" name="add" value="1">
                                                    <input type="hidden" name="business" value=" ">
                                                    <input type="hidden" name="item_name" value="Fortune Sunflower Oil">
                                                    <input type="hidden" name="amount" value="35.99">
                                                    <input type="hidden" name="discount_amount" value="1.00">
                                                    <input type="hidden" name="currency_code" value="USD">
                                                    <input type="hidden" name="return" value=" ">
                                                    <input type="hidden" name="cancel_return" value=" ">
                                                    <%--<input type="submit" name="submit" value="consultar" class="button" />--%>
                                                    <%--<button class="submit" onclick="redirect(<% Response.Write(aux.idTipoProducto); %>);" >consultar</button>--%>
                                                </fieldset>
                                          <%--  </form>--%>
                                        </div>
                                    </div>
                                </figure>
                            </div>
                        </div>
                    </div>
                </div>

                <%
                    }
                   
                   %>


           
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    
    
    
    <script>


</script>
</asp:Content>

