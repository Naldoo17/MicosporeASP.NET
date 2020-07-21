//function prueba() {
//    alert("alerta de prueba");
//}

//prueba();



function addFila(data) {
    var tabla = $("#tbl_productos").dataTable();


    for (var i = 0; i < data.length; i++) {

        tabla.fnAddData([
            data[i].NombreProducto,
            data[i].Precio,
            data[i].Stock

        ]);

    }

}


function enviarListadoProductos() {


    //alert("envio de listado");
    //$.ajax({
    //    type: "POST",
    //    url: "../Administrador/lista-productos.aspx/ListaProductos",
    //    data: {},
    //    contentType: "application/json; charset=utf-8",
    //    error: function (xhr, ajaxOptiones, thrwnError) {

    //        alert("error");
    //    },
    //    succes: function (data) {
    //        //alert("funciona");
    //        //addFila(data);
    //        alert("sin error");
    //    }
    //});


    $.ajax({
        method: "POST",
        url: "../Administrador/lista-productos.aspx/ListaProductos",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done(function (data) {
        //alert("trae datos");
        
        console.log(data);
        addFila(data.d);

    }).error(function () {

        alert("errorrr");
    });

}



enviarListadoProductos();
