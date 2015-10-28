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
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:Button ID="Button4" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
