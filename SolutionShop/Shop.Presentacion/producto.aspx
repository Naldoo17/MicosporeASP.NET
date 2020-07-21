<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="Shop.Presentacion.producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
    </style>



    <%
        int idTipo = int.Parse(Request.QueryString["idTipo"]);
        //if (Request.QueryString["idTipo"] != null)
        //{
        idTipo = int.Parse(Request.QueryString["idTipo"].ToString());
        //}

    %>

    <%List<Shop.DTO.ProductoDTO> listaProd = Shop.Negocio.ProductoNegocio.ObtenerProductosAllFiltroTipoProd(idTipo); %>





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

                <div class="col-md-8">               

                    <asp:ListView ID="lvProductos" runat="server" OnItemCommand="ListView1_ItemCommand">
                        <ItemTemplate>
                       
                            <div class="col-md-4 top_brand_left">
                                <div class="hover14 column">
                                    <div class="agile_top_brand_left_grid">
                                        <div class="agile_top_brand_left_grid_pos">
                                        </div>
                                        <div class="agile_top_brand_left_grid1">
                                            <figure>
                                                <div class="snipcart-item block" style="text-align:center">
                                                    <div class="snipcart-thumb">
                                                        <a href="detalle-producto.aspx?id=<%# Eval("IdProducto")%>">
                                                            <img title=" " width="250" class="imagenProducto-1" height="340" alt=" " src="<%# Eval("Img") %>" />
                                                        </a>
                                                        <p style="visibility:hidden">
                                                             <asp:Label ID="lblId" runat="server" Text='<%# Eval("IdProducto")%>'></asp:Label>
                                                        </p>
                                                        <p>
                                                            
                                                            <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("NombreProducto")%>'></asp:Label>

                                                        </p>
                                                        <h4>
                                                            <asp:Label ID="lblPrecio" runat="server" Text='<%#  Eval("Precio", "{0:c}") %>'></asp:Label>
                                                        </h4>
                                                        <p>

                                                            <asp:Label ID="lblDescripcion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                                                        </p>
                                                    </div>
                                                      <%--<asp:Button ID="Button1" runat="server"  Text="Agregar al Carrito" CssClass="botton-register" CommandName="Seleccione" />--%>
                                                </div>
                                            </figure>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:ListView>

                    <%--              <asp:DataList ID="dlProductos" runat="server" CssClass="table table-responsive row" RepeatColumns="3" >
                        <ItemTemplate>

                            <div class="col-md-4 top_brand_left">


                                <div class="">
                                    <div class="">
                                        <img title=" " width="250" class="" height="340" alt=" " src="<%# Eval("Img") %>" />
                                    </div>
                                    <p><%# Eval("NombreProducto")%></p>
                                    <h4>$<%# Eval("Precio") %></h4>
                                    <p><%# Eval("Descripcion") %></p>
                                    <asp:Button ID="Button1" runat="server" CommandName="Seleccionar" Text="Agregar al Carrito" CssClass="botton-register" />

                                </div>
                        </ItemTemplate>
                    </asp:DataList>--%>

                    <%--                       <%int contador = 0;
                        %>
                        <%foreach (var aux in listaProd)
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
                                                    <a href="">
                                                        <img title=" " alt=" " class="imagenProducto-1" src="<%Response.Write(aux.Img); %>" />
                                                    </a>
                                                    <p><%Response.Write(aux.NombreProducto); %></p>
                                                    <h4>$<%Response.Write(Shop.Negocio.ProductoNegocio.FormateoPrecio((int)aux.Precio)); %></h4>
                                                    <p><%Response.Write(aux.Descripcion); %></p>
                                                </div>
                                                <div class="snipcart-details top_brand_home_details">
                                                    <form action="#" method="post">
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
                                                    </form>
                                                </div>
                                            </div>
                                        </figure>
                                    </div>
                                </div>
                            </div>

                            <% if (contador == 3)
                                {
                                    contador = 0;
                            %>

                            <h1 style="visibility: hidden">space</h1>

                            <%
                                } %>
                        </div>

                        <% } %>--%>
                </div>
            </div>
        </div>
    </div>
    <br />




























</asp:Content>
