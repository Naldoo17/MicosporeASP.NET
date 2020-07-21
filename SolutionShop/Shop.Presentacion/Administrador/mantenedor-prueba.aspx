<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-prueba.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_prueba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .mantenedor {
            background-color: white;
            height: auto;
            width: auto;
        }
    </style>
    <script src="../js/funciones.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <div class="container">

        <div class="row">
            <div class="col-md-6 mantenedor">
                <div>
                    <p>Nombre Comuna</p>
                    <input type="text" id="nombreComuna" class="form-control" placeholder="Ingrese nombre comuna" />
                    <br />
                    <input type="button" id="botonGuardarComuna" class="btn btn-success" value="Guardar" />
                    <br />
                </div>
            </div>
            <div class="col-md-6 mantenedor">
                <asp:GridView ID="gvComunas" runat="server" CssClass="table table-bordered bs-table" AutoGenerateColumns="true"></asp:GridView>
            </div>
        </div>
    </div>



    <%--<asp:ScriptManager ID="scm" runat="server" EnablePageMethods="true" />--%>
    <script>
        $(document).ready(function () {

            $("#botonGuardarComuna").click(function (e) {

                e.preventDefault();
                var nombre = $("#nombreComuna").val();

                if (nombre == "") {
                    alert("Ingrese nombre de comuna");
                    return;
                }

                var data = {
                    objComuna: {

                        Nombre: $("#nombreComuna").val()
                    }
                }

                $.ajax({
                    method: "POST",
                    url: "mantenedor-prueba.aspx/registrarComuna",
                    data: JSON.stringify(data),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json"
                }).done(function (info) {
                    //alert("Nombre ingresado: " + info.d);
                    if (info.d == true) {
                        alert("Registrado correctamente");
                        $("#nombreComuna").val("");
                        //document.getElementById("nombreComuna").val = "";
                        //location.reload();
                    } else {
                        alert("Error al registrar");
                    }
                    //console.log(info.d);
                });

            });
        });
    </script>
</asp:Content>
