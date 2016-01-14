<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reNoticias.aspx.cs" Inherits="WebAppExercicio.reNoticias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Listar Noticias<br />
        <br />
        <asp:Table ID="tabelaNoticias" runat="server">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
