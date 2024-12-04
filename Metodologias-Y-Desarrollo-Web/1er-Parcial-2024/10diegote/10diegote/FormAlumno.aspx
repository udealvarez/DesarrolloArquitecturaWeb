<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAlumno.aspx.cs" Inherits="_10diegote.FormAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>formulario de alumno</title>

    <script src="JavaScript.js" type="text/javascript"></script>
    <link href="EstiloAlumno.css" type="text/css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" method="post" action="FormResultado.aspx" onsubmit="return ValidarDatos()" >
        <div>
            <h2>promedio de notas</h2>
            
            <div>
                <label>Alumno: </label>
                <asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Nota 1: </label>
                <asp:TextBox ID="txtNota1" runat="server"></asp:TextBox>
                <label>Nota 2: </label>
                <asp:TextBox ID="txtNota2" runat="server"></asp:TextBox>
                <label>Nota 3: </label>
                <asp:TextBox ID="txtNota3" runat="server"></asp:TextBox>
            </div>

            <div class="btn-container">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" />
            </div>

        </div>
    </form>
</body>
</html>
