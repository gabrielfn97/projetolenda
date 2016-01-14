<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reTodasCriticas.aspx.cs" Inherits="WebAppExercicio.reTodasCriticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Relatorio de Criticas"></asp:Label>
        <asp:Table ID="tblTodasCriticas" runat="server">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
