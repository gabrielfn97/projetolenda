<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmcategoriasfilmes.aspx.cs" Inherits="WebAppExercicio.frmcategoriasfilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Generos:"></asp:Label>
        <asp:TextBox ID="txtGeneros" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="Button2" runat="server" Text="Alterar" Width="56px" />
        <asp:Button ID="Button3" runat="server" Text="Deletar" />
        <asp:Button ID="Button4" runat="server" Text="Consultar" OnClick="Button4_Click" />
    
    </div>
    </form>
</body>
</html>
