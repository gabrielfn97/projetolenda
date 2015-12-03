<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorias_filmes.aspx.cs" Inherits="WebAppExercicio.categorias_filmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
    
        <asp:Label ID="Label1" runat="server" Text="Generos:"></asp:Label>
        <asp:TextBox ID="txtgenros" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnApagar" runat="server" Text="Apagar" OnClick="Button3_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
    
    </div>
    </form>
</body>
</html>
