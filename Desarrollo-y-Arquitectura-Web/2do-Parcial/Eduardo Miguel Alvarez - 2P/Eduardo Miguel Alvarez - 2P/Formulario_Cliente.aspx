<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario_Cliente.aspx.cs" Inherits="Eduardo_Miguel_Alvarez___2P.Formulario_Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title><b>Formulario de Clientes</b></title>

    <link href="Clientes.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">

            <h1><b>Factura Cliente</b></h1>

            <p><b>Nombre: </b>   <asp:Label ID="LabelNombre" runat="server" ></asp:Label> </p>
            <p><b>Fecha: </b>   <asp:Label ID="LabelFecha" runat="server" ></asp:Label> </p>
            <p><b>Factura: </b>   <asp:Label ID="LabelFactura" runat="server"></asp:Label> </p>
            <p><b>Total: </b>   <asp:Label ID="LabelTotal" runat="server"></asp:Label> </p>

        </div>
    </form>
</body>
</html>
