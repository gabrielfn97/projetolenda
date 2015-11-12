<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCategoria.aspx.cs" Inherits="WebAppExercicio.frmCadCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Classificação de Idade:"></asp:Label>
        <asp:TextBox ID="txtdescricao" runat="server"></asp:TextBox>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Numero do Filme"></asp:Label>
        <asp:TextBox ID="txtNdoFilme" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />
    
    </div>
    </form>
</body>
</html>
