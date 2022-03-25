//Definir el evento click
$("#btnGuardar").click(function () {

    //2 obtener el valor del input nombre-categoria
    var nombreCategoria = $(".nombre-categoria").val();


    //2 obtener el valor del input otra-clase
    var otraClase = $(".otra-clase").val();



    if (nombreCategoria == "" || otraClase == "") {

        Swal.fire({
            icon: 'Peligro',
            title: 'Lo sentimos',
            text: 'Todos los campos son requeridos!',
        })

    }
    else {
        var xhr = $.ajax({
            //url de destino
            url: "CrearCategoria",
            type: "POST",
            //agregar parametros de la peticion
            data: {
                "NombreCategoria": nombreCategoria,
                "Descripcion": otraClase
            }

        })

        //mensaje de respuesta
        xhr.done(function () {

            notif({
                msg: "Categoria guardada correctamente.",
                type: "success",

            });
            // Luego de 2 segundos redirecionar ala lista de categorias
            setTimeout(function (){
                location.href = "https://localhost:44302/home/ListaCategorias"
            }, 2000)
            //limpiamos input
            //$(".nombre-categoria").val("");
            //$(".otra-clase").val("");
        });



        xhr.fail(function () {
            notif({
                msg: "<Error al guardar la categoria.",
                type: "error"
            });
        })
    }
   
    

})