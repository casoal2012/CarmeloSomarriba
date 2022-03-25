//Definir el evento click
$("#btnGuardarProducto").click(function () {

    //2 obtener el valor del input nombre-producto
    var nombreProducto = $(".nombre-producto").val();
    var otraClaseproduc = $(".otraclase-producto").val();
    var otraPrecio = $(".Precio-producto").val();
    var otraFechaingreso = $(".FechaIngreso-producto").val();
    var otraImagenproducto = $(".ImagenProducto-producto").val();

    $(".contenedorProducto").text(nombreProducto);
