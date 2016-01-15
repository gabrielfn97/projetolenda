<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reDadosComplementares.aspx.cs" Inherits="WebAppExercicio.reDadosComplementares" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Lista dos Dados Complementares do Usuario:<br />
        <br />
        <asp:Table ID="tblDados" runat="server">
        </asp:Table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pagina de Formularios" />
    
    </div>
    </form>
</body>
</html>
