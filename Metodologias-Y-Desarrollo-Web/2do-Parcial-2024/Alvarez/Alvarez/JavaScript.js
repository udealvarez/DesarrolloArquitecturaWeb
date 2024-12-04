function cargarLibros() {
    
        $.ajax({
            type: "POST",
            url: "WebService1.asmx/ObtenerLibros",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                // Obtener los datos de la respuesta
                const libros = response.d;

                // Limpiar la tabla existente
                $("#TableLibros").empty();

                // Crear filas dinámicamente
                libros.forEach(libro => {
                    const fila = `  
                        <tr>
                            <td>${libro.Nombre}</td>
                            <td>${libro.Autor}</td>
                            <td>${libro.Edicion}</td>                            
                        </tr>`;
                    $("#TableLibros").append(fila);
                });

                const cantidadLibros = libros.length;
                $("#lblCantLibros").text(`Cantidad de libros: ${cantidadLibros}`);
            },
            //error: function (error) {
            //    console.error("Error al obtener los datos:", error);
            //}
        });
}

