<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="variedades-setas.aspx.cs" Inherits="Shop.Presentacion.variedades_setas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="row py-3">

            <%-- <div class="col-lg-3 info rounded">
                <div class="">--%>
            <%--<asp:Label runat="server" ID="label"> prueba</asp:Label>--%>
            <%-- <h2 class="my-4" style="color: mediumpurple">Infórmate sobre  todo lo relacionado con Hongos Alucinógenos</h2>
                </div>--%>
            <%--<a href="#" class="list-group-item rounded">¿Te interesa cultivar?</a>
                <a href="#" class="list-group-item ">Category 2</a>
                <a href="#" class="list-group-item ">Category 3</a>--%>
            <%-- <p>Nosotros como equipo de Micospore, queremos informarte y orientarte en todo lo que este relacionado con hongos psilocibios, también llamados hongos alucinógenos, desde 
                    lo que son, como se cultivan, cuáles son sus efectos e informarte las distintas variedades que existen y sus efectos.
                </p>
            </div>--%>


            <!-- /.col-lg-3 -->

            <div class="col-lg-12">

                <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    </ol>
                    <div class="carousel-inner" role="listbox">
                        <div class="carousel-item active">
                            <img class="d-block img-fluid" src="img/psilocybe-semilanceata-shrooms-magic.jpg" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="img/img_alimentos-alucinogenos-hd.jpg" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="img/Golden_teacher_kookoskuidussa_3.jpg" alt="Third slide">
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>

                <div class="row">

                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/el-sumario-Hongos-lucharán-contra-la-depresión.jpg" alt=""></a>
                            <div class="card-body">
                                <h3>Cepa - Micelio </h3>

                                <h4>Thai </h4>
                                <h5>Disponible</h5>
                                <p>Formato: Vial, Micelio</p>
                                <%--<h4 class="card-title">
                                    <a href="#">¿Qué son los Hongos alucinógenos?</a>
                                    
                                </h4>--%>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">
                                   Son considerados cosmopolitas y pueden alcanzar una altura de ocho a quince centímetros. Los sombrerillos pueden medir entre dos y ocho centímetros de diámetro; son campanulado al principio y posteriormente convexos o planos.
                                    Sus colores varían bastante, desde blanco casi puro con una mancha dorada en el centro, hasta café claro con la misma mancha anaranjada en el centro. Las esporas son café purpúreo. Los tallos 
                                    son huecos, de colores blancos cremosos o amarillos amarronados. Cuando se lesionan, los hongos adoptan un color azul verdoso producto de la exposición de la psilocibina al aire. Cuando están bien desarrollados,
                                    se les forma un anillo blanco, membranoso y resistente, que posteriormente se torna negruzco.
                                </p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/magic-mushroomz.jpg" alt=""></a>
                            <div class="card-body">
                                <h4 class="card-title">
                                    <a href="#">¿Cuáles son los efectos?</a>
                                </h4>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">"Hongos alucinógenos" es el nombre que se le dio a los hongos psicoactivos, que contiene compuestos alucinógenos tales como la psilocibina y la psilocina.</p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/hongos.jpg" alt=""></a>
                            <div class="card-body">
                                <h4 class="card-title">
                                    <a href="#">Variedades de setas alucinógenas</a>
                                </h4>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">Dentro de cada especie hay distintas variedades que se diferencian entre ellas en ciertos aspectos ya que provienen de distintos lugares o de cruces realizados en laboratorio.</p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>
                    <%--700 x 400--%>
                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/imagen-hongos-2.jpg" alt=""></a>
                            <div class="card-body">
                                <h4 class="card-title">
                                    <a href="#">Cultivo de setas y hongos alucinógenos</a>
                                </h4>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">Desde sellos de esporas hasta la cosecha: preparación de jeringas, inoculación, fructificación, recolección, panes de setas y ...</p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/Psilocybe_fimetaria.jpg" alt=""></a>
                            <div class="card-body">
                                <h4 class="card-title">
                                    <a href="#">Contaminaciones</a>
                                </h4>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">Contaminaciones en el cultivo de setas alucinógenas. Causas y tratamiento.</p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="card h-100">
                            <a href="#">
                                <img class="card-img-top" src="img/imagen-hongo-1.jpg" alt=""></a>
                            <div class="card-body">
                                <h4 class="card-title">
                                    <a href="#">Trufas alucinógenas</a>
                                </h4>
                                <%--<h5>$24.99</h5>--%>
                                <p class="card-text">Trufas alucinógenas de psilocibina. Infórmate sobre los distintos tipos, variedades y especies de trufas mágicas</p>
                            </div>
                            <%--<div class="card-footer">
                                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>--%>
                        </div>
                    </div>

                </div>
                <!-- /.row -->

            </div>
            <!-- /.col-lg-9 -->

        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->


</asp:Content>
