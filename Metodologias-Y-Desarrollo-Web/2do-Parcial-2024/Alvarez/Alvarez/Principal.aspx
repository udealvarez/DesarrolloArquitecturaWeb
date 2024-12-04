<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Alvarez.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lista de sarasa</title>
    <script src="JavaScript.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Estilos.css" rel="stylesheet" />
    <%--<script>
        $(document).ready(function () {
            cargarLibros();
        });
    </script>--%>

</head>

<body>
    <form id="form1" runat="server" class="simple-form">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <h1>inventario de libros</h1>
            <h2>gestion de libros</h2>
        </div>
        <div>
            <asp:Label ID="lblCantLibros" runat="server" Text="Cantidad de libros: "></asp:Label>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    
                    <asp:Table ID="TableLibros" runat="server" width="460px" BorderWidth="1">
                        <asp:TableRow>
                            <asp:TableCell Text="Nombre" BorderWidth="1"></asp:TableCell>
                            <asp:TableCell Text="Autor" BorderWidth="1"></asp:TableCell>
                            <asp:TableCell Text="Edicion" BorderWidth="1"></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <br />
                    <br />

                    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" required></asp:TextBox><br />

                    <asp:Label ID="Label2" runat="server" Text="Autor"></asp:Label>
                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox><br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAutor" ErrorMessage="debe completa este campo"></asp:RequiredFieldValidator><br />--%>


                    <asp:Label ID="Label3" runat="server" Text="Edicion"></asp:Label>
                    <asp:TextBox ID="txtEdicion" runat="server"></asp:TextBox><br />

                    <div>
                        <asp:Button  ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
                    </div>

                </ContentTemplate>            
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
