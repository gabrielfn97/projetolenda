<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reGeneros.aspx.cs" Inherits="WebAppExercicio.reGeneros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista de todos os Generos:<br />
        <asp:Table ID="tblGeneros" runat="server">
        </asp:Table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPagInicial" runat="server" OnClick="btnPagInicial_Click" Text="Pagina dos Formularios" />
    
    </div>
    </form>
</body>
</html>
