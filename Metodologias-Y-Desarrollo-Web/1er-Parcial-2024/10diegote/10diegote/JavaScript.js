function ValidarDatos() {
    var nombre = document.getElementById("txtAlumno").value;
    var nota1 = document.getElementById("txtNota1").value;
    var nota2 = document.getElementById("txtNota2").value;
    var nota3 = document.getElementById("txtNota3").value;

    if (nombre.trim()==="") {
        alert("falta nombre");
        return false;
    }

    if (isNaN(nota1) || nota1 < 1 || nota1 > 10) {
        alert("nota 1 fuera de rango, 1 a 10");
        return false;
    }

    if (isNaN(nota2) || nota2 < 1 || nota2 > 10) {
        alert("nota 2 fuera de rango, 1 a 10");
        return false;
    }

    if (isNaN(nota3) || nota3 < 1 || nota3 > 10) {
        alert("nota 3 fuera de rango, 1 a 10");
        return false;
    }


    return true;
}