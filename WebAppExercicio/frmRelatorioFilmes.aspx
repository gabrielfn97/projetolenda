<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRelatorioFilmes.aspx.cs" Inherits="WebAppExercicio.frmRelatorioFilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Lista de todos os filmes"></asp:Label>
        <br />
        <asp:Table ID="tabelaFilmes" runat="server">
        </asp:Table>
        <br />
    
    </div>
    </form>
</body>
</html>
