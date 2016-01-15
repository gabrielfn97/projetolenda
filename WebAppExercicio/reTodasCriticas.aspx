<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reTodasCriticas.aspx.cs" Inherits="WebAppExercicio.reTodasCriticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista de Todas as Criticas<br />
        <br />
        <asp:Table ID="tabelaCriticas" runat="server">
        </asp:Table>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pagina dos Formularios" />
    
    </div>
    </form>
</body>
</html>
