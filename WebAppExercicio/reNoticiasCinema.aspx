<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reNoticiasCinema.aspx.cs" Inherits="WebAppExercicio.reNoticiasCinema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista de Notícias Cinema<br />
        <br />
        <asp:Table ID="tabelaNoticiasCinema" runat="server">
        </asp:Table>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Pagina dos Formularios" />
    
    </div>
    </form>
</body>
</html>
