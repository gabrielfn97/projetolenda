<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reClassificacao.aspx.cs" Inherits="WebAppExercicio.reClassificacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista de Todas as Classificações Indicativas:<br />
        <asp:Table ID="tblClassificacao" runat="server">
        </asp:Table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPagInicial" runat="server" OnClick="btnPagInicial_Click1" Text="Pagina de Formularios" />
    
    </div>
    </form>
</body>
</html>
