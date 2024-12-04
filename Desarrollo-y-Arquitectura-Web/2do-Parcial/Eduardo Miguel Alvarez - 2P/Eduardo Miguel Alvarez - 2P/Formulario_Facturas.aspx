<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario_Facturas.aspx.cs" Inherits="Eduardo_Miguel_Alvarez___2P.Formulario_Facturas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>


    <title>Formulario de Facturas</title>

    <link href="Facturas.css" rel="stylesheet" />

    <script type="text/javascript" src="ValidacionDireccion.js"></script>

</head>
<body>
    <form id="form1" runat="server" onsubmit="return validarDireccion()">

        <div class="contenedor">
            <h1><b>FORMULARIO DE FACTURA</b></h1>        

            <div class ="div">
                <asp:Label ID="lblNombre" runat="server" Text="textboxNombre"><b>Nombre</b></asp:Label><br />
                <asp:TextBox ID="textboxNombre" runat="server" CssClass="imputTextbox"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="textboxNombre" runat="server" ><i>Completar Nombre</i></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblDireccion" runat="server" Text="textboxDireccion"><b>Direccion</b></asp:Label><br />
                <asp:TextBox ID="textboxDireccion" runat="server" CssClass="imputTextbox"></asp:TextBox><br />
            </div>
            <div>
                <asp:Label ID="lblFecha" runat="server" Text="textboxFecha"><b>Fecha</b></asp:Label><br />
                <asp:TextBox ID="textboxFecha" runat="server" CssClass="imputTextbox" TextMode="Date"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="lblNumFactura" runat="server" Text="textboxNumeroFactura"><b>Numero de Factura</b></asp:Label><br />
                <asp:TextBox ID="textboxNumeroFactura" runat="server" CssClass="imputTextbox" required></asp:TextBox><br />
            </div>
            <div>
                <asp:Label ID="lblDescripcion" runat="server" Text="textboxDescripcion" ><b>Descripcion</b></asp:Label><br />
                <asp:TextBox ID="textboxDescripcion" runat="server" TextMode="MultiLine" Rows="4" CssClass="imputTextbox"></asp:TextBox><br />
            </div>
            <div>
                <asp:Label ID="lblCantidad" runat="server" Text="textboxCantidad"><b>Cantidad</b></asp:Label><br />
                <asp:TextBox ID="textboxCantidad" runat="server" CssClass="imputTextbox"></asp:TextBox><br />
            </div>
            <div>
                <asp:Label ID="lblPrecio" runat="server" Text="textboxPrecio"><b>Precio Unitario</b></asp:Label><br />
                <asp:TextBox ID="textboxPrecio" runat="server" CssClass="imputTextbox"></asp:TextBox><br />
            </div>
            <div>
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" class="btn"/>
            </div>


        </div>
        
    </form>
</body>
</html>
