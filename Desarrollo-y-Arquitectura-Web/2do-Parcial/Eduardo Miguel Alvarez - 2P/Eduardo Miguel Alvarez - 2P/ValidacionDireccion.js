function validarDireccion() {
    var direccion = document.getElementById("textboxDireccion").value;    

    if (direccion === "" ) {
        alert("faltan cargar direccion");
        return false;
    }
    return true;
}