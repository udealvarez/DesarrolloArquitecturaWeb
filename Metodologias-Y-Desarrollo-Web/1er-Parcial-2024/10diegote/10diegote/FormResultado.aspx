<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormResultado.aspx.cs" Inherits="_10diegote.FormResultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FORMULARIO DE RESULTADOS</title>
    <link href="Resultado.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>RESULTADOS</h2>

            <div>
                <label>Alumno:</label>
                <asp:Label ID="lblAlumno" runat="server"></asp:Label>
            </div>
            <div>
                <label>Promedio:</label>
                <asp:Label ID="lblPromedio" runat="server"></asp:Label>
            </div>
            <div>
                <label>Condicion:</label>
                <asp:Label ID="lblCondicion" runat="server"></asp:Label>
            </div>
            <div>
                <label>Nota Menor:</label>
                <asp:Label ID="lblNotaMenor" runat="server"></asp:Label>
            </div>

            <div>
                <asp:Button ID="btnDescargarXML" runat="server" Text="DESCARGAR XML" OnClick="btnDescargarXML_Click" />
            </div>
        </div>
    </form>
</body>
</html>
