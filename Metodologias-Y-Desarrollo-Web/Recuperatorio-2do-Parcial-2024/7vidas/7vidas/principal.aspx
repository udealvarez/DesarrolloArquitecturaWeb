<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principal.aspx.cs" Inherits="_7vidas.principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>inventario de productos</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Productos</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />
                    
                    <asp:Label ID="lblCantidad" runat="server" Text="Cantida"></asp:Label><br />
                    <asp:Label ID="lblPrecioTotal" runat="server" Text="Precio total:  $ 0.00"></asp:Label><br /><br />

                    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />

                    <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />

                    <asp:Label ID="Label5" runat="server" Text="Cantidad"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox><br /><br />

                    <asp:Button ID="altaProducto" runat="server" Text="Alta Producto" OnClick="altaProducto_Click" /><br /><br />
                    <asp:Button ID="descargaXML" runat="server" Text="Descarga XML" OnClick="descargaXML_Click" /><br />
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
